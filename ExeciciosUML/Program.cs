using ExeciciosUML.Moldels;
using System;
using System.Collections.Generic;

namespace ExeciciosUML
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaLuz>()
            {
                new ContaLuz(DateTime.Parse("10/01/2022"),4601,460),
                new ContaLuz(DateTime.Parse("10/02/2022"),4602,350),
                new ContaLuz(DateTime.Parse("10/03/2022"),4603,341),
                new ContaLuz(DateTime.Parse("10/04/2022"),4604,654),
            };

            foreach (var conta in contas)
            {
                conta.ValorPagar = conta.CalcValorPagar();
                conta.MediaConsumo = conta.CalcMediaConsumo();
            }

            foreach (var conta in contas)
            {
                Console.WriteLine(conta);
            }

            var menorConsumo = ContaLuz.VerificaMesMenorConsumo(contas);
            var MaiooConsumo = ContaLuz.VerificaMesMaiorConsumo(contas);
            Console.WriteLine();
            Console.WriteLine($"Menor Consumo {menorConsumo.QtdKwGasto} {menorConsumo.DataLeitura.ToShortDateString()}");
            Console.WriteLine($"Maior Consumo {MaiooConsumo.QtdKwGasto} {MaiooConsumo.DataLeitura.ToShortDateString()}");
        }
    }
}
