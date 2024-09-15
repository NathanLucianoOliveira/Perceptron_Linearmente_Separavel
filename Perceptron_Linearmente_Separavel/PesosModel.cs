using System;

namespace Perceptron_Com_Planilha
{
    public class PesosModel
    {
        public PesosModel(double peso1Inicial, double peso2Inicial)
        {
            Peso1 = peso1Inicial;
            Peso2 = peso2Inicial;
        }

        public double Peso1 { get; private set; }
        public double Peso2 { get; private set; }

        public void DefinirPesos(double novoPeso1, double novoPeso2)
        {
            Peso1 = novoPeso1;
            Peso2 = novoPeso2;
        }
    }
}