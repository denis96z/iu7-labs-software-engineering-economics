using System;
using System.Collections.Generic;
using Lab06.IO;

namespace Lab06.Calculations
{
    public enum CalculatorMode
    {
        Common, Medium, Embedded
    }

    internal class Calculator
    {
        public double RELY { get; set; }
        public double DATA { get; set; }
        public double CPLX { get; set; }
        public double TIME { get; set; }
        public double STOR { get; set; }
        public double VIRT { get; set; }
        public double TURN { get; set; }
        public double ACAP { get; set; }
        public double AEXP { get; set; }
        public double PCAP { get; set; }
        public double VEXP { get; set; }
        public double LEXP { get; set; }
        public double MODP { get; set; }
        public double TOOL { get; set; }
        public double SCED { get; set; }

        public int LOC { get; set; }
        public int Budget { get; set; }

        public CalculatorMode Mode { get; set; }

        public (double, double) CalculateLaborAndTime()
        {
            double c1 = 0, c2 = 0;
            double p1 = 0, p2 = 0;

            switch (Mode)
            {
                case CalculatorMode.Common:
                    c1 = 3.2;
                    c2 = 2.5;
                    p1 = 1.05;
                    p2 = 0.38;
                    break;

                case CalculatorMode.Medium:
                    c1 = 3.0;
                    c2 = 2.5;
                    p1 = 1.12;
                    p2 = 0.35;
                    break;

                case CalculatorMode.Embedded:
                    c1 = 2.8;
                    c2 = 2.5;
                    p1 = 1.20;
                    p2 = 0.32;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            var labor = c1 * EAF * Math.Pow(KLOC, p1);
            var time = c2 * Math.Pow(labor, p2);

            ltCache = (labor, time);
            return (labor, time);
        }

        private double EAF => RELY * DATA * CPLX * TIME * STOR *
                              VIRT * TURN * ACAP * AEXP * PCAP *
                              VEXP * LEXP * MODP * TOOL * SCED;

        private double KLOC => LOC / 1000.0;

        public List<Task> Lifecycle { get; set; } = new List<Task>();
        public List<Task> Decomposition { get; set; } = new List<Task>();

        public List<(double, double)> CalculateLifecycle(bool useCache = true)
        {
            (var totalLabor, var totalTime) = ltCache;
            if (!useCache)
            {
                (totalLabor, totalTime) = CalculateLaborAndTime();
            }

            var result = new List<(double, double)>();
            foreach (var task in Lifecycle)
            {
                var labor = totalLabor * (task.LaborPercent / 100.0);
                var time = totalTime * (task.TimePercent / 100.0);
                result.Add((labor, time));
            }

            lcCache = result;
            return result;
        }

        public List<double> CalculateDecomposition(bool useCache = true)
        {
            var result = new List<double>();
            foreach (var task in Decomposition)
            {
                var budget = Budget * (task.BudgetPercent / 100.0);
                result.Add(budget);
            }

            return result;
        }

        public List<int> CountStaff(bool useCache = true)
        {
            var lifecycleCount = lcCache;
            if (lcCache == null || !useCache)
            {
                lifecycleCount = CalculateLifecycle(false);
            }

            var result = new List<int>();
            const double minTime = 1e-5;
            foreach (var task in lifecycleCount)
            {
                var staff = (int) (task.Item2 > minTime ? task.Item1 / task.Item2 : 0);
                result.Add(staff);
            }

            return result;
        }

        private (double, double) ltCache = (0, 0);
        private List<(double, double)> lcCache = null;
    }
}
