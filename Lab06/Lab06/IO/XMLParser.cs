using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Lab06.IO
{
    internal struct Driver
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public struct Task
    {
        public string Name { get; set; }
        public int LaborPercent { get; set; }
        public int TimePercent { get; set; }
        public int BudgetPercent { get; set; }
    }

    internal class XmlParser
    {
        private readonly XDocument xdoc;

        public XmlParser(string fileName)
        {
            xdoc = XDocument.Load(fileName);
        }

        public int LoadLOC()
        {
            if (xdoc.Root == null) throw new IOException();
            var loc = xdoc.Root.Element("loc") ?? throw new IOException();
            var value = loc.Attribute("value") ?? throw new IOException();
            return int.Parse(value.Value);
        }

        public int LoadManMonthCost()
        {
            if (xdoc.Root == null) throw new IOException();
            var loc = xdoc.Root.Element("manmonthcost") ?? throw new IOException();
            var value = loc.Attribute("value") ?? throw new IOException();
            return int.Parse(value.Value);
        }

        public List<Driver> LoadDrivers()
        {
            var root = xdoc.Root;
            var drivers = new List<Driver>();
            if (root != null)
            {
                // ReSharper disable once PossibleNullReferenceException
                drivers.AddRange(from driver in root.Element("drivers").Elements("driver")
                    let name = driver.Attribute("name") ?? throw new IOException()
                    let value = driver.Attribute("value") ?? throw new IOException()
                    select new Driver
                    {
                        Name = name.Value,
                        Value = int.Parse(value.Value)
                    });
            }
            return drivers;
        }

        public List<Task> LoadLifecycle()
        {
            return LoadTasks("lifecycle");
        }

        public List<Task> LoadDecomposition()
        {
            return LoadTasks("decomposition");
        }

        private List<Task> LoadTasks(string category)
        {
            var root = xdoc.Root;
            var tasks = new List<Task>();
            if (root != null)
            {
                // ReSharper disable once PossibleNullReferenceException
                tasks.AddRange(from task in root.Element(category).Elements("task")
                    let name = task.Element("name") ?? throw new IOException()
                    let labor = task.Element("laborpercent")
                    let time = task.Element("timepercent")
                    let budget = task.Element("budgetpercent")
                               where labor?.Attribute("overhead") == null &&
                                     time?.Attribute("overhead") == null &&
                                     budget?.Attribute("overhead") == null
                    select new Task
                    {
                        Name = name.Value,
                        LaborPercent = labor != null ? int.Parse(labor.Value) : 0,
                        TimePercent = time != null ? int.Parse(time.Value) : 0,
                        BudgetPercent = budget != null ? int.Parse(budget.Value) : 0
                    });
            }
            return tasks;
        }
    }
}
