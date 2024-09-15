using System;

namespace Perceptron_Com_Planilha
{
    public class Amostra
    {
        public Amostra(double valor1, double valor2, int resultadoEsperado)
        {
            Valor1 = valor1;  // x1 
            Valor2 = valor2;  // x2
            ResultadoEsperado = resultadoEsperado;  // y
        }

        public double Valor1 { get; private set; }
        public double Valor2 { get; private set; }
        public int ResultadoEsperado { get; private set; }
    }
}