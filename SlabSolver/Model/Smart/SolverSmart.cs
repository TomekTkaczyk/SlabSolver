using SlabSolver.Domain;
using SlabSolver.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SlabSolver.Model.Smart
{
    public class SolverSmart : ISlabSolver
    {
        private readonly ISlabService _service;

        public SolverSmart(ISlabService service)
        {
            _service = service;
        }

        public IList<SlabResult> SolveByLoad(int span, Loads load, Exposure exposure, FireResistance resistance)
        {
            var slabs = new List<SlabResult>();
            foreach (SlabSmart slab in _service.Slabs.Where(x => x.FireResistance == resistance).Cast<SlabSmart>())
            {
                var capacities = slab.LoadCapacity.OrderBy(x => x.Span);
                LoadCapacity? capacity = null;

                var left = GetLeft(capacities, span);
                var right = GetRight(capacities, span);
                if (right != null)
                {
                    if (left is null)
                    {
                        capacity = right;
                    }
                    else
                    {
                        // interpolacja;
                        var factory = (float)(span - left.Span) / (float)(right.Span - left.Span);
                        capacity = new LoadCapacity(
                            span,
                            left.Pd + (right.Pd - left.Pd) * factory,
                            left.Pk2a + (right.Pk2a - left.Pk2a) * factory,
                            left.Pk2b + (right.Pk2b - left.Pk2b) * factory,
                            left.Pka2b + (right.Pka2b - left.Pka2b) * factory
                            );
                    }
                }
                if (capacity != null)
                {
                    if (Math.Min(load.ULS_STR, Math.Max(load.ULS_STR_A, load.ULS_STR_B)) < capacity.Pd)
                    {
                        switch (exposure)
                        {
                            case Exposure.X0:
                            case Exposure.XC1:
                                {
                                    if ((load.SLS_QPER < capacity.Pka2b) && (load.SLS_QPER < capacity.Pk2b))
                                    {
                                        AddCapacity(slab, capacity);
                                        var conditions = new List<Tuple<string, float>>
                                        {
                                          new Tuple<string,float>("Zarysowanie", load.SLS_QPER/capacity.Pk2b),
                                          new Tuple<string,float>("Ugięcie", load.SLS_QPER/capacity.Pka2b),
                                        };
                                        slabs.Add(new SlabResult(slab, conditions));
                                    }
                                    break;
                                }
                            case Exposure.XC2:
                            case Exposure.XC3:
                            case Exposure.XC4:
                                {
                                    if ((load.SLS_QPER < capacity.Pka2b) && (load.SLS_QPER < capacity.Pk2a) && (load.SLS_FREQ < capacity.Pk2b))
                                    {
                                        AddCapacity(slab, capacity);
                                        var conditions = new List<Tuple<string, float>>
                                        {
                                          new Tuple<string,float>("Dekompresja", load.SLS_QPER/capacity.Pk2a),
                                          new Tuple<string,float>("Zarysowanie", load.SLS_FREQ/capacity.Pk2b),
                                          new Tuple<string,float>("Ugięcie", load.SLS_QPER/capacity.Pka2b),
                                        };
                                        slabs.Add(new SlabResult(slab, conditions));
                                    }
                                    break;
                                }
                        }
                    }
                }
            }

            return slabs;
        }
        public IList<SlabResult> SolveByEffect(float Vrd, float Mrd, float Mcr, float Mcrfreq, float Mcrqper, Exposure exposure, FireResistance resistance)
        {
            var slabs = new List<SlabResult>();
            foreach (SlabSmart slab in _service.Slabs.Where(x => x.FireResistance == resistance).Cast<SlabSmart>())
            {
                switch (exposure)
                {
                    case Exposure.X0:
                    case Exposure.XC1:
                        {
                            if (Mrd < slab.Mrd && Mcrqper < slab.Mcrw02 && Vrd < slab.Vrd)
                            {
                                var conditions = new List<Tuple<string, float>>
                                        {
                                          new Tuple<string,float>("Nośność", Mrd/slab.Mrd),
                                          new Tuple<string,float>("Zarysowanie", Mcrqper/slab.Mcrw02),
                                          new Tuple<string,float>("Siła poprzeczna", Vrd/slab.Vrd),
                                        };
                                slabs.Add(new SlabResult(slab, conditions));
                            }
                            break;
                        }
                    case Exposure.XC2:
                    case Exposure.XC3:
                    case Exposure.XC4:
                        {
                            if (Mrd < slab.Mrd && Mcrfreq < slab.Mcrw02 && Mcrqper < slab.Mdec && Vrd < slab.Vrd)
                            {
                                var conditions = new List<Tuple<string, float>>
                                        {
                                          new Tuple<string,float>("Nośność", Mrd/slab.Mrd),
                                          new Tuple<string,float>("Zarysowanie", Mcrfreq/slab.Mcrw02),
                                          new Tuple<string,float>("Dekompresja", Mcrqper/slab.Mdec),
                                          new Tuple<string,float>("Siła poprzeczna", Vrd/slab.Vrd),
                                        };
                                slabs.Add(new SlabResult(slab, conditions));
                            }
                            break;
                        }
                }
            }

            return slabs;
        }

        private LoadCapacity? GetLeft(IOrderedEnumerable<LoadCapacity> capacities, int span)
        {
            LoadCapacity? result = null;

            foreach (var item in capacities)
            {
                if (span > item.Span)
                {
                    result = item;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        private LoadCapacity? GetRight(IOrderedEnumerable<LoadCapacity> capacities, int span)
        {
            foreach (var item in capacities)
            {
                if (span <= item.Span)
                {
                    return item;
                }
            }

            return null;
        }

        private void AddCapacity(SlabSmart slab, LoadCapacity capacity)
        {
            if (slab.LoadCapacity == null)
            {
                slab.LoadCapacity = new List<LoadCapacity> { capacity };
            }
            else
            {
                slab.LoadCapacity.Add(capacity);
            }
        }


    }
}
