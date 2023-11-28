using System;

namespace Entidades
{
    public class Triangulo
    {
        
        private double ladoA;
        private double ladoB;
        private double ladoC;

        
        public double LadoA
        {
            get { return ladoA; }
            set { ladoA = value; }
        }

        public double LadoB
        {
            get { return ladoB; }
            set { ladoB = value; }
        }

        public double LadoC
        {
            get { return ladoC; }
            set { ladoC = value; }
        }

        public string? ColorRelleno { get; set; }

        public bool EsTrianguloValido()
        {
            return ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA;
        }
    }
}

namespace ManejoTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {      
            Triangulo miTriangulo = new Triangulo();

            
            Console.Write("Ingrese el valor del lado A: ");
            miTriangulo.LadoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor del lado B: ");
            miTriangulo.LadoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor del lado C: ");
            miTriangulo.LadoC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el color de relleno: ");
            miTriangulo.ColorRelleno = Console.ReadLine();

            
            if (miTriangulo.EsTrianguloValido())
            {
                Console.WriteLine("Los lados conforman un triángulo.");
            }
            else
            {
                Console.WriteLine("Los lados no conforman un triángulo válido.");
            }

           
        }
    }
}