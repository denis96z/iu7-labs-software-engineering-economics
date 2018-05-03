using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab07.Calculations
{
    public class Task
    {
        public string Name { get; set; }
        public bool IsOverhead { get; set; }
        public byte? LaborPercent { get; set; }
        public byte? TimePercent { get; set; }
        public byte? BudgetPercent { get; set; }
    }

    public class Tasks : IEnumerable<Task>
    {
        private readonly List<Task> _tasks = new List<Task>();

        public void Add(Task task)
        {
            _tasks.Add(task);
        }

        public void AddRange(params Task[] tasks)
        {
            _tasks.AddRange(tasks);
        }

        public void Remove(string name)
        {
            foreach (var task in _tasks)
            {
                if (task.Name != name) continue;
                _tasks.Remove(task);
                break;
            }
        }

        public IEnumerator<Task> GetEnumerator()
        {
            return _tasks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Task this[int index] => _tasks[index];

        public Task this[string name]
        {
            get
            {
                foreach (var task in _tasks)
                {
                    if (task.Name == name)
                    {
                        return task;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }

            set
            {
                for (var i = 0; i < _tasks.Count; ++i)
                {
                    // ReSharper disable once InvertIf
                    if (_tasks[i].Name == name)
                    {
                        _tasks[i] = value;
                        return;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
