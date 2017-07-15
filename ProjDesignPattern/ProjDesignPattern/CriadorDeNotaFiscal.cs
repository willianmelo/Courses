using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public double valorTotal { get; set; }
        public double imposto { get; set; }
        public string Observacoes { get; set; }
        public DateTime Data { get; set; }
        IList<ItemNota> todosItens = new List<ItemNota>();

        public NotaFiscalBuilder()
        {
            this.Data = DateTime.Now;
        }


        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NadataAtual(DateTime novaData)
        {
            Data = novaData;
            return this;

        }

        public NotaFiscalBuilder comItem(ItemNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            imposto = valorTotal * 0.05;
            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, Observacoes, valorTotal, imposto, todosItens);
        }
    }
}




