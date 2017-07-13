using System;
using System.Collections.Generic;
using System.Text;

namespace ProjDesignPattern.Interface
{
    public interface EstadoDeUmOrcamento
    {

        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);

    }
}
