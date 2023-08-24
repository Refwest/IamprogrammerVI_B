using IamprogrammerVI_B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace IamprogrammerVI
{
    class Program
    {
        // 
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("Filip", 1000);
            b1.printSaldo();
            Console.WriteLine(b1.Owner);
            Console.WriteLine(b1.Money);

            BankAccount b2 = new BankAccount("Paweł", 500);
            b2.printSaldo();
            Console.WriteLine(b2.Owner);
            Console.WriteLine(b2.Money);

            BankAccount b3 = b1 + b2;
            Console.WriteLine(b3.Owner);
            Console.WriteLine(b3.Money);

            BankAccount b4 = b1 + 400;
            Console.WriteLine(b4.Owner);
            Console.WriteLine(b4.Money);


        }
    }
}