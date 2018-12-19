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
            if (age >= 18 && age <=120)
            {
                Console.WriteLine("Vous avez " + age + " ans, vous êtes majeur."); //$ {age} "Vous avez
            }
            else if (age < 18 && >0) // else if == sinon si...
            {
                Console.WriteLine("Vous avez " + age + " ans, vous êtes mineur.");
            }
            else
            {
                Console.WriteLine("Oops, il doit y avoir une erreur");
            }   

        }
    }
}
