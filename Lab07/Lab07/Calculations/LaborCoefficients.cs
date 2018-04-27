using System;

namespace Lab07.Calculations
{
    public enum LaborCoeffLevel
    {
        SuperLow, Low, Normal, High, SuperHigh
    }

    public static class LaborCoeffLevelDecoder
    {
        public static double GetPercent(LaborCoeffLevel level)
        {
            switch (level)
            {
                case LaborCoeffLevel.SuperLow:
                    return 0.00;

                case LaborCoeffLevel.Low:
                    return 0.25;

                case LaborCoeffLevel.Normal:
                    return 0.50;

                case LaborCoeffLevel.High:
                    return 0.75;

                case LaborCoeffLevel.SuperHigh:
                    return 1.00;

                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, null);
            }
        }
    }

    public struct LaborCoeff
    {
        public string Name { get; }
        public double MinValue { get; }
        public double MaxValue { get; }
        public bool Reversed { get; }

        public LaborCoeff(string name, double min, double max)
        {
            Name = name;
            MinValue = min;
            MaxValue = max;
            Level = LaborCoeffLevel.Normal;
            Reversed = min > max;
        }

        public LaborCoeffLevel Level { get; set; }

        public double Value
        {
            get
            {
                var p = LaborCoeffLevelDecoder.GetPercent(Level);
                return Reversed
                    ? MaxValue + (MinValue - MaxValue) * p
                    : MinValue + (MaxValue - MinValue) * p;
            }
        }
    }
}
