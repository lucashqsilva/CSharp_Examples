using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_Exercice.Entities
{
    class Company : Payer
    {
        // A característica da "Pessoa Jurídica" é o número de funcionarios "Employees"

        public int Employees { get; set; }

        public Company()
        {

        }
        public Company (string name, double aincome, int employees) : base (name, aincome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if (Employees <= 10)
            {
                return aIncome * 0.14;
            }
            else
            {
                return aIncome * 0.16;
            }
        }
    }
}
