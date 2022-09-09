using Combinatorics.Collections;
using SlabSolver.Enums;
using System;
using System.Collections.Generic;

namespace SlabSolver.Domain
{
    public class Loads
    {
        private Permutations<Load> loadPermutations;

        const float gamma_g = 1.35f;
        const float gamma_q = 1.5f;
        public List<Load> LoadsList { get; }

        private List<Load> ActionLoads
        {
            get
            {
                return LoadsList.FindAll(x => x.Type != LoadType.Dead && x.Type != LoadType.Accident);
            }
        }

        public Loads()
        {
            LoadsList = new List<Load>();
            loadPermutations = new Permutations<Load>(ActionLoads, GenerateOption.WithRepetition);
        }

        public void AddLoad(Load loadItem)
        {
            var item = LoadsList.Find(x => x.Type == loadItem.Type);
            if (item == null)
            {
                LoadsList.Add(loadItem);
            }
            else
            {
                item.Value += loadItem.Value;
            }
            loadPermutations = new Permutations<Load>(ActionLoads, GenerateOption.WithRepetition);
        }

        public void DelLoad(Guid id)
        {
            LoadsList.RemoveAll(x => x.Guid == id);
            loadPermutations = new Permutations<Load>(ActionLoads, GenerateOption.WithRepetition);
        }

        public float ULS_EQU
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    for (var i = 0; i < permutation.Count; i++)
                    {
                        if (i == 0)
                        {
                            max += permutation[i].Value;
                        }
                        else
                        {
                            max += permutation[i].Psi0 * permutation[i].Value;
                        }
                    }
                    variable = Math.Max(variable, max);
                }

                return 1.1f * permanent + gamma_q * variable;
            }
        }

        public float ULS_STR
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    for (var i = 0; i < permutation.Count; i++)
                    {
                        if (i == 0)
                        {
                            max += permutation[i].Value;
                        }
                        else
                        {
                            max += permutation[i].Psi0 * permutation[i].Value;
                        }
                    }
                    variable = Math.Max(variable, max);
                }

                return gamma_g * permanent + gamma_q * variable;
            }
        }

        public float ULS_STR_A
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    foreach (var load in permutation)
                    {
                        max += load.Psi0 * load.Value;
                    }
                    variable = Math.Max(variable, max);
                }

                return gamma_g * permanent + gamma_q * variable;
            }
        }

        public float ULS_STR_B
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    for (var i = 0; i < permutation.Count; i++)
                    {
                        if (i == 0)
                        {
                            max += permutation[i].Value;
                        }
                        else
                        {
                            max += permutation[i].Psi0 * permutation[i].Value;
                        }
                    }
                    variable = Math.Max(variable, max);
                }

                return 0.85f * gamma_g * permanent + gamma_q * variable;
            }
        }

        public float ULS_GEO
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    for (var i = 0; i < permutation.Count; i++)
                    {
                        if (i == 0)
                        {
                            max += permutation[i].Value;
                        }
                        else
                        {
                            max += permutation[i].Psi0 * permutation[i].Value;
                        }
                    }
                    variable = Math.Max(variable, max);
                }

                return permanent + 1.3f * variable;
            }
        }

        public float ULS_ACC_A
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var acc = 0f;
                LoadsList
                   .FindAll(x => x.Type == LoadType.Accident)
                   .ForEach(l => acc += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    for (var i = 0; i < permutation.Count; i++)
                    {
                        if (i == 0)
                        {
                            max += permutation[i].Psi1 * permutation[i].Value;
                        }
                        else
                        {
                            max += permutation[i].Psi2 * permutation[i].Value;
                        }
                    }
                    variable = Math.Max(variable, max);
                }

                return permanent + acc + variable;
            }
        }

        public float ULS_ACC_B
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var acc = 0f;
                LoadsList
                   .FindAll(x => x.Type == LoadType.Accident)
                   .ForEach(l => acc += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    foreach (var load in permutation)
                    {
                        max += load.Psi2 * load.Value;
                    }
                    variable = Math.Max(variable, max);
                }

                return permanent + acc + variable;
            }
        }

        public float SLS_CHAR
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    for (var i = 0; i < permutation.Count; i++)
                    {
                        if (i == 0)
                        {
                            max += permutation[i].Value;
                        }
                        else
                        {
                            max += permutation[i].Psi0 * permutation[i].Value;
                        }
                    }
                    variable = Math.Max(variable, max);
                }

                return permanent + variable;
            }
        }

        public float SLS_FREQ
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    for (var i = 0; i < permutation.Count; i++)
                    {
                        if (i == 0)
                        {
                            max += permutation[i].Psi1 * permutation[i].Value;
                        }
                        else
                        {
                            max += permutation[i].Psi2 * permutation[i].Value;
                        }
                    }
                    variable = Math.Max(variable, max);
                }

                return permanent + variable;
            }
        }

        public float SLS_QPER
        {
            get
            {
                var permanent = 0f;
                LoadsList
                    .FindAll(x => x.Type == LoadType.Dead)
                    .ForEach(l => permanent += l.Value);
                var variable = 0f;
                foreach (var permutation in loadPermutations)
                {
                    var max = 0f;
                    foreach (var load in permutation)
                    {
                        max += load.Psi2 * load.Value;
                    }
                    variable = Math.Max(variable, max);
                }

                return permanent + variable;
            }
        }
    }
}
