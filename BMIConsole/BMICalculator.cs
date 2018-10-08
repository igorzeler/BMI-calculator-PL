using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIConsole
{
    class BMICalculator
    {

        public BMILevel calculateBMI(Person person)
        {
            double personBMI = person.getBMI();
            IEnumerable<BMILevel> bmiLevels = BMILevel.Values;

            foreach (var level in bmiLevels)
            {
                if (personBMI >= level.minValue && personBMI < level.maxValue) return level;
            }
            return null;
        }

    }
}
