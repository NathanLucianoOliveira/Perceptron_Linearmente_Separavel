using System;
using System.Collections.Generic;
using Perceptron_Com_Planilha;

class Program
{
    static void Main(string[] args)
    {
        double taxaAprendizado = 0.7;
        double pesoInicial1 = 0.6;
        double pesoInicial2 = 0.2;

        // Definição das amostras a partir dos dados da planilha
        List<Amostra> amostras = new List<Amostra>
        {
            new Amostra(113, 6.8, 0),  // Maçã
            new Amostra(122, 4.7, 1),  // Laranja
            new Amostra(107, 5.2, 0),  // Maçã
            new Amostra(98, 3.6, 0),   // Maçã
            new Amostra(115, 2.9, 1),  // Laranja
            new Amostra(120, 4.2, 1)   // Laranja
        };

        // Criação do perceptron com pesos iniciais e taxa de aprendizado da planilha
        Perceptron perceptron = new Perceptron(taxaAprendizado, pesoInicial1, pesoInicial2);

        // Treinamento do perceptron
        perceptron.AjustarPesos(amostras, 5000);

        Console.WriteLine("Pesos ajustados:");
        Console.WriteLine($"Peso1: {perceptron.Pesos.Peso1:F4}");
        Console.WriteLine($"Peso2: {perceptron.Pesos.Peso2:F4}");

        // Classificação
        Console.WriteLine("\nClassificação dos dados:");
        foreach (var amostra in amostras)
        {
            var resultado = perceptron.Predizer(amostra.Valor1, amostra.Valor2);
            Console.WriteLine($"Amostra ({amostra.Valor1}, {amostra.Valor2}): " +
                (resultado == 1 ? "Maçã" : "Laranja"));
        }
    }
}