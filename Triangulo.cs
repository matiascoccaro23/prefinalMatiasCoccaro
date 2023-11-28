namespace ManejoTriangulos
{
    internal class Triangulo
    {
        public double LadoA { get; internal set; }
        public double LadoB { get; internal set; }
        public double LadoC { get; internal set; }
        public string? ColorRelleno { get; internal set; }

        public double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public double CalcularArea()
        {
           
            double s = CalcularPerimetro() / 2;
            return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
        }

        public string DeterminarTipoTriangulo()
        {
           
            if (LadoA == LadoB && LadoB == LadoC)
            {
                return "Equilátero";
            }
            else if (LadoA == LadoB || LadoB == LadoC || LadoA == LadoC)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }

        internal bool EsTrianguloValido()
        {
            throw new NotImplementedException();
        }
    }
}