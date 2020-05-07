using System;
using System.Collections.Generic;
using System.Text;
using AbstractClass_and_AbstractMethod.Entities.Enums;

namespace AbstractClass_and_AbstractMethod.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        // declarando que a operação Área será abstrata
        // não precisa inserir return nem operações, pois ela será usada para 
        // as subclasses de SHAPE, cada qual retornando a formula de sua forma
        public abstract double Area();
    }
}
