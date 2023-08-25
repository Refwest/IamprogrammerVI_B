using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IamprogrammerVI_B
{
    internal class BankAccount
    {
        private string owner;
        private double money;



        public BankAccount(string owner, double money)
        {
            this.money = money;
            this.owner = owner;
        }

        public void printSaldo()
        {
            Console.WriteLine("Hi, {0} your saldo in bank account equals {1}", owner, money);
        }

        public string Owner

        { 
            get
            { 
                return owner; 
            } 
        }

        public double Money
        {
            get
            {
                return money;
            }
        }

        public static BankAccount operator +(BankAccount bank1, BankAccount bank2)
        {
         double newAmountOfMoney = bank1.Money + bank2.Money;
            string newOwners = bank1.Owner + "+" + bank2.Owner;
            BankAccount newBankAccount = new BankAccount(newOwners, newAmountOfMoney);

            return newBankAccount;

        }

        public static BankAccount operator +(BankAccount bank1, double amount)
        {
            double newAmountOfMoney = bank1.Money + amount;
            BankAccount bank3 = new BankAccount(bank1.Owner, newAmountOfMoney);
            return bank3;

        }

        //implicit

        public static implicit operator double(BankAccount bank1)
        {
            return bank1.Money;
        }
    }
}
