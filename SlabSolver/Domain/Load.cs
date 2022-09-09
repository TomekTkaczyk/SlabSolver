using SlabSolver.Enums;
using System;

namespace SlabSolver.Domain
{
    public class Load
    {
        public readonly Guid Guid;
        public readonly LoadType Type;

        public float Value { get; set; }

        public float Psi0 { get; private set; }
        public float Psi1 { get; private set; }
        public float Psi2 { get; private set; }

        public Load(LoadType type, float value = 0)
        {
            Guid = Guid.NewGuid();
            Type = type;
            Value = value;
            SetPsi();
        }

        public static string GetLoadName(LoadType type)
        {
            switch (type)
            {
                case LoadType.Dead:
                    {
                        return "Obciążenie stałe";
                    }
                case LoadType.Action_Category_A:
                    {
                        return "Obciążenie zmienne kategoria A";
                    }
                case LoadType.Action_Category_B:
                    {
                        return "Obciążenie zmienne kategoria B";
                    }
                case LoadType.Action_Category_C:
                    {
                        return "Obciążenie zmienne kategoria C";
                    }
                case LoadType.Action_Category_D:
                    {
                        return "Obciążenie zmienne kategoria D";
                    }
                case LoadType.Action_Category_E:
                    {
                        return "Obciążenie zmienne kategoria E";
                    }
                case LoadType.Action_Category_F:
                    {
                        return "Obciążenie zmienne kategoria F";
                    }
                case LoadType.Action_Category_G:
                    {
                        return "Obciążenie zmienne kategoria G";
                    }
                case LoadType.Action_Category_H:
                    {
                        return "Obciążenie zmienne kategoria H";
                    }
                case LoadType.Snow_Nord_Country:
                    {
                        return "Obciążenie śniegiem kraje nordyckie";
                    }
                case LoadType.Snow_CEN_below_1000m:
                    {
                        return "Obciążenie śniegiem kraje CEN do 1000mnpm";
                    }
                case LoadType.Snow_CEN_above_1000m:
                    {
                        return "Obciążenie śniegiem kraje CEN powyżej 1000mnpm";
                    }
                case LoadType.Wind:
                    {
                        return "Obciążenie wiatrem";
                    }
                case LoadType.Accident:
                    {
                        return "Obciążenie wyjątkowe";
                    }
                case LoadType.Temperature:
                    {
                        return "Obciążenie temperaturą";
                    }
                default:
                    {
                        return "Kategoria niezindentyfikowana";
                    }
            }
        }

        private void SetPsi()
        {
            switch (Type)
            {
                case LoadType.Action_Category_A:
                case LoadType.Action_Category_B:
                case LoadType.Action_Category_G:
                    {
                        Psi0 = 0.7f;
                        Psi1 = 0.5f;
                        Psi2 = 0.3f;
                        break;
                    }
                case LoadType.Action_Category_C:
                case LoadType.Action_Category_D:
                case LoadType.Action_Category_F:
                    {
                        Psi0 = 0.7f;
                        Psi1 = 0.7f;
                        Psi2 = 0.6f;
                        break;
                    }
                case LoadType.Action_Category_E:
                    {
                        Psi0 = 1.0f;
                        Psi1 = 0.9f;
                        Psi2 = 0.8f;
                        break;
                    }
                case LoadType.Action_Category_H:
                case LoadType.Accident:
                    {
                        Psi0 = 0.0f;
                        Psi1 = 0.0f;
                        Psi2 = 0.0f;
                        break;
                    }
                case LoadType.Snow_Nord_Country:
                case LoadType.Snow_CEN_above_1000m:
                    {
                        Psi0 = 0.7f;
                        Psi1 = 0.5f;
                        Psi2 = 0.2f;
                        break;
                    }
                case LoadType.Snow_CEN_below_1000m:
                    {
                        Psi0 = 0.5f;
                        Psi1 = 0.2f;
                        Psi2 = 0.2f;
                        break;
                    }
                case LoadType.Wind:
                    {
                        Psi0 = 0.6f;
                        Psi1 = 0.2f;
                        Psi2 = 0.0f;
                        break;
                    }
                case LoadType.Temperature:
                    {
                        Psi0 = 0.6f;
                        Psi1 = 0.5f;
                        Psi2 = 0.0f;
                        break;
                    }
                default:
                    {
                        Psi0 = 1.0f;
                        Psi1 = 1.0f;
                        Psi2 = 1.0f;
                        break;
                    }
            }
        }
    }
}
