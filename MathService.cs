using System;
using System.Timers;

namespace CSharp_Lambdas
{
    public class MathService
    {
        //public event EventHandler<MathPerformedEventArgs> MathPerformed;
        public delegate void MathPerformedHandler(double result);
        public delegate double CalculationHandler(double value1, double value2);
        public event MathPerformedHandler MathPerformed;
        public void CalculateNumbers(double value1, double value2, CalculationHandler calculation)
        {
            Timer timer = new Timer(5000);
            //MathPerformed(this, new MathPerformedEventArgs{ Result = value1 * value2});
            MathPerformed(calculation(value1, value2));
        }
    }
}