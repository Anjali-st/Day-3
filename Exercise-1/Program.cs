using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("enter the username");
            username = Console.ReadLine();
            string Password;
            Console.WriteLine("enter the password");
            Password = Console.ReadLine();
            if (username == "admin1256" && Password == "admin@1256@1256")
            {
                Console.WriteLine("SIGN SUCCESS");
            }
            else if (username == "" && Password == "")
            {
                Console.WriteLine("please provide username and password");
            }
            else
            {
                Console.WriteLine("invalid user name and password");
            }
            Console.ReadKey();
        }
    }
    }

