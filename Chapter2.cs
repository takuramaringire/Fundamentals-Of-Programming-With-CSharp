using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_Of_Programming_With_CSharp
{
    internal class Chapter2
    {
        //Chapter 2
        public Chapter2()
        {
            //Question 1
            sbyte a = 52;
            byte b = 130;
            short c = -115;
            int d = 4825932;
            sbyte e = 97;
            short f = -10000;
            ushort g = 20000;
            byte h = 224;
            short i = 970;
            uint j = 700000;
            byte k = 112;
            sbyte l = -44;
            int m = -1000000;
            ushort n = 1990;
            ulong o = 123456789123456789;

            //Question 2
            double a1 = 5;
            double a2 = -5.01;
            decimal a3 = 34.567839023m;
            float a4 = 12.345f;
            float a5 = 8923.1234857f;
            decimal a6 = 3456.091124875956542151256683467m;

            //Question 3
            Console.Write("Enter first number: ");
            float first = float.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            float second = float.Parse(Console.ReadLine());
            Console.WriteLine(first==second ? "These numbers are equal":"These numbers are not equal");

            //Question 4
            int hexNum = 0x100;
            hexNum.ToString();
            Console.WriteLine($" Hex value of 256 is {hexNum}");

            //Question 5
            char hexChar = (char)0x48;
            Console.WriteLine($" Character value of hex equivalent of Unicode 72 is {hexChar}");

            //Question 6
            bool isMale = true;

            //Question 7
            string firstWord = "Hello";
            string secondWord = "World";
            object finalSentence = firstWord + " " + secondWord;
            Console.WriteLine(finalSentence);

            //Question 8
            string castedSentence = (string)finalSentence;

            //Question 9
            string quotedString = @"The ""use"" of quotations causes difficulties ";
            string unQuotedString = "The \"use\" of quotations causes difficulties";

            //Question 10
            string heart = @"" + 
                @"  o     o" + Environment.NewLine + 
                @" o o   o o" + Environment.NewLine + 
                @"  o  o  o" + Environment.NewLine + 
                @"   o   o" + Environment.NewLine +
                @"     o";
            Console.WriteLine(heart);

            //Question 11
            string triangle = $"" + $"     ©     " + Environment.NewLine + $"    © ©    " + Environment.NewLine + $"   ©   ©   " + Environment.NewLine +
                $"  © © © ©";
            Console.WriteLine(triangle);

            //Question 12
            /*
             First Name -> string firstName
             Second Name -> string secondName
             Age -> byte age
             Gender -> bool isMale
             Unique Employee Number -> uint id
            */

            //Question 13
            int x, y, z;
            x = 5; y = 10;
            Console.WriteLine($"X:{x}, Y:{y}");
            z = x; x = y; y = z;
            Console.WriteLine($"X:{x}, Y:{y}");

            Console.ReadLine();
        }
    }
}
