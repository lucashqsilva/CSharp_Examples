using System;
using System.Collections.Generic;
using System.Text;

namespace Aula122_Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }   //setado como protected para que apenas a subclasse tenha permissao de escrita dos dados.

        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //inserindo a palavra virtual para permitir sobreposição ( Olhar SavingsAccount )
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.00;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
