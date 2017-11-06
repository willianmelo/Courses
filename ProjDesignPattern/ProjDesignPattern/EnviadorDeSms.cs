using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public class EnviadorDeSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.Write("Enviando por SMS");
        }
    }
}
