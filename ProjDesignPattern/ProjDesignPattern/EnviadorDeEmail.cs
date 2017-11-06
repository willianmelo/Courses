using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public class EnviadorDeEmail: AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("enviando por email");
        }
    }
}
