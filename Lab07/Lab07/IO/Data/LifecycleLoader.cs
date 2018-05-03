using Lab07.Calculations;

namespace Lab07.IO.Data
{
    public class LifecycleLoader
    {
        public Tasks GetDefault()
        {
            var tasks = new Tasks();
            tasks.AddRange(
                new Task
                {
                    Name = "Планирование и определение требований",
                    IsOverhead = true,
                    LaborPercent = 8,
                    TimePercent = 36,
                    BudgetPercent = null
                },
                new Task
                {
                    Name = "Проектирование продукта",
                    IsOverhead = false,
                    LaborPercent = 18,
                    TimePercent = 36,
                    BudgetPercent = null
                },
                new Task
                {
                    Name = "Детальное проектирование",
                    IsOverhead = false,
                    LaborPercent = 25,
                    TimePercent = 18,
                    BudgetPercent = null
                },
                new Task
                {
                    Name = "Кодирование и тестирование отдельных модулей",
                    IsOverhead = false,
                    LaborPercent = 31,
                    TimePercent = 28,
                    BudgetPercent = null
                },
                new Task
                {
                    Name = "Интеграция и тестирование",
                    IsOverhead = false,
                    LaborPercent = 8,
                    TimePercent = 36,
                    BudgetPercent = null
                }
            );
            return tasks;
        }
    }
}
