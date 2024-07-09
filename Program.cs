using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            Console.Write("Enter FirstNumber:");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter SecondNumber:");
            int SecondNumber = int.Parse(Console.ReadLine());
            int Sum1 = FirstNumber + SecondNumber;
            Console.WriteLine("Sum is" + Sum1);


            //Question 2

            int num = 0;
            int sum = 0;
            while (num < 101)
            {
                int Total = sum + num;
                num = num + 2;
                Console.WriteLine(Total);
            }

            //Question 3

            Console.Write("Enter Year:");
            int Year = int.Parse(Console.ReadLine());
            int A = Year;
            if ((A % 4 == 0 && A % 100 != 0))
            {
                Console.WriteLine("Leap Year");
            }
            else if ((A % 100 == 0 && A % 400 == 0))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }

            //Question 4

            Console.Write("Enter Speed:");
            int Speed = int.Parse(Console.ReadLine());
            float M_f = 0.621371f;
            float S_m = Speed * M_f;
            Console.WriteLine("Speed in m/h is" + S_m);

            ////Question 5
            
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            if ((number % 7 == 0 || number % 10 == 7))
            {
                Console.WriteLine("Buzz Number");
            }
            else
            {
                Console.WriteLine("Not Buzz Number");
            }


            ////Question 6
            
            Console.Write("Enter number_1:");
            int number_1 = int.Parse(Console.ReadLine());
            int B;
            int C;
            for (B = 1; B < 11; B++)
            {
                 C = number_1 * B;
                Console.WriteLine("" + C);
            }

            // ////Question 7

            Console.Write("Enter number n:");
            int n = int.Parse(Console.ReadLine());
            int a;
            int f = 1;
            for (a = 1; a <= n; a++)
            {
                f *= a;
            }
            Console.Write("" + f);
            Console.ReadLine();

            // ////Question 8

            Console.Write("Enter number_2:");
            int number_2 = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int j = 1; j <= number_2; j++)
            {
                if (number % j == 0)
                {
                    isprime = false;
                    break;
                }
                if (isprime == true)
                {
                    Console.WriteLine("Prime Number");
                }
                else
                {
                    Console.WriteLine("Not Prime Number");
                }
            }

            ////Question 9
            
            Console.Write("Enter Side1:");
            int Side1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Side2:");
            int Side2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Side3:");
            int Side3 = int.Parse(Console.ReadLine());
            if ((Side1 == Side2 && Side2 == Side3)) 
            {
                Console.WriteLine("Equilateral triangle");
            }
            else if ((Side1 == Side2  || Side1 == Side3 ))
            {
                Console.WriteLine("Isosceles triangle");
            }
            //else if ((Side1 != Side2 && Side2 != Side3))
            else
            {
                Console.WriteLine("Scalene triangle");
            }
        }
    }
}