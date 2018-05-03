using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab07.Calculations;

namespace Lab07.IO.Data
{
    public class ProgLanguagesLoader
    {
        public ProgLanguages GetDefault()
        {
            var languages = new ProgLanguages();
            languages.AddRange(
                new ProgLanguage
                {
                    Name = "SQL",
                    SlocMultiplier = 25,
                    SlocPercent = 30
                },
                new ProgLanguage
                {
                    Name = "JavaScript",
                    SlocMultiplier = 15,
                    SlocPercent = 10
                },
                new ProgLanguage
                {
                    Name = "Java",
                    SlocMultiplier = 10,
                    SlocPercent = 60
                }
            );
            return languages;
        }
    }
}
