using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_Of_Programming_With_CSharp
{
    internal class Chapter_1
    {
        //Chapter 1
        public Chapter_1()
        {
            //Question 5
            Console.WriteLine("Q5: Good Day");

            //Question 6
            Console.WriteLine("Q6: Takura Maringire");

            //Question 7
            Console.WriteLine("Q7: 1\n101\n1001");

            //Question 8
            string dateTime = DateTime.Now.ToString();
            Console.WriteLine($"Q8: {dateTime}");

            //Question 9
            double sqrt = Math.Sqrt(12345);
            Console.WriteLine($"Q9: {sqrt}");

            //Question 10
            Console.Write("Q10: ");
            int startingValue = 2;
            int endingValue = startingValue + 100;
            for (int i = startingValue; i < endingValue; i++)
            {
                //int temp = i + 2;
                //Console.Write((temp % 2 == 0 ? temp : temp * -1) + ", ");

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                    Console.WriteLine(i*-1);
            }
              
            Console.Write(Environment.NewLine);
            
            //Question 11
            Console.Write("Q11: Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your age after 10 years will be {age + 10}");

            Console.ReadLine();
        }
    }
}
