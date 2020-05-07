/*
    ao criar a subclasse, observamos que haverá um erro no Retangle,
    pois ao criar a superclasse shape, criamos apenas o construtor com argumento,
    se tornando onbrigatório a Color ao instanciar um shape

    dessa forma, criaremos um construtor padrão (sem argumento) para eliminar a obrigatoriedade

    após isso, o erro persiste, pois o retangulo nao obtem um metodo de area, para eliminar o erro,
    devemos obrigatoriamente implementar a classe abstrata...
 
 */

using AbstractClass_and_AbstractMethod.Entities.Enums;

namespace AbstractClass_and_AbstractMethod.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        // tornando obrigatório o uso da Color, devemos criar o construtor na forma, para assim
        // eliminar o erro da implementação da classe.
        public Rectangle(double width, double heigth, Color color) : base(color)
        {
            Width = width;
            Heigth = heigth;
        }

        public override double Area()
        {
            return Width * Heigth;
        }
    }


}
