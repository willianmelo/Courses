using System;
using System.Collections.Generic;
using System.Text;
using ProjDesignPattern.Interface;
namespace ProjDesignPattern
{
    public class ICPP : TemplateDeImpostoCondicional
    {
  
        protected override bool  DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double  MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override double  MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }
    }
}
