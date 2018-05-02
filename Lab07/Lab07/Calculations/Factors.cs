using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab07.Calculations
{
    public struct Factor
    {
        public string Name { get; set; }
        public (string, double)[] Levels;
        public byte Level;
    }

    public class Factors : IEnumerable<Factor>
    {
        private readonly List<Factor> _factors = new List<Factor>();

        public void Add(Factor factor)
        {
            _factors.Add(factor);
        }

        public void AddRange(params Factor[] factors)
        {
            _factors.AddRange(factors);
        }

        public void Remove(string name)
        {
            foreach (var factor in _factors)
            {
                if (factor.Name != name) continue;
                _factors.Remove(factor);
                break;
            }
        }

        public IEnumerator<Factor> GetEnumerator()
        {
            return _factors.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Factor this[string name]
        {
            get
            {
                foreach (var factor in _factors)
                {
                    if (factor.Name == name)
                    {
                        return factor;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }

            set
            {
                for (var i = 0; i < _factors.Count; ++i)
                {
                    // ReSharper disable once InvertIf
                    if (_factors[i].Name == name)
                    {
                        _factors[i] = value;
                        return;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
