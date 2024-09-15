using System;
using System.Collections.Generic;

namespace Perceptron_Com_Planilha
{
    public class Perceptron
    {
        public PesosModel Pesos { get; private set; }

        public double Saida { get; private set; }

        public double TaxaAprendizado { get; private set; }

        public Perceptron(double taxaAprendizado, double peso1Inicial, double peso2Inicial)
        {
            Saida = 0.0;
            TaxaAprendizado = taxaAprendizado;
            Pesos = new PesosModel(peso1Inicial, peso2Inicial);
        }

        public void AjustarPesos(List<Amostra> amostras, int epocas)
        {
            for (int i = 0; i < epocas; i++)
            {
                foreach (var amostra in amostras)
                {
                    Saida = amostra.Valor1 * Pesos.Peso1
                        + amostra.Valor2 * Pesos.Peso2;
                    if (Classificar(Saida) != amostra.ResultadoEsperado)
                    {
                        double erro = amostra.ResultadoEsperado - Classificar(Saida);
                        AtualizarPesos(erro, amostra);
                    }
                }
            }
        }

        private int Classificar(double saida)
        {
            return saida >= 0 ? 1 : 0;
        }

        private void AtualizarPesos(double erro, Amostra amostra)
        {
            double novoPeso1 = Pesos.Peso1 + TaxaAprendizado * erro * amostra.Valor1;
            double novoPeso2 = Pesos.Peso2 + TaxaAprendizado * erro * amostra.Valor2;
            Pesos.DefinirPesos(novoPeso1, novoPeso2);
        }

        public int Predizer(double valor1, double valor2)
        {
            double resultado = valor1 * Pesos.Peso1 + valor2 * Pesos.Peso2;
            return Classificar(resultado);
        }
    }
}