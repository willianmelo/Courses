using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSolucaobancaria.Interfaces
{
    interface Resposta
    {
        void Responde(Requisicao req, Conta conta);
        Resposta Proxima { get; set; }
    }
}
