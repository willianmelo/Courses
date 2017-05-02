using Microsoft.Data.Entity;
using ProjLoja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoja
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadeContext contexto = new EntidadeContext();
            var categoria = contexto.Categorias.FirstOrDefault(x=> x.ID == 1);

            Console.ReadLine();
            
        }
    }
}

