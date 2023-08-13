using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {

            double Vægt, Højde;

            Console.Write("Insert Vægt i KG: ");
            string weightinput = Console.ReadLine();
            Vægt = Convert.ToDouble(weightinput);

            Console.Write("Insert Højde CM: ");
            string heightInput = Console.ReadLine();
            Højde = Convert.ToDouble(heightInput);


            double bmi = calckBMI(Vægt, Højde / 100);

            Console.WriteLine($"Your BMI is {bmi:f2} ");
            Console.ReadLine();
        }
        static double calckBMI(double Vægt, double Højde)
        {
            return Vægt / (Højde * Højde);
        }



    }
}
