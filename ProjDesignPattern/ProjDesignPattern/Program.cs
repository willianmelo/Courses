using System;

namespace ProjDesignPattern
{
    class Program
    {
        static void Main(String[] args)
        {
            Orcamento reforma = new Orcamento(500);

            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();
            Console.ReadKey();

        }
    }
}