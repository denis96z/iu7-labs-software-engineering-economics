using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab07.Calculations
{
    public class Model
    {
        public int Ksloc { get; set; }
        public ProgLanguages Languages { get; set; }

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

            labor *= Math.Pow(CalculateKsloc(), CalculatePow());
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

        public List<int> CalculateStaff()
        {
            var staff = new List<int>();

            var lifecycleLabor = CalculateLifecycleLabor();
            var lifecycleTime = CalculateLifecycleTime();

            for (var i = 0; i < Lifecycle.Count(); ++i)
            {
                const double minTime = 1e-5;
                // ReSharper disable once PossibleInvalidOperationException
                var st = (int)(lifecycleTime[i] > minTime
                    ? lifecycleLabor[i] / lifecycleTime[i] : 0);
                staff.Add(st);
            }

            return staff;
        }

        private int CalculateKsloc()
        {
            var ksloc = 0;
            foreach (var language in Languages)
            {
                ksloc += (int) ((double)Ksloc / language.SlocMultiplier * (language.SlocPercent / 100.0));
            }

            return ksloc;
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
