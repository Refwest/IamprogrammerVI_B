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
        static void Main(string[] args)
        {
            //// 57. !Operator Overloading

            //    BankAccount b1 = new BankAccount("Filip", 1000);
            //    b1.printSaldo();
            //    Console.WriteLine(b1.Owner);
            //    Console.WriteLine(b1.Money);

            //    BankAccount b2 = new BankAccount("Paweł", 500);
            //    b2.printSaldo();
            //    Console.WriteLine(b2.Owner);
            //    Console.WriteLine(b2.Money);

            //    BankAccount b3 = b1 + b2;
            //    Console.WriteLine(b3.Owner);
            //    Console.WriteLine(b3.Money);

            //    BankAccount b4 = b1 + 400;
            //    Console.WriteLine(b4.Owner);
            //    Console.WriteLine(b4.Money);


            //!57_Passing_Methods_To_Objects


            Person p1 = new Person("Patryk", 18);
            

            Console.WriteLine(p1.Name);


            changePerson(p1);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);

        }

        public static void changePerson(Person p1)
        {
            p1.Name = "Seba";
            p1.Age = 20;

        }


    }
}

