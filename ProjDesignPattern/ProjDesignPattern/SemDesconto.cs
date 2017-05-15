using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }

        public Double Desconta(Orcamento orcamento)
        {
            return 0;
        }

    }
}
