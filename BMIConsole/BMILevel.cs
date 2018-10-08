using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIConsole
{
    public class BMILevel
    {
        public static readonly BMILevel WYGLODZONY = new BMILevel(0.0, 16.0, "Jesteś wygłodzony!");
        public static readonly BMILevel WYCHODZONY = new BMILevel(16.0, 17.0, "Jesteś wychudzony!");
        public static readonly BMILevel NIEDOWAGA = new BMILevel(17.0, 19.0, "Masz niedowagę!");
        public static readonly BMILevel NORMA = new BMILevel(19.0, 30.0, "Mieścisz się w normie!");
        public static readonly BMILevel I_OTYLOSC = new BMILevel(30.0,35.0, "Masz I stopień otyłości");
        public static readonly BMILevel II_OTYLOSC = new BMILevel(35.0, 40.0, "Masz II stopień otyłości(otyłość kliniczna)");
        public static readonly BMILevel III_OTYLOSC = new BMILevel(40.0, Double.MaxValue, "Masz III stopień otyłości(otyłość skrajna, albo jesteś za niski)");

        public static IEnumerable<BMILevel> Values
        {
            get
            {
                yield return WYGLODZONY;
                yield return WYCHODZONY;
                yield return NIEDOWAGA;
                yield return NORMA;
                yield return I_OTYLOSC;
                yield return II_OTYLOSC;
                yield return III_OTYLOSC;
            }
        }

        public double minValue { get; private set; }
        public double maxValue { get; private set; }
        public String message { get; private set; }

        BMILevel(double min, double max, String mess)
        {
            minValue = min;
            maxValue = max;
            message = mess; 
        }
           
    }
}
