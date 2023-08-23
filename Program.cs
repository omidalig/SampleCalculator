// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using UniversityLibrary;
//Console.WriteLine("Hello, World!");


namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human myHuman=new Human();

            Student ghorbaniStudentObject=new Student();
            ghorbaniStudentObject.FirstName = "omidali";
            //ghorbaniStudentObject.Height = 180;
            string fullName1 = ghorbaniStudentObject.GetFullName();

            ghorbaniStudentObject.LastName = "Ghorbani";
            ghorbaniStudentObject.Age = 36;
            ghorbaniStudentObject.NationalCode = "0075454544";

            string fullName = ghorbaniStudentObject.GetFullName();


            while (true)
            {
                int n, m;
                string operand;

                string sampleNumber = "321";
                int sampleNumber2 = 321;
                //long sampleNumber_double = (long)sampleNumber2;

                bool isNumber = int.TryParse(sampleNumber,out int sampleNumber3);

                int sampleNumber4=Convert.ToInt32(sampleNumber);
                int sampleNumber5=int.Parse(sampleNumber);


                Console.WriteLine("Type  first number, and then press Enter");
                n = int.Parse(Console.ReadLine());

                Console.Write("Type second number , and then press Enter \n");
                m = int.Parse(Console.ReadLine());

                Console.WriteLine("Select the operation");
                Console.WriteLine(" + - add");
                Console.WriteLine(" - - Minus");
                Console.WriteLine(" * - Multiply");
                Console.WriteLine(" /- Divide");
                Console.WriteLine("Your Operation?");

                operand = Console.ReadLine();
                switch (operand)
                {
                    case "+":
                        Console.WriteLine("\t {x}+{y}=" + Sum(n, m));
                        break;
                    case "-":
                        Console.WriteLine("\t {x}-{y}=" + Minus(n, m));
                        break;
                    case "*":
                        Console.WriteLine("\t {x}*{y}=" + Multiple(n, m));
                        break;
                    case "/":
                        Console.WriteLine("\t {x}/{y}=" + Divide(n, m));
                        break;

                    default:
                        Console.WriteLine("\t the operand is wrong...");
                        break;


                }

                
            }

            Console.ReadKey();

        }
        public static int Sum(int n, int m)
        {

            return n + m;

        }
        static int Minus(int n, int m)
        {
            return n - m;

        }
        static int Multiple(int n, int m)
        {
            return n * m;
        }
        static double Divide(int n, int m)
        {
            return n / (double)m;
        }



    }
}


