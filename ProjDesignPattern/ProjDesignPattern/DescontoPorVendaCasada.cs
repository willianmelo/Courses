using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get ; set; }

        public double Calcula(Orcamento orcamento)
        {
            if (aconteceuVendaCasadaEm(orcamento))
                return orcamento.Valor * 0.05;
            else
                return Proximo.Calcula(orcamento);

        }

        private bool existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }
            return false;
        }

        private bool aconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
        }
    }
}
