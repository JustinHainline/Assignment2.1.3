using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = SimpleMath.Add(4, 5);
            decimal sum2 = SimpleMath.Add(1.5m, 3.4m, 3.0m);
            float equal1 = SimpleMath.Multiply(2.2f, 3.3f);
            float equal2 = SimpleMath.Multiply(2.2f, 3.3f, 4.4f);

            Console.WriteLine($"Sum1: {sum1}");
            Console.WriteLine($"Sum2: {sum2}");
            Console.WriteLine($"Equal1: {equal1}");
            Console.WriteLine($"Equal2: {equal2}");


        }
    }

    public class SimpleMath
    {
        static public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static public decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        static public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        static public float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }
}
