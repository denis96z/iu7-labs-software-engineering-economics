using System;
using System.Collections.Generic;

namespace Lab07.Calculations
{
    public class Model
    {
        public int Ksloc { get; set; }

        public int ManMonthCost { get; set; } = 80000;

        public LaborCoeffs LaborCoeffs { get; set; }
        public ProductParameters ProductParameters { get; set; }
        public Factors Factors { get; set; }

        public Tasks Lifecycle { get; set; }
        public Tasks Decomposition { get; set; }

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

        public double CalculateTotalBudget()
        {
            return CalculateTotalLabor() * ManMonthCost;
        }

        public List<double?> CalculateLifecycleLabor()
        {
            var lifecycleLabor = new List<double?>();

            var totalLabor = CalculateTotalLabor();
            foreach (var task in Lifecycle)
            {
                lifecycleLabor.Add(totalLabor * (task.LaborPercent / 100.0));
            }

            return lifecycleLabor;
        }

        public List<double?> CalculateLifecycleTime()
        {
            var lifecycleTime = new List<double?>();

            var totalTime = CalculateTotalTime();
            foreach (var task in Lifecycle)
            {
                lifecycleTime.Add(totalTime * (task.TimePercent / 100.0));
            }

            return lifecycleTime;
        }

        public List<double?> CalculateDecompositionBudget()
        {
            var decompositionBudget = new List<double?>();

            var totalBudget = CalculateTotalBudget();
            foreach (var task in Decomposition)
            {
                decompositionBudget.Add(totalBudget * (task.BudgetPercent / 100.0));
            }

            return decompositionBudget;
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
