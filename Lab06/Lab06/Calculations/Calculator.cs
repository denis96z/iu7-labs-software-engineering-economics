using System;

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

            return (labor, time);
        }

        private double EAF => RELY * DATA * CPLX * TIME * STOR *
                              VIRT * TURN * ACAP * AEXP * PCAP *
                              VEXP * LEXP * MODP * TOOL * SCED;

        private double KLOC => LOC / 1000.0;
    }
}
