using System;
using System.Collections.Generic;

namespace ProjDesignPattern
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Observacoes { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemNota> Itens { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, string observacoes, double valorBruto, double impostos, IList<ItemNota> itens )
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataEmissao = dataEmissao;
            this.Observacoes = observacoes;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
        }

    }
}
