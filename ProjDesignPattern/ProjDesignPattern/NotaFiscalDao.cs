using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Salvo no banco");
        }
    }
}
