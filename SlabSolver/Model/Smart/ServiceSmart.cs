using SlabSolver.Domain;
using SlabSolver.Enums;
using System.Collections.Generic;
using System.Linq;

namespace SlabSolver.Model.Smart
{
    public class ServiceSmart : ISlabService
    {
        private readonly List<Slab> _slabs = new List<Slab>();
        public IList<Slab> Slabs { get { return _slabs.AsReadOnly(); } }

        public ServiceSmart()
        {
            SlabInitialize();
        }

        public Slab GetSlab(string signature)
        {
            return Slabs.First(x => x.Signature == signature);
        }

        private void Slab_15_2x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 15/60 2ø9.3+2ø6.85,kanały 60x90,REI60",
            thickness: 15,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 14.0f,
            mcr_topedge: -10.1f,
            mcrw02: 14.1f,
            mdec: 6.9f,
            mrd: 16.7f,
            mrd_topedge: -11.5f,
            vrd: 46.0f,
            q: 2.45f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 35.4f, 13.3f, 30.0f, 59.9f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 27.3f, 10.0f, 23.2f, 42.4f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 21.4f, 7.6f, 18.3f, 31.0f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 17.2f, 5.9f, 14.7f, 23.3f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 13.9f, 4.6f, 12.0f, 17.8f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 11.3f, 3.5f, 9.9f, 13.8f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 9.3f, 2.7f, 8.2f, 10.8f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 7.7f, 2.1f, 6.8f, 8.5f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 6.4f, 1.5f, 5.7f, 6.7f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 5.3f, 1.1f, 4.8f, 5.3f));

            _slabs.Add(slab);
        }

        private void Slab_15_4x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 15/60 4ø9.3+2ø6.85,kanały 60x90,REI60",
            thickness: 15,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 21.1f,
            mcr_topedge: -9.1f,
            mcrw02: 27.6f,
            mdec: 13.8f,
            mrd: 30.2f,
            mrd_topedge: -13.5f,
            vrd: 55.9f,
            q: 2.45f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 66.6f, 29.2f, 61.0f, 74.8f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 51.9f, 22.6f, 47.7f, 54.2f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 41.4f, 17.8f, 38.2f, 40.5f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 33.7f, 14.3f, 31.2f, 31.1f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 27.8f, 11.7f, 25.8f, 24.4f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 23.2f, 9.6f, 21.7f, 19.4f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 19.5f, 7.9f, 18.4f, 15.6f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 16.6f, 6.6f, 15.7f, 12.7f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 14.2f, 5.5f, 13.5f, 10.4f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 12.2f, 4.6f, 11.7f, 8.6f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 10.5f, 3.9f, 10.2f, 7.1f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 9.1f, 3.2f, 8.9f, 5.9f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 7.9f, 2.7f, 7.8f, 4.9f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 6.8f, 2.2f, 6.9f, 3.9f));

            _slabs.Add(slab);
        }

        private void Slab_15_2x125_2x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 15/60 2ø12.5+2ø9.3+2ø6.85,kanały 60x90,REI60",
            thickness: 15,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 26.4f,
            mcr_topedge: -8.3f,
            mcrw02: 37.9f,
            mdec: 19.1f,
            mrd: 39.9f,
            mrd_topedge: -14.7f,
            vrd: 61.0f,
            q: 2.45f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 79.1f, 41.2f, 84.7f, 85.8f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 69.7f, 32.0f, 66.5f, 62.9f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 55.8f, 25.5f, 53.4f, 47.6f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 45.6f, 20.7f, 43.7f, 37.0f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 37.7f, 17.0f, 36.4f, 29.3f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 31.7f, 14.2f, 30.7f, 23.6f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 26.9f, 11.9f, 26.1f, 19.2f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 23.0f, 10.1f, 22.5f, 15.9f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 19.8f, 8.6f, 19.5f, 13.2f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 17.1f, 7.3f, 17.0f, 11.1f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 14.9f, 6.3f, 14.9f, 9.3f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 13.1f, 5.4f, 13.1f, 7.9f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 11.5f, 4.6f, 11.6f, 6.7f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 10.1f, 4.0f, 10.3f, 5.5f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 8.9f, 3.4f, 9.2f, 4.6f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 7.9f, 2.9f, 8.2f, 3.8f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 7.0f, 2.5f, 7.4f, 3.1f));

            _slabs.Add(slab);
        }

        private void Slab_15_6x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 15/60 6ø9.3+2ø6.85,kanały 60x90,REI60",
            thickness: 15,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 27.7f,
            mcr_topedge: -8.1f,
            mcrw02: 40.6f,
            mdec: 20.4f,
            mrd: 42.4f,
            mrd_topedge: -14.9f,
            vrd: 61.3f,
            q: 2.45f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 80.6f, 44.3f, 91.0f, 88.7f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 71.3f, 34.5f, 71.4f, 65.2f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 59.5f, 27.5f, 57.4f, 49.4f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 48.6f, 22.3f, 47.1f, 38.5f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 40.3f, 18.4f, 39.2f, 30.6f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 33.8f, 15.3f, 33.0f, 24.7f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 28.7f, 12.9f, 28.2f, 20.2f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 24.6f, 10.9f, 24.3f, 16.7f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 21.2f, 9.3f, 21.0f, 13.9f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 18.4f, 8.0f, 18.4f, 11.7f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 16.1f, 6.9f, 16.2f, 9.9f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 14.1f, 6.0f, 14.3f, 8.4f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 12.4f, 5.1f, 12.6f, 7.1f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 10.9f, 4.5f, 11.3f, 6.0f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 9.7f, 3.9f, 10.1f, 5.0f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 8.6f, 3.3f, 9.0f, 4.2f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 7.6f, 2.9f, 8.1f, 3.5f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 6.7f, 2.5f, 7.3f, 2.9f));

            _slabs.Add(slab);
        }

        private void Slab_15_4x125_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 15/60 4ø12.5+2ø6.85,kanały 60x90,REI60",
            thickness: 15,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 31.4f,
            mcr_topedge: -7.6f,
            mcrw02: 48.0f,
            mdec: 24.1f,
            mrd: 48.7f,
            mrd_topedge: -15.4f,
            vrd: 61.3f,
            q: 2.45f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 81.9f, 52.7f, 107.8f, 96.4f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 72.4f, 41.1f, 84.7f, 71.2f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 64.8f, 32.9f, 68.2f, 54.3f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 56.4f, 26.8f, 56.0f, 42.5f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 46.8f, 22.1f, 46.7f, 34.0f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 39.4f, 18.5f, 39.4f, 27.6f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 33.5f, 15.7f, 33.7f, 22.7f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 28.8f, 13.3f, 29.1f, 18.9f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 24.9f, 11.5f, 25.3f, 15.8f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 21.7f, 9.9f, 22.1f, 13.4f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 19.0f, 8.6f, 19.5f, 11.4f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 16.7f, 7.5f, 17.3f, 9.8f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 14.7f, 6.5f, 15.4f, 8.4f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 13.1f, 5.7f, 13.7f, 7.1f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 11.6f, 5.0f, 12.3f, 6.0f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 10.3f, 4.4f, 11.1f, 5.1f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 9.2f, 3.8f, 10.0f, 4.3f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 8.2f, 3.3f, 9.0f, 3.7f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 7.4f, 2.9f, 8.2f, 3.1f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 6.6f, 2.5f, 7.4f, 2.7f));

            _slabs.Add(slab);
        }

        private void Slab_15_2x125_4x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 15/60 2ø12.5+4ø9.3+2ø6.85,kanały 60x90,REI60",
            thickness: 15,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 32.8f,
            mcr_topedge: -7.4f,
            mcrw02: 50.6f,
            mdec: 25.4f,
            mrd: 50.9f,
            mrd_topedge: -15.5f,
            vrd: 61.3f,
            q: 2.45f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 81.9f, 55.7f, 113.9f, 99.2f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 72.4f, 43.5f, 89.6f, 73.4f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 64.8f, 34.8f, 72.1f, 56.1f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 58.6f, 28.4f, 59.2f, 44.0f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 49.1f, 23.5f, 49.4f, 35.2f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 41.3f, 19.7f, 41.8f, 28.6f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 35.2f, 16.7f, 35.7f, 23.6f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 30.2f, 14.2f, 30.8f, 19.7f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 26.2f, 12.2f, 26.8f, 16.5f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 22.8f, 10.6f, 23.5f, 14.0f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 20.0f, 9.2f, 20.7f, 12.0f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 17.6f, 8.0f, 18.4f, 10.3f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 15.6f, 7.0f, 16.4f, 8.8f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 13.8f, 6.1f, 14.6f, 7.5f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 12.3f, 5.4f, 13.1f, 6.4f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 11.0f, 4.7f, 11.8f, 5.4f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 9.8f, 4.2f, 10.7f, 4.6f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 8.8f, 3.7f, 9.7f, 3.9f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 7.9f, 3.2f, 8.8f, 3.4f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 7.0f, 2.8f, 8.0f, 2.9f));

            _slabs.Add(slab);
        }

        private void Slab_20_2x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 2ø9.3+2ø6.85,kanały 60x140,REI60",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 23.0f,
            mcr_topedge: -16.5f,
            mcrw02: 20.4f,
            mdec: 10.3f,
            mrd: 23.7f,
            mrd_topedge: -15.4f,
            vrd: 59.0f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 50.8f, 20.6f, 44.1f, 134.6f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 39.3f, 15.7f, 34.2f, 95.4f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 31.1f, 12.1f, 27.2f, 69.9f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 25.0f, 9.5f, 21.9f, 52.7f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 20.3f, 7.5f, 18.0f, 40.6f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 16.7f, 6.0f, 14.9f, 31.8f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 13.9f, 4.8f, 12.4f, 25.3f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 11.6f, 3.8f, 10.5f, 20.3f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 9.7f, 3.0f, 8.8f, 16.5f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 8.1f, 2.3f, 7.5f, 13.5f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 6.8f, 1.7f, 6.4f, 11.0f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 5.7f, 1.3f, 5.4f, 9.1f));

            _slabs.Add(slab);
        }

        private void Slab_20_4x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 4ø9.3+2ø6.85,kanały 60x140,REI60",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 34.1f,
            mcr_topedge: -14.2f,
            mcrw02: 41.0f,
            mdec: 21.2f,
            mrd: 44.1f,
            mrd_topedge: -17.4f,
            vrd: 70.0f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 91.4f, 45.7f, 91.3f, 158.8f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 76.7f, 35.5f, 71.6f, 114.4f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 61.4f, 28.2f, 57.4f, 85.3f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 50.0f, 22.8f, 47.0f, 65.4f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 41.4f, 18.7f, 39.0f, 51.3f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 34.7f, 15.5f, 32.8f, 40.9f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 29.3f, 13.0f, 27.9f, 33.1f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 25.0f, 11.0f, 24.0f, 27.2f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 21.5f, 9.3f, 20.7f, 22.5f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 18.6f, 7.9f, 18.0f, 18.8f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 16.2f, 6.7f, 15.8f, 15.8f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 14.1f, 5.7f, 13.9f, 13.3f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 12.3f, 4.9f, 12.2f, 11.3f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 10.8f, 4.2f, 10.8f, 9.3f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 9.5f, 3.6f, 9.6f, 7.7f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 8.3f, 3.0f, 8.6f, 6.3f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 7.3f, 2.5f, 7.6f, 5.2f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 6.4f, 2.1f, 6.8f, 4.3f));

            _slabs.Add(slab);
        }

        private void Slab_20_2x125_2x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 2ø12.5+2ø9.3+2ø6.85,kanały 60x140,REI60",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 42.5f,
            mcr_topedge: -12.6f,
            mcrw02: 56.7f,
            mdec: 29.5f,
            mrd: 59.3f,
            mrd_topedge: -18.6f,
            vrd: 79.2f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 102.4f, 64.6f, 127.6f, 176.9f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 90.6f, 50.5f, 100.2f, 128.7f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 81.2f, 40.4f, 80.7f, 96.9f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 68.6f, 32.9f, 66.2f, 74.9f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 57.0f, 27.2f, 55.2f, 59.3f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 48.0f, 22.7f, 46.6f, 47.7f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 40.8f, 19.2f, 39.8f, 39.0f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 35.0f, 16.4f, 34.3f, 32.3f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 30.3f, 14.1f, 29.8f, 27.0f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 26.4f, 12.1f, 26.1f, 22.7f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 23.1f, 10.5f, 23.0f, 19.3f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 20.3f, 9.1f, 20.3f, 16.5f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 17.9f, 8.0f, 18.1f, 14.2f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 15.9f, 7.0f, 16.1f, 11.9f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 14.1f, 6.1f, 14.5f, 10.1f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 12.6f, 5.3f, 13.0f, 8.5f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 11.2f, 4.7f, 11.7f, 7.2f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 10.0f, 4.1f, 10.6f, 6.2f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 9.0f, 3.6f, 9.6f, 5.3f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 8.0f, 3.1f, 8.7f, 4.6f));
            slab.LoadCapacity.Add(new LoadCapacity(840, 7.2f, 2.7f, 7.9f, 4.0f));

            _slabs.Add(slab);
        }

        private void Slab_20_6x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 6ø9.3+2ø6.85,kanały 60x140,REI60",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 44.7f,
            mcr_topedge: -12.1f,
            mcrw02: 60.9f,
            mdec: 31.6f,
            mrd: 63.3f,
            mrd_topedge: -18.8f,
            vrd: 81.4f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 105.3f, 69.6f, 137.2f, 181.6f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 93.2f, 54.4f, 107.8f, 132.4f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 83.5f, 43.5f, 86.8f, 99.9f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 73.4f, 35.5f, 71.2f, 77.4f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 61.1f, 29.4f, 59.4f, 61.3f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 51.4f, 24.6f, 50.2f, 49.5f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 43.8f, 20.8f, 42.9f, 40.5f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 37.6f, 17.8f, 37.0f, 33.6f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 32.6f, 15.3f, 32.2f, 28.1f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 28.4f, 13.2f, 28.2f, 23.8f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 24.9f, 11.5f, 24.9f, 20.2f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 21.9f, 10.0f, 22.0f, 17.3f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 19.4f, 8.8f, 19.6f, 14.9f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 17.2f, 7.7f, 17.6f, 12.6f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 15.3f, 6.8f, 15.7f, 10.7f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 13.7f, 6.0f, 14.2f, 9.1f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 12.2f, 5.2f, 12.8f, 7.8f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 11.0f, 4.6f, 11.6f, 6.6f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 9.8f, 4.1f, 10.5f, 5.8f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 8.8f, 3.6f, 9.5f, 5.0f));
            slab.LoadCapacity.Add(new LoadCapacity(840, 7.9f, 3.1f, 8.7f, 4.4f));
            slab.LoadCapacity.Add(new LoadCapacity(870, 7.1f, 2.7f, 7.9f, 3.8f));

            _slabs.Add(slab);
        }

        private void Slab_20_4x125_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 4ø12.5+2ø6.85,kanały 60x140,REI60",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 50.6f,
            mcr_topedge: -11.0f,
            mcrw02: 72.1f,
            mdec: 37.4f,
            mrd: 73.6f,
            mrd_topedge: -19.3f,
            vrd: 86.1f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 111.6f, 82.9f, 162.9f, 194.2f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 98.8f, 64.9f, 128.2f, 142.4f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 88.5f, 52.1f, 103.3f, 107.9f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 80.1f, 42.6f, 84.9f, 84.1f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 71.7f, 35.3f, 70.9f, 66.9f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 60.5f, 29.7f, 60.0f, 54.2f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 51.6f, 25.2f, 51.4f, 44.6f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 44.5f, 21.6f, 44.4f, 37.2f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 38.6f, 18.7f, 38.7f, 31.3f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 33.7f, 16.2f, 34.0f, 26.6f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 29.6f, 14.2f, 30.0f, 22.7f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 26.2f, 12.4f, 26.7f, 19.6f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 23.2f, 10.9f, 23.8f, 16.9f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 20.7f, 9.7f, 21.3f, 14.4f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 18.5f, 8.6f, 19.2f, 12.3f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 16.6f, 7.6f, 17.3f, 10.6f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 14.9f, 6.8f, 15.7f, 9.2f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 13.4f, 6.0f, 14.2f, 7.9f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 12.1f, 5.3f, 13.0f, 7.0f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 10.9f, 4.8f, 11.8f, 6.1f));
            slab.LoadCapacity.Add(new LoadCapacity(840, 9.9f, 4.2f, 10.8f, 5.4f));
            slab.LoadCapacity.Add(new LoadCapacity(870, 8.9f, 3.8f, 9.9f, 4.7f));
            slab.LoadCapacity.Add(new LoadCapacity(900, 8.1f, 3.3f, 9.1f, 4.2f));
            slab.LoadCapacity.Add(new LoadCapacity(930, 7.3f, 2.9f, 8.3f, 3.6f));

            _slabs.Add(slab);
        }

        private void Slab_20_2x125_4x93_REI60()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 2ø12.5+4ø9.3+2ø6.85,kanały 60x140,REI60",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI60,
            mcr: 52.7f,
            mcr_topedge: -10.6f,
            mcrw02: 76.2f,
            mdec: 39.6f,
            mrd: 77.3f,
            mrd_topedge: -19.4f,
            vrd: 86.1f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 113.3f, 87.8f, 172.4f, 198.8f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 100.3f, 68.8f, 135.6f, 146.0f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 89.9f, 55.2f, 109.3f, 110.8f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 81.4f, 45.1f, 89.9f, 86.5f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 74.3f, 37.5f, 75.1f, 68.9f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 63.8f, 31.5f, 63.6f, 55.9f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 54.4f, 26.8f, 54.5f, 46.1f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 46.9f, 23.0f, 47.1f, 38.4f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 40.7f, 19.9f, 41.1f, 32.4f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 35.6f, 17.3f, 36.1f, 27.6f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 31.3f, 15.1f, 31.9f, 23.6f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 27.7f, 13.3f, 28.3f, 20.4f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 24.6f, 11.7f, 25.3f, 17.7f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 22.0f, 10.4f, 22.7f, 15.1f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 19.6f, 9.2f, 20.5f, 13.0f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 17.6f, 8.2f, 18.5f, 11.2f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 15.9f, 7.3f, 16.8f, 9.7f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 14.3f, 6.5f, 15.2f, 8.4f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 12.9f, 5.8f, 13.9f, 7.4f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 11.7f, 5.2f, 12.7f, 6.5f));
            slab.LoadCapacity.Add(new LoadCapacity(840, 10.6f, 4.6f, 11.6f, 5.8f));
            slab.LoadCapacity.Add(new LoadCapacity(870, 9.6f, 4.1f, 10.6f, 5.1f));
            slab.LoadCapacity.Add(new LoadCapacity(900, 8.7f, 3.7f, 9.8f, 4.5f));
            slab.LoadCapacity.Add(new LoadCapacity(930, 7.9f, 3.3f, 9.0f, 3.9f));

            _slabs.Add(slab);
        }

        private void Slab_20_2x93_REI120()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 2ø9.3+2ø6.85,kanały 60x140,REI120",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI120,
            mcr: 21.0f,
            mcr_topedge: -18.9f,
            mcrw02: 17.1f,
            mdec: 8.3f,
            mrd: 20.9f,
            mrd_topedge: -17.4f,
            vrd: 53.0f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 44.3f, 16.1f, 36.5f, 133.0f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 34.2f, 12.1f, 28.2f, 93.6f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 26.9f, 9.2f, 22.3f, 68.1f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 21.6f, 7.1f, 17.9f, 51.0f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 17.5f, 5.5f, 14.6f, 39.0f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 14.3f, 4.3f, 12.0f, 30.3f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 11.8f, 3.3f, 9.9f, 23.9f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 9.7f, 2.5f, 8.3f, 19.0f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 8.1f, 1.8f, 6.9f, 15.3f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 6.7f, 1.3f, 5.8f, 12.3f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 5.5f, 0.8f, 4.8f, 10.0f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 4.5f, 0.4f, 4.0f, 8.1f));

            _slabs.Add(slab);
        }

        private void Slab_20_4x93_REI120()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 4ø9.3+2ø6.85,kanały 60x140,REI120",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI120,
            mcr: 30.1f,
            mcr_topedge: -19.0f,
            mcrw02: 34.5f,
            mdec: 17.4f,
            mrd: 38.6f,
            mrd_topedge: -21.6f,
            vrd: 63.2f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 82.7f, 37.0f, 76.6f, 151.6f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 66.5f, 28.6f, 59.9f, 108.2f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 53.1f, 22.6f, 48.0f, 80.0f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 43.2f, 18.2f, 39.2f, 60.8f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 35.6f, 14.8f, 32.4f, 47.2f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 29.8f, 12.2f, 27.2f, 37.3f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 25.1f, 10.1f, 23.1f, 29.9f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 21.4f, 8.4f, 19.7f, 24.3f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 18.3f, 7.1f, 17.0f, 19.9f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 15.7f, 5.9f, 14.7f, 16.5f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 13.6f, 5.0f, 12.8f, 13.7f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 11.8f, 4.2f, 11.2f, 11.4f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 10.3f, 3.5f, 9.8f, 9.5f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 8.9f, 2.9f, 8.6f, 7.7f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 7.8f, 2.4f, 7.6f, 6.2f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 6.8f, 1.9f, 6.7f, 4.9f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 5.9f, 1.5f, 5.9f, 3.9f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 5.1f, 1.2f, 5.2f, 3.1f));

            _slabs.Add(slab);
        }

        private void Slab_20_2x125_2x93_REI120()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 2ø12.5+2ø9.3+2ø6.85,kanały 60x140,REI120",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI120,
            mcr: 37.1f,
            mcr_topedge: -19.1f,
            mcrw02: 47.9f,
            mdec: 24.3f,
            mrd: 51.6f,
            mrd_topedge: -24.3f,
            vrd: 71.0f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 93.2f, 52.9f, 107.5f, 165.7f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 82.4f, 41.2f, 84.3f, 119.3f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 72.4f, 32.8f, 67.8f, 89.0f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 59.1f, 26.6f, 55.5f, 68.2f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 49.0f, 21.9f, 46.2f, 53.4f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 41.2f, 18.2f, 38.9f, 42.6f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 34.9f, 15.3f, 33.2f, 34.5f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 29.9f, 13.0f, 28.5f, 28.3f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 25.8f, 11.1f, 24.7f, 23.4f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 22.4f, 9.5f, 21.6f, 19.6f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 19.6f, 8.1f, 18.9f, 16.4f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 17.1f, 7.0f, 16.7f, 13.9f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 15.1f, 6.0f, 14.8f, 11.8f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 13.3f, 5.2f, 13.2f, 9.7f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 11.8f, 4.5f, 11.7f, 8.0f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 10.4f, 3.9f, 10.5f, 6.6f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 9.2f, 3.3f, 9.4f, 5.5f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 8.2f, 2.8f, 8.4f, 4.5f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 7.3f, 2.4f, 7.6f, 3.8f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 6.5f, 2.0f, 6.8f, 3.2f));
            slab.LoadCapacity.Add(new LoadCapacity(840, 5.7f, 1.7f, 6.1f, 2.6f));

            _slabs.Add(slab);
        }

        private void Slab_20_6x9_REI120()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 6ø9.3+26.85,kanały 60x140,REI120",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI120,
            mcr: 38.9f,
            mcr_topedge: -19.1f,
            mcrw02: 51.5f,
            mdec: 26.1f,
            mrd: 54.9f,
            mrd_topedge: -25.0f,
            vrd: 72.5f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 95.2f, 57.1f, 115.7f, 169.4f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 84.2f, 44.5f, 90.8f, 122.3f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 75.4f, 35.5f, 73.0f, 91.3f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 63.2f, 28.8f, 59.8f, 70.1f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 52.5f, 23.8f, 49.8f, 55.1f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 44.1f, 19.8f, 42.0f, 44.0f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 37.5f, 16.7f, 35.9f, 35.7f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 32.1f, 14.2f, 30.9f, 29.3f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 27.8f, 12.1f, 26.8f, 24.3f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 24.1f, 10.4f, 23.4f, 20.4f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 21.1f, 9.0f, 20.6f, 17.2f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 18.5f, 7.7f, 18.2f, 14.5f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 16.3f, 6.7f, 16.1f, 12.4f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 14.4f, 5.8f, 14.3f, 10.3f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 12.8f, 5.0f, 12.8f, 8.5f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 11.4f, 4.4f, 11.5f, 7.1f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 10.1f, 3.8f, 10.3f, 5.9f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 9.0f, 3.3f, 9.3f, 4.9f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 8.0f, 2.8f, 8.4f, 4.1f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 7.1f, 2.4f, 7.6f, 3.5f));
            slab.LoadCapacity.Add(new LoadCapacity(840, 6.4f, 2.0f, 6.8f, 2.9f));
            slab.LoadCapacity.Add(new LoadCapacity(870, 5.6f, 1.7f, 6.2f, 2.4f));

            _slabs.Add(slab);
        }

        private void Slab_20_4x125_REI120()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 4ø12.5+2ø6.85,kanały 60x140,REI120",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI120,
            mcr: 43.8f,
            mcr_topedge: -19.1f,
            mcrw02: 61.0f,
            mdec: 31.0f,
            mrd: 63.7f,
            mrd_topedge: -26.7f,
            vrd: 75.9f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 99.7f, 68.3f, 137.7f, 179.3f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 88.2f, 53.3f, 108.2f, 130.1f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 79.0f, 42.7f, 87.1f, 97.7f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 71.5f, 34.8f, 71.5f, 75.4f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 61.5f, 28.7f, 59.6f, 59.4f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 51.8f, 24.1f, 50.4f, 47.7f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 44.1f, 20.4f, 43.1f, 38.9f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 37.9f, 17.4f, 37.1f, 32.1f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 32.8f, 14.9f, 32.3f, 26.8f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 28.6f, 12.9f, 28.3f, 22.5f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 25.1f, 11.2f, 24.9f, 19.1f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 22.1f, 9.7f, 22.1f, 16.3f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 19.6f, 8.5f, 19.7f, 14.0f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 17.4f, 7.5f, 17.6f, 11.7f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 15.5f, 6.5f, 15.8f, 9.8f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 13.8f, 5.7f, 14.2f, 8.3f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 12.4f, 5.0f, 12.8f, 7.0f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 11.1f, 4.4f, 11.6f, 5.9f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 9.9f, 3.9f, 10.5f, 5.1f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 8.9f, 3.4f, 9.5f, 4.4f));
            slab.LoadCapacity.Add(new LoadCapacity(840, 8.0f, 2.9f, 8.6f, 3.7f));
            slab.LoadCapacity.Add(new LoadCapacity(870, 7.2f, 2.6f, 7.9f, 3.2f));
            slab.LoadCapacity.Add(new LoadCapacity(900, 6.5f, 2.2f, 7.2f, 2.7f));
            slab.LoadCapacity.Add(new LoadCapacity(930, 5.8f, 1.9f, 6.5f, 2.3f));

            _slabs.Add(slab);
        }

        private void Slab_20_2x125_4x93_REI120()
        {
            var slab = new SlabSmart(
            signature: "SMART 20/60 2ø12.5+4ø9.3+2ø6.85,kanały 60x140,REI120",
            thickness: 20,
            concrete: Concrete.C40_50,
            fireResistance: FireResistance.REI120,
            mcr: 45.6f,
            mcr_topedge: -19.1f,
            mcrw02: 64.5f,
            mdec: 32.7f,
            mrd: 66.7f,
            mrd_topedge: -27.2f,
            vrd: 76.3f,
            q: 2.9f
            )
            { };

            slab.LoadCapacity.Add(new LoadCapacity(240, 101.3f, 72.3f, 145.8f, 182.9f));
            slab.LoadCapacity.Add(new LoadCapacity(270, 89.7f, 56.5f, 114.6f, 132.9f));
            slab.LoadCapacity.Add(new LoadCapacity(300, 80.3f, 45.2f, 92.3f, 99.9f));
            slab.LoadCapacity.Add(new LoadCapacity(330, 72.7f, 36.9f, 75.8f, 77.2f));
            slab.LoadCapacity.Add(new LoadCapacity(360, 64.6f, 30.6f, 63.2f, 61.0f));
            slab.LoadCapacity.Add(new LoadCapacity(390, 54.5f, 25.6f, 53.5f, 49.1f));
            slab.LoadCapacity.Add(new LoadCapacity(420, 46.4f, 21.7f, 45.7f, 40.1f));
            slab.LoadCapacity.Add(new LoadCapacity(450, 39.9f, 18.5f, 39.5f, 33.1f));
            slab.LoadCapacity.Add(new LoadCapacity(480, 34.6f, 15.9f, 34.3f, 27.7f));
            slab.LoadCapacity.Add(new LoadCapacity(510, 30.2f, 13.8f, 30.1f, 23.3f));
            slab.LoadCapacity.Add(new LoadCapacity(540, 26.5f, 12.0f, 26.5f, 19.8f));
            slab.LoadCapacity.Add(new LoadCapacity(570, 23.4f, 10.5f, 23.5f, 16.9f));
            slab.LoadCapacity.Add(new LoadCapacity(600, 20.7f, 9.2f, 21.0f, 14.5f));
            slab.LoadCapacity.Add(new LoadCapacity(630, 18.4f, 8.1f, 18.7f, 12.2f));
            slab.LoadCapacity.Add(new LoadCapacity(660, 16.4f, 7.1f, 16.8f, 10.3f));
            slab.LoadCapacity.Add(new LoadCapacity(690, 14.7f, 6.2f, 15.2f, 8.7f));
            slab.LoadCapacity.Add(new LoadCapacity(720, 13.1f, 5.5f, 13.7f, 7.4f));
            slab.LoadCapacity.Add(new LoadCapacity(750, 11.8f, 4.8f, 12.4f, 6.3f));
            slab.LoadCapacity.Add(new LoadCapacity(780, 10.6f, 4.3f, 11.2f, 5.4f));
            slab.LoadCapacity.Add(new LoadCapacity(810, 9.5f, 3.7f, 10.2f, 4.7f));
            slab.LoadCapacity.Add(new LoadCapacity(840, 8.6f, 3.3f, 9.3f, 4.0f));
            slab.LoadCapacity.Add(new LoadCapacity(870, 7.7f, 2.9f, 8.5f, 3.5f));
            slab.LoadCapacity.Add(new LoadCapacity(900, 7.0f, 2.5f, 7.7f, 3.0f));
            slab.LoadCapacity.Add(new LoadCapacity(930, 6.3f, 2.2f, 7.1f, 2.5f));

            _slabs.Add(slab);
        }

        private void SlabInitialize()
        {
            Slab_15_2x93_REI60();
            Slab_15_4x93_REI60();
            Slab_15_2x125_2x93_REI60();
            Slab_15_6x93_REI60();
            Slab_15_4x125_REI60();
            Slab_15_2x125_4x93_REI60();
            Slab_20_2x93_REI60();
            Slab_20_4x93_REI60();
            Slab_20_2x125_2x93_REI60();
            Slab_20_6x93_REI60();
            Slab_20_4x125_REI60();
            Slab_20_2x125_4x93_REI60();
            Slab_20_2x93_REI120();
            Slab_20_4x93_REI120();
            Slab_20_2x125_2x93_REI120();
            Slab_20_6x9_REI120();
            Slab_20_4x125_REI120();
            Slab_20_2x125_4x93_REI120();
        }

    }
}
