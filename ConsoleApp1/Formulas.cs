using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaAreas
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public override void Area()
        {
            Console.WriteLine($"A área do quadrado de lado {Lado} é: {Lado * Lado}");
        }
    }

    public class Retangulo : Forma
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public override void Area()
        {
            Console.WriteLine($"A área do retangulo de base {Base} e altura {Altura} é: {(Base * Altura)}");
        }

    }


    public class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override void Area()
        {
            Console.WriteLine($"A área do triangulo de base {Base} e altura {Altura} é: {(Base * Altura)/2}");
        }
    }

    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public override void Area()
        {
            Console.WriteLine($"A área do circuo de raio {Raio} é: {Math.Pow(Raio, 2)* Math.PI}");
        }
    }
}
