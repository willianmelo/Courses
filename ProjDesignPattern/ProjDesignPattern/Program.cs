using ProjDesignPattern.Interface;
using System;

namespace ProjDesignPattern
{
    class Program
    {
        static void Main(String[] args)
        {
            Imposto iss = new ISS(new ICMS(new IKCV()));
            Orcamento orcamento = new Orcamento(500);
            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}