using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab07.Calculations;

namespace Lab07.IO.Config
{
    public class ProductParametersLoader
    {
        public ProductParameters GetDefault()
        {
            var parameters = new ProductParameters();
            parameters.AddRange(
                new ProductParameter()
                {
                    Name = "Обмен данными",
                    Value = 5
                },
                new ProductParameter()
                {
                    Name = "Распределенная обработка",
                    Value = 5
                },
                new ProductParameter()
                {
                    Name = "Производительность",
                    Value = 3
                },
                new ProductParameter()
                {
                    Name = "Эксплуатационные ограничения",
                    Value = 0
                },
                new ProductParameter()
                {
                    Name = "Транзакционная нагрузка",
                    Value = 3
                },
                new ProductParameter()
                {
                    Name = "Интенсивность взаимодействия с пользователем",
                    Value = 2
                },
                new ProductParameter()
                {
                    Name = "Эргономические характеристики",
                    Value = 0
                },
                new ProductParameter()
                {
                    Name = "Оперативное обновление",
                    Value = 4
                },
                new ProductParameter()
                {
                    Name = "Сложность обработки",
                    Value = 4
                },
                new ProductParameter()
                {
                    Name = "Повторное использование",
                    Value = 3
                },
                new ProductParameter()
                {
                    Name = "Легкость инсталляции",
                    Value = 0
                },
                new ProductParameter()
                {
                    Name = "Легкость эксплуатации/администрирования",
                    Value = 3
                },
                new ProductParameter()
                {
                    Name = "Портируемость",
                    Value = 5
                },
                new ProductParameter()
                {
                    Name = "Гибкость",
                    Value = 0
                }
            );
            return parameters;
        }
    }
}
