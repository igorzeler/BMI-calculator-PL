//Napisz program, który oblicza wskaźnik masy ciała BMI.Program ma prosić
//użytkownika o podanie wagi w kg oraz wzrostu w metrach.

using System;

namespace CS_AE_3._6
{
    class Bmi
    {
        private int Weight;
        private double Height;


        public void GetData()
        {
             Console.WriteLine("Podaj ile ważysz w kg");
             Weight = Int32.Parse(Console.ReadLine());
             if (Weight <= 0) DataError();
             Console.WriteLine("Podaj twój wzrost w metrach");
             Height = Double.Parse(Console.ReadLine());
             if (Height <= 0) DataError();
        }

        public double CountBMI() => Weight / (Height * Height);


        public void PrintBMI(double result)
        {
            Console.WriteLine($"BMI wynosi {Math.Round(result, 2)}");
        }

        public void ObesityLevel(double bmi)
        {
            //Funcja klasyfikuje stopień otyłości
            if (bmi < 16.0)
                Console.WriteLine("Jesteś wygłodzony!");
            else if (bmi >= 16.0 && bmi < 17.0)
                Console.WriteLine("Jesteś wychudzony!");
            else if (bmi >= 17.0 && bmi < 19.0)
                Console.WriteLine("Masz niedowagę!");
            else if (bmi >= 18.5 && bmi < 30.0)
                Console.WriteLine("Mieścisz się w normie!");
            else if (bmi >= 30.0 && bmi < 35.0)
                Console.WriteLine("Masz I stopień otyłości");
            else if (bmi >= 35.0 && bmi < 40.0)
                Console.WriteLine("Masz II stopień otyłości(otyłość kliniczna)");
            else if (bmi >= 40.0)
                Console.WriteLine("Masz III stopień otyłości(otyłość skrajna)");
        }

        public void DataError()
        {
            throw new Exception("Wprowadzono nieprawidłowe dane!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bmi o1 = new Bmi();
                o1.GetData();
                o1.PrintBMI(o1.CountBMI());
                o1.ObesityLevel(o1.CountBMI());

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}