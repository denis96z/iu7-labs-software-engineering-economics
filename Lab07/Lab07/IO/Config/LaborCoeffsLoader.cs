using Lab07.Calculations;

namespace Lab07.IO.Config
{
    public class LaborCoeffsLoader
    {
        public LaborCoeffs GetDefault()
        {
            var coeffs = new LaborCoeffs();
            coeffs.AddRange(
                new LaborCoeff("PERS")
                {
                    VeryLowValue = 1.62,
                    LowValue = 1.26,
                    NormalValue = 1.00,
                    HighValue = 0.83,
                    VeryHighValue = 0.63,
                    SuperHighValue = 0.5
                },
                new LaborCoeff("RCPX")
                {
                    VeryLowValue = 0.60,
                    LowValue = 0.83,
                    NormalValue = 1.00,
                    HighValue = 1.33,
                    VeryHighValue = 1.91,
                    SuperHighValue = 2.72
                },
                new LaborCoeff("RUSE")
                {
                    VeryLowValue = null,
                    LowValue = 0.95,
                    NormalValue = 1.00,
                    HighValue = 1.07,
                    VeryHighValue = 1.15,
                    SuperHighValue = 1.24
                },
                new LaborCoeff("PDIF")
                {
                    VeryLowValue = null,
                    LowValue = 0.87,
                    NormalValue = 1.00,
                    HighValue = 1.29,
                    VeryHighValue = 1.81,
                    SuperHighValue = 2.61
                },
                new LaborCoeff("PREX")
                {
                    VeryLowValue = 1.33,
                    LowValue = 1.22,
                    NormalValue = 1.00,
                    HighValue = 0.87,
                    VeryHighValue = 0.74,
                    SuperHighValue = 0.62
                },
                new LaborCoeff("FCIL")
                {
                    VeryLowValue = 1.30,
                    LowValue = 1.10,
                    NormalValue = 1.00,
                    HighValue = 0.87,
                    VeryHighValue = 0.73,
                    SuperHighValue = 0.62
                },
                new LaborCoeff("SCED")
                {
                    VeryLowValue = 1.43,
                    LowValue = 1.14,
                    NormalValue = 1.00,
                    HighValue = 1.00,
                    VeryHighValue = 1.00,
                    SuperHighValue = null
                });
            return coeffs;
        }
    }
}
