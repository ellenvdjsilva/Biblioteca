using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    [Table("Authors")]
    public class Author
    {
        // criando entidade
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        // colocando um nome na tabela
        [Column("Author_Name")]
        public string? Name { get; set; }

       
       
    }
}
