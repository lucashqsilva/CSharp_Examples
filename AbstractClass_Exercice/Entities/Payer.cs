using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace AbstractClass_Exercice.Entities
{
    //esta classe será criada de forma abstrata
    //a fim de servir de herança para as subclasses
    // conterá os atributos em comum às outras classes
    //
    //Payer significa o tipo do contribuente, se é pessoa fisica ou juridica
    abstract class Payer
    {
        public string Name { get; set; }
        public double aIncome { get; set; }

        public Payer()
        {

        }

        public Payer(string name, double aincome)
        {
            Name = name;
            aIncome = aincome;
        }

        // classe abstrata manipulavel pelas subclasses
        public abstract double Tax();
    }
}
