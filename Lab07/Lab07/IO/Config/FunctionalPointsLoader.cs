using Lab07.Calculations;

namespace Lab07.IO.Config
{
    public class FunctionalPointsLoader
    {
        public FunctionalPoints GetDefault()
        {
            var points = new FunctionalPoints();
            points.AddRange(
                new FunctionalPoint
                {
                    Name = "ILF",
                    PossibleValues = new[,]
                    {
                        {  7,  7, 10 },
                        {  7, 10, 15 },
                        { 10, 15, 15 }
                    },
                    Level = new [] { 0, 0 }
                },
                new FunctionalPoint
                {
                    Name = "EIF",
                    PossibleValues = new[,]
                    {
                        { 5,  5,  7 },
                        { 5,  7, 10 },
                        { 7, 10, 10 }
                    },
                    Level = new[] { 0, 0 }
                },
                new FunctionalPoint
                {
                    Name = "EI",
                    PossibleValues = new[,]
                    {
                        { 3, 3, 4 },
                        { 3, 4, 6 },
                        { 4, 6, 6 }
                    },
                    Level = new[] { 0, 0 }
                },
                new FunctionalPoint
                {
                    Name = "EO",
                    PossibleValues = new[,]
                    {
                        { 4, 4, 5 },
                        { 4, 5, 7 },
                        { 5, 7, 7 }
                    },
                    Level = new[] { 0, 0 }
                }, new FunctionalPoint
                {
                    Name = "EQ",
                    PossibleValues = new[,]
                    {
                        { 3, 3, 4 },
                        { 3, 4, 6 },
                        { 4, 6, 6 }
                    },
                    Level = new[] { 0, 0 }
                }
            );
            return points;
        }
    }
}
