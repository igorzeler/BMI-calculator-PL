using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicjalizacja klas
            PersonReader reader = new PersonReader();
            BMICalculator calculator = new BMICalculator();
            BMIPrinter printer = new BMIPrinter();

            //logika
            Person person = reader.readPerson();
            BMILevel calculatedBMILevel = calculator.calculateBMI(person);

            //prezentacja wyniku
            printer.printBMI(calculatedBMILevel);
        }
    }
}
