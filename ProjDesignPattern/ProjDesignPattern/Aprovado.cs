using ProjDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public  class Aprovado : EstadoDeUmOrcamento
    {

        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
                throw new Exception("Desconto ja aplicado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta em aprovacao");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento esta em aprovado, nao pode ser reprovado agora");
        }
    }
}
