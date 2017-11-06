using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public  class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Categoria Categoria { get; set; }
    }
}
