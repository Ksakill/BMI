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

            Console.WriteLine("underwight: 16-18,5     norm: 18,5'24     over weight: 24-30     first degree of obisity: 30-35    second degree of obeisty; 35-40      thred degree of obisty: 40-up");
            
        }
        static double calckBMI(double Vægt, double Højde)
        {
            return Vægt / (Højde * Højde);
            
        }
    }
}
