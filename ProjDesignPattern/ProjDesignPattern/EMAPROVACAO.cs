using ProjDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public  class EmAprovacao : EstadoDeUmOrcamento
    {

        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                descontoAplicado = true;
            }else
                throw new Exception("Desconto ja aplicado!");
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento nao pode sair de em aprovacao e ir para finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
