﻿using Lab07.Calculations;

namespace Lab07.IO.Config
{
    public class FactorsLoader
    {
        public Factors GetDefault()
        {
            var factors = new Factors();
            factors.AddRange(
                new Factor
                {
                    Name = "PREC",
                    Levels = new[]
                    {
                        ("Полное отсутствие прецедентов, полностью непредсказуемый проект", 6.2),
                        ("Почти полное отсутствие прецедентов, в значительной мере непредсказуемый проект", 4.96),
                        ("Наличие некоторого количества прецедентов", 3.72),
                        ("Общее знакомство с проектом", 2.48),
                        ("Значительное знакомство с проектом", 1.24),
                        ("Полное знакомство с проектом", 0)
                    },
                    Level = 0
                },
                new Factor
                {
                    Name = "FLEX",
                    Levels = new[]
                    {
                        ("Точный, строгий процесс разработки", 5.07),
                        ("Случайные послабления в процессе", 4.05),
                        ("Некоторые послабления в процессе", 3.04),
                        ("Большей частью согласованный процесс", 2.03),
                        ("Некоторое согласование процесса", 1.01),
                        ("Заказчик определил только общие цели", 0)
                    },
                    Level = 0
                },
                new Factor
                {
                    Name = "RESL",
                    Levels = new[]
                    {
                        ("Малое (20 %)", 7),
                        ("Некоторое (40 %)", 5.65),
                        ("Частое (60 %)", 4.24),
                        ("В целом (75 %)", 2.83),
                        ("Почти полное (90 %)", 1.41),
                        ("Полное (100%) ", 0)
                    },
                    Level = 0
                },
                new Factor
                {
                    Name = "TEAM",
                    Levels = new[]
                    {
                        ("Сильно затрудненное взаимодействие", 5.48),
                        ("Несколько затрудненное взаимодействие", 4.38),
                        ("Некоторая согласованность", 3.29),
                        ("Повышенная согласованность", 2.19),
                        ("Высокая согласованность", 1.1),
                        ("Взаимодействие как в едином целом", 0)
                    },
                    Level = 0
                },
                new Factor
                {
                    Name = "PMAT",
                    Levels = new[]
                    {
                        ("Уровень 1 СММ", 7),
                        ("Уровень 1+ СММ", 6.24),
                        ("Уровень 2 СММ", 4.68),
                        ("Уровень 3 СММ", 1.12),
                        ("Уровень 7 СММ", 1.56),
                        ("Уровень 5 СММ", 0)
                    },
                    Level = 0
                }
            );
            return factors;
        }
    }
}
