using ProjDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV() : base() { }
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemmaiorQue100Reais(orcamento);
        }


        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemmaiorQue100Reais(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }

    }
}
