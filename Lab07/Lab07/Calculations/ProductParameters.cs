using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab07.Calculations
{
    public struct ProductParameter
    {
        public string Name { get; set; }
        public uint Value { get; set; }
    }

    public class ProductParameters : IEnumerable<ProductParameter>
    {
        private readonly List<ProductParameter> _parameters =
            new List<ProductParameter>();

        public void Add(ProductParameter parameter)
        {
            _parameters.Add(parameter);
        }

        public void AddRange(params ProductParameter[] parameters)
        {
            _parameters.AddRange(parameters);
        }

        public void Remove(string name)
        {
            foreach (var parameter in _parameters)
            {
                if (parameter.Name != name) continue;
                _parameters.Remove(parameter);
                break;
            }
        }

        public IEnumerator<ProductParameter> GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public ProductParameter this[string name]
        {
            get
            {
                foreach (var parameter in _parameters)
                {
                    if (parameter.Name == name)
                    {
                        return parameter;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }

            set
            {
                for (var i = 0; i < _parameters.Count; ++i)
                {
                    // ReSharper disable once InvertIf
                    if (_parameters[i].Name == name)
                    {
                        _parameters[i] = value;
                        return;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
