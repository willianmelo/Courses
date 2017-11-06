using CRUD.DB;
using CRUD.Models;

namespace CRUD.DAO
{
    public class UsuarioDAO
    {
        public void Inserir(Usuario usu)
        {
            Contexto context = new Contexto();

            context.Usuarios.Add(usu);
            context.SaveChanges();

            context.Dispose();
        }
    }
}
