using Lab07.Calculations;

namespace Lab07.IO.Data
{
    public class DecompositionLoader
    {
        public Tasks GetDefault()
        {
            var decomposition = new Tasks();
            decomposition.AddRange(
                new Task
                {
                    Name = "Анализ требований",
                    IsOverhead = false,
                    LaborPercent = null,
                    TimePercent = null,
                    BudgetPercent = 4
                },
                new Task
                {
                    Name = "Проектирование продукта",
                    IsOverhead = false,
                    LaborPercent = null,
                    TimePercent = null,
                    BudgetPercent = 12
                },
                new Task
                {
                    Name = "Программирование",
                    IsOverhead = false,
                    LaborPercent = null,
                    TimePercent = null,
                    BudgetPercent = 44
                },
                new Task
                {
                    Name = "Планирование тестирования",
                    IsOverhead = false,
                    LaborPercent = null,
                    TimePercent = null,
                    BudgetPercent = 6
                },
                new Task
                {
                    Name = "Верификация и аттестация",
                    IsOverhead = false,
                    LaborPercent = null,
                    TimePercent = null,
                    BudgetPercent = 14
                }, new Task
                {
                    Name = "Канцелярия проекта",
                    IsOverhead = false,
                    LaborPercent = null,
                    TimePercent = null,
                    BudgetPercent = 7
                },
                new Task
                {
                    Name = "Управление конфигурацией и обеспечение качества",
                    IsOverhead = false,
                    LaborPercent = null,
                    TimePercent = null,
                    BudgetPercent = 7
                },
                new Task
                {
                    Name = "Создание руководств",
                    IsOverhead = false,
                    LaborPercent = null,
                    TimePercent = null,
                    BudgetPercent = 6
                }
            );
            return decomposition;
        }
    }
}
