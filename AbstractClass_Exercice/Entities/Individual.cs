using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AbstractClass_Exercice.Entities
{
    class Individual : Payer
    {
        // A característica de "Pessoa física" é o gastos com saúde: HealtyTax
        public double HealtyTax { get; set; }
        
        public Individual()
        {

        }
        public Individual (string name, double aincome, double healtytax) : base (name, aincome)
        {
            HealtyTax = healtytax;
        }

        public override double Tax()
        {
            if (aIncome < 20000.0)
            {
                return aIncome * 0.15 - HealtyTax * 0.5;
            }
            else
            {
                return aIncome * 0.25 - HealtyTax * 0.5;
            }
        }
    }
}
