
using System.Security.Cryptography.X509Certificates;

namespace dio.Models
{
    public class Calculator
    {
        public void Sum(decimal a, decimal b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Sub(decimal a, decimal b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");

        }

        public void Multiply(decimal a, decimal b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public void Division(decimal a, decimal b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        public void Power(decimal a, decimal b)
        {
            var x = (double) a;
            var y = (double) b;
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(x, y)}");
        }

        public void Sin(double a)
        {
            var radian = a * Math.PI / 180;
            Console.WriteLine($"sin{a}º = {Math.Sin(radian):N}");
        }
        public void Cos(double a)
        {
            var radian = a * Math.PI / 180;
            Console.WriteLine($"cos{a}º = {Math.Cos(radian):N}");
        }
        public void Tan(double a)
        {
            var radian = a * Math.PI / 180;
            Console.WriteLine($"tg{a}º = {Math.Tan(radian):N}");
        }
        public void SquareRoot(decimal a)
        {
            var x = (double) a;
            Console.WriteLine($"√{a} = {Math.Sqrt(x)}");
        }
    }
}