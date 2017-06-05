using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSolucaobancaria
{
    class Conta
    {
        public String Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
        enum Formato { XML, CSV, PORCENTO }
    }
}
