using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSolucaobancaria
{
    class Requisicao
    {
        public Formatos Formato { get; private set; }

        public Requisicao(Formatos formato)
        {
            this.Formato = formato;
        }
    }
}
