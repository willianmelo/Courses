using System;
using System.Collections.Generic;

namespace ProjDesignPattern
{
    class Program
    {
        static void Main(String[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador.ParaEmpresa("Teste Willian Ltda.")
                   .ComCnpj("23.456.789/0001-12")
                   .comItem(new ItemNota("item 1", 100.00))
                   .comItem(new ItemNota("item 2", 200.00))
                   .NadataAtual(DateTime.Now)
                   .ComObservacoes("obs");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new NotaFiscalDao());
            criador.AdicionaAcao(new EnviadorDeSms());

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();
        }
    }
}