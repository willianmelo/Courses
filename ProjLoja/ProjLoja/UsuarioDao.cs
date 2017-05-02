using ProjLoja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoja
{
    public class UsuarioDao
    {
        private EntidadeContext contexto;

        public UsuarioDao()
        {
            contexto = new EntidadeContext();
        }
        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
             return contexto.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

    }
}
