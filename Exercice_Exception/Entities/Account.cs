using Exercice_Exception.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_Exception.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double withdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            withdrawLimit = withdrawlimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //Aplicando as excecoes customiadas para a função de saque !
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance !");
            }
            if (amount > withdrawLimit)
            {
                throw new DomainException("The amount exceeds Withdraw Limit !");
            }
            Balance -= amount;
        }
    }
}
