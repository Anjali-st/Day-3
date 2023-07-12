using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myNum = 12;
            var myString = "Sam";
            var status = true;
            var grade = 'A';
            Console.WriteLine("Value Stored in myNum is: "+myNum +"\n Data Type : "+myNum.GetType());
            Console.WriteLine("Value Stored in myNum is: " + myString + "\n Data Type : " + myString.GetType());
            Console.WriteLine("Value Stored in myNum is: " + status + "\n Data Type : " + status.GetType());
            Console.WriteLine("Value Stored in myNum is: " + grade + "\n Data Type : " + grade.GetType());
            Console.ReadKey();




        }
    }
}
