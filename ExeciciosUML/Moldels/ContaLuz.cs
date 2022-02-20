using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeciciosUML.Moldels
{
    public class ContaLuz
    {
        public ContaLuz(DateTime dataLeitura, int numeroLeitura, int qtdKwGasto)
        {
            DataLeitura = dataLeitura;
            NumeroLeitura = numeroLeitura;
            QtdKwGasto = qtdKwGasto;
        }

        public DateTime DataLeitura { get; private set; }
        public int NumeroLeitura { get; private set; }
        public int QtdKwGasto { get; private set; }
        public double ValorPagar { get; set; }
        public DateTime DataPagamento { get; set; }
        public double MediaConsumo { get; set; }

        public static ContaLuz VerificaMesMenorConsumo(List<ContaLuz> contas)
        {
            if (contas.Count <= 0)
                throw new ArgumentException("A lista esta vazia");

            return contas.OrderBy(conta => conta.QtdKwGasto).First();
        }

        public static ContaLuz VerificaMesMaiorConsumo(List<ContaLuz> contas)
        {
            if (contas.Count <= 0)
                throw new ArgumentException("A lista esta vazia");
  
            return contas.OrderBy(conta => conta.QtdKwGasto).Last();
        }

        public double CalcMediaConsumo()
        {
            return QtdKwGasto / 30;
        }

        public double CalcValorPagar() 
        {
            return QtdKwGasto * 0.4487;
        }

        public override string ToString()
        {
            return $"Data Leitura: {DataLeitura.ToShortDateString()} NºLeitura: {NumeroLeitura} Kw gasto {QtdKwGasto} Valor: {ValorPagar:F2}";
        }
    }
}
