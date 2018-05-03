using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab07.Calculations
{
    public struct ProgLanguage
    {
        public string Name { get; set; }
        public int SlocMultiplier { get; set; }
        public byte SlocPercent { get; set; }
    }

    public class ProgLanguages : IEnumerable<ProgLanguage>
    {
        private readonly List<ProgLanguage> _progLanguages = new List<ProgLanguage>();

        public void Add(ProgLanguage language)
        {
            _progLanguages.Add(language);
        }

        public void AddRange(params ProgLanguage[] languages)
        {
            _progLanguages.AddRange(languages);
        }

        public void Remove(string name)
        {
            foreach (var language in _progLanguages)
            {
                if (language.Name != name) continue;
                _progLanguages.Remove(language);
                break;
            }
        }

        public IEnumerator<ProgLanguage> GetEnumerator()
        {
            return _progLanguages.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public ProgLanguage this[string name]
        {
            get
            {
                foreach (var language in _progLanguages)
                {
                    if (language.Name == name)
                    {
                        return language;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }

            set
            {
                for (var i = 0; i < _progLanguages.Count; ++i)
                {
                    // ReSharper disable once InvertIf
                    if (_progLanguages[i].Name == name)
                    {
                        _progLanguages[i] = value;
                        return;
                    }
                }
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
