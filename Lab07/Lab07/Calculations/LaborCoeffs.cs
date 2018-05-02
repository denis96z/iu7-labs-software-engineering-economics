using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab07.Calculations
{
    public enum LaborCoeffLevel
    {
        VeryLow, Low, Normal, High, VeryHigh, SuperHigh
    }

    public static class LaborCoeffLevelConverter
    {
        public static LaborCoeffLevel Convert(string level)
        {
            switch (level)
            {
                case "Очень низкий":
                    return LaborCoeffLevel.VeryLow;
                case "Низкий":
                    return LaborCoeffLevel.Low;
                case "Нормальный":
                    return LaborCoeffLevel.Normal;
                case "Высокий":
                    return LaborCoeffLevel.High;
                case "Очень высокий":
                    return LaborCoeffLevel.VeryHigh;
                case "Сверхвысокий":
                    return LaborCoeffLevel.SuperHigh;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string Convert(LaborCoeffLevel level)
        {
            switch (level)
            {
                case LaborCoeffLevel.VeryLow:
                    return "Очень низкий";

                case LaborCoeffLevel.Low:
                    return "Низкий";

                case LaborCoeffLevel.Normal:
                    return "Нормальный";

                case LaborCoeffLevel.High:
                    return "Высокий";

                case LaborCoeffLevel.VeryHigh:
                    return "Очень высокий";

                case LaborCoeffLevel.SuperHigh:
                    return "Сверхвысокий";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public struct LaborCoeff
    {
        public string Name { get; }

        public double? VeryLowValue { get; set; }
        public double? LowValue { get; set; }
        public double? NormalValue { get; set; }
        public double? HighValue { get; set; }
        public double? VeryHighValue { get; set; }
        public double? SuperHighValue { get; set; }

        public bool Reversed { get; set; }

        public LaborCoeff(string name)
        {
            Name = name;
            Level = LaborCoeffLevel.Normal;
            VeryLowValue = LowValue = NormalValue =
                HighValue = VeryHighValue = SuperHighValue = 1;
            Reversed = false;
        }

        public LaborCoeffLevel Level { get; set; }

        public double? Value
        {
            get
            {
                switch (Level)
                {
                    case LaborCoeffLevel.VeryLow:
                        return VeryLowValue;

                    case LaborCoeffLevel.Low:
                        return LowValue;

                    case LaborCoeffLevel.Normal:
                        return NormalValue;

                    case LaborCoeffLevel.High:
                        return HighValue;

                    case LaborCoeffLevel.VeryHigh:
                        return VeryHighValue;

                    case LaborCoeffLevel.SuperHigh:
                        return SuperHighValue;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }

    public class LaborCoeffs : IEnumerable<LaborCoeff>
    {
        private readonly List<LaborCoeff> _coeffs = new List<LaborCoeff>();

        public void Add(LaborCoeff coeff)
        {
            _coeffs.Add(coeff);
        }

        public void AddRange(params LaborCoeff[] coeffs)
        {
            _coeffs.AddRange(coeffs);
        }

        public void Remove(string name)
        {
            foreach (var coeff in _coeffs)
            {
                if (coeff.Name != name) continue;
                _coeffs.Remove(coeff);
                break;
            }
        }

        IEnumerator<LaborCoeff> IEnumerable<LaborCoeff>.GetEnumerator()
        {
            return _coeffs.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return _coeffs.GetEnumerator();
        }

        public LaborCoeff this[string name]
        {
            get
            {
                foreach (var coeff in _coeffs)
                {
                    if (coeff.Name == name)
                    {
                        return coeff;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }

            set
            {
                for (var i = 0; i < _coeffs.Count; ++i)
                {
                    // ReSharper disable once InvertIf
                    if (_coeffs[i].Name == name)
                    {
                        _coeffs[i] = value;
                        return;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
