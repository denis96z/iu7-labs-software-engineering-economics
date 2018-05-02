using System;

namespace Lab07.Calculations
{
    public class Model
    {
        public int Ksloc { get; set; }
        public LaborCoeffs LaborCoeffs { get; set; }
        public ProductParameters ProductParameters { get; set; }
        public Factors Factors { get; set; }

        public double CalculateTotalLabor()
        {
            var labor = 2.45;
            foreach (var coeff in LaborCoeffs)
            {
                labor *= coeff.Value ?? throw new NullReferenceException();
            }

            labor *= Math.Pow(Ksloc, CalculatePow());
            return labor;
        }

        public double CalculateTotalTime()
        {
            return Math.Pow(CalculateTotalLabor(), 0.33 + 0.2 * (CalculatePow() - 1.01));
        }

        private double CalculatePow()
        {
            var p = 0.0;
            foreach (var factor in Factors)
            {
                p += factor.Levels[factor.Level].Item2;
            }
            return p / 100 + 1.01;
        }
    }
}
