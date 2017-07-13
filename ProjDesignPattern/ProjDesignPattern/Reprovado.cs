using ProjDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados nao recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento esta reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento esta reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta reprovado");
        }
    }
}
