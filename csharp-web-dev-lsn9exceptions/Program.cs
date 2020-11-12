using System;
using System.Collections.Generic;
using System.Threading;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("cannot divide by zero");
            }

            else 
            {
                return x / y;
            }
        }

        public static int CheckFileExtension(string fileName)
        {
            if (fileName == null | fileName.Length == 0)
            {
                throw new ArgumentNullException("Submitted file cannot be null or empty!");
            }

            else
            {
                if (fileName.EndsWith(".cs"))
                {
                    return 1;
                }

                else
                {
                    return 0;
                }
            }
        }
      


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            Dictionary<double, double> numbers = new Dictionary<double, double>();
            numbers.Add(2, 3);
            numbers.Add(4, 2);
            numbers.Add(10, 0);
            numbers.Add(50, 5);

            int count = 0;
            foreach (KeyValuePair<double, double> number in numbers)
            {
                count++;
                try
                {
                    double result = Divide(number.Key, number.Value);
                    Console.WriteLine($"Result #{count}: {result}\n");
                }

                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"Result #{count}: {e}\n");
                }
            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    CheckFileExtension(student.Value);
                }

                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e);
                }
            }


        }
}
}
