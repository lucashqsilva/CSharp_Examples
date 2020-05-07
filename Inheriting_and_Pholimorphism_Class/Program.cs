using System;
using Aula122_Heranca.Entities;

/* AULA 122 E 123 
 * 
 * HERANÇA ( AULA 122 ) CRIANDO AS CLASSES ACCOUNT E BUSINESSACCOUNT
 * 
 * UPPERCAST E DOWNCAST ( AULA 123 ) CRIANDO A CLASSE SAVINGACCOUNT
 * 
 */

namespace Aula122_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Lucao", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Mateusao", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Larissinha", 0.0, 0.01);

            //DOWNCASTING
            //  operação insegura...

            BusinessAccount acc4 = (BusinessAccount)acc2;
            // BusinessAccount acc5 = (BusinessAccount)acc3; 
            // o erro ocorre pois nao há compatibilidade entre as contas.
            // para tesar o erro:

            if (acc3 is BusinessAccount) //a acc3 não é uma instancia de business account
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                //sintaxe alternativa
                BusinessAccount acc6 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)  // a acc3 é uma instancia de savings account
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                //sintaxe alternativa
                SavingsAccount acc6 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }

            Account acc7 = new Account(123, "Maconheiro", 500.0);
            Account acc8 = new SavingsAccount(1234, "Lucao", 500.0, 0.01);

            acc7.Withdraw(10.0);
            acc8.Withdraw(10.0);

            Console.WriteLine(acc7.Balance);
            Console.WriteLine(acc8.Balance);
        }
    }
}
