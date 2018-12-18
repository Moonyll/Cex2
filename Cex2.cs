using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, quel est votre âge ?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("Vous avez " + age + " ans, vous êtes majeur.");
            else
                Console.WriteLine("Vous avez " + age + " ans, vous êtes mineur.");

        }
    }
}
