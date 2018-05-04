using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab07.Calculations
{
    public struct FunctionalPoint
    {
        public string Name { get; set; }
        public int[,] PossibleValues { get; set; }       
        public int[] Level { get; set; }
        public int Value => PossibleValues[Level[0], Level[1]];
    }

    public class FunctionalPoints : IEnumerable<FunctionalPoint>
    {
        private readonly List<FunctionalPoint> _points = new List<FunctionalPoint>();

        public void Add(FunctionalPoint point)
        {
            _points.Add(point);
        }

        public void AddRange(params FunctionalPoint[] points)
        {
            _points.AddRange(points);
        }

        public void Remove(string name)
        {
            foreach (var point in _points)
            {
                if (point.Name != name) continue;
                _points.Remove(point);
                break;
            }
        }

        public IEnumerator<FunctionalPoint> GetEnumerator()
        {
            return _points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public FunctionalPoint this[string name]
        {
            get
            {
                foreach (var point in _points)
                {
                    if (point.Name == name)
                    {
                        return point;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }

            set
            {
                for (var i = 0; i < _points.Count; ++i)
                {
                    // ReSharper disable once InvertIf
                    if (_points[i].Name == name)
                    {
                        _points[i] = value;
                        return;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
