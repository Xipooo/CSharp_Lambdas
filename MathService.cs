using System;
using System.Timers;

namespace CSharp_Lambdas
{
    public class MathService
    {
        //public event EventHandler<MathPerformedEventArgs> MathPerformed;
        public Action<double> MathPerformed;
        //public delegate double (double value1, double value2);
        public void CalculateNumbers(double value1, double value2, Func<double, double, double> calculation)
        {
            Timer timer = new Timer(5000);
            //MathPerformed(this, new MathPerformedEventArgs{ Result = value1 * value2});
            MathPerformed(calculation(value1, value2));
        }
    }
}
