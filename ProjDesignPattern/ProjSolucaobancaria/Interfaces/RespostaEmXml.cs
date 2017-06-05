using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSolucaobancaria.Interfaces
{
    class RespostaEmXml : Resposta
    {
        public Resposta Proxima { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Responde(Requisicao req, Conta conta)
        {
            throw new NotImplementedException();
        }
    }
}
