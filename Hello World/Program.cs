using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("hello world!");
            System.Console.Write("wow");
            Console.ReadLine();
            // int age = 23;

            // long bigNumber = 900000000000L;

            System.Console.WriteLine(long.MaxValue);
            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            // decimal money =  14.99M;
            System.Console.WriteLine(money);
            int x,y,z;
            int l = 1,
                m = 2,
                k = 3;
            string name = "blah";
            char letter = 'k';  // can't store '', default is '\0' for char



            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            string textBigNumber = "900000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            System.Console.WriteLine(bigNumber);
            Console.WriteLine(age);


            bool value = true;
            bool isMale = false;

            double numApples = 23;
            numApples /= 2;
            // use double to keep decimal!

            var myString = "hey";
            myString += " there";  //valid!



            const int vat = 20;
            System.Console.WriteLine(vat);

        }
    }
}
// Console.WriteLine("Helloooooo out there");








