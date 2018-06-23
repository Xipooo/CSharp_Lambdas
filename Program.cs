using System;

namespace CSharp_Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathServ = new MathService();
            //mathServ.MathPerformed += (sender, e) => Console.WriteLine("Caluculation Result: " + e.Result);
            mathServ.MathPerformed += (result) => Console.WriteLine("Calculated Result: " + result);

            mathServ.CalculateNumbers(43.598, 87.23, (value1, value2) => value1 * value2);
        }
    }
}
