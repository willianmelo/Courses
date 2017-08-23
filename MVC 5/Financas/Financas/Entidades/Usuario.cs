using System.ComponentModel.DataAnnotations;

namespace Financas.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}