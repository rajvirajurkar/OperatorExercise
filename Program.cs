using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;

            int c = a + b;

            Console.WriteLine($" Value after adding a and b : {c}");
            Console.WriteLine($" Value after sub a and b : {a - b}");
            Console.WriteLine($" Value after multiplication of a and b : {a * b}");
            Console.WriteLine($" Value after modulus of a and b : {a % b}");
            Console.WriteLine($" {a}/{b} is {quotient} remainder is {remainder}");


            Console.WriteLine("Please enter the radius of the cricle ");

            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a cricle with radius {radius} is {area}");



        }
    }
}

