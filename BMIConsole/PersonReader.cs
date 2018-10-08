using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIConsole
{
    class PersonReader
    {

        public Person readPerson()
        {
            Console.WriteLine("Podaj ile ważysz w kg");
            int weight = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj twój wzrost w metrach");
            double height = Double.Parse(Console.ReadLine());

            Person person = new Person(weight, height);
            return person;
        }
    }
}
