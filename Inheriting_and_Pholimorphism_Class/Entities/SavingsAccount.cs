using System;
using System.Collections.Generic;
using System.Text;

namespace Aula122_Heranca.Entities
{
    // Sealed: indica que a classe não pode ser herdada...
    // Serve para proteger alguma regra de negocio etc.
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // sobreposição: reimplementar na subclasse a operação que ja existe na superclasse
        // podendo dar a ela um comportamento diferente do que ela possui
        // no caso da SavingsAccount não será descontado os 5 pila no momento do saque:

        //inserindo o sealed em um metodo, indica que este metodo não poderá ser escrito novamente em 
        //uma outra subclasse.
        public sealed override void Withdraw(double amount)
        {
            // podemos tambem utilizar dos metodos implementados na super classe e inserir novos comportamentos:
            // Balance -= amount;
            // supondo agora que para sacar da conta poupança seja além de descontar 5 reais...
            // também descontar mais 2 reais!

            base.Withdraw(amount);
            Balance -= 2.0;

        }
    }
}