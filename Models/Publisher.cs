using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    // criando uma tabela
    [Table("Publishers")]
    public class Publisher
    {
        // criando entidade
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        // colocando um nome na tabela
        [Column("Publisher_Name")]
        public string? Name { get; set; }

        [MaxLength(50), MinLength(4)]
        public string? Site { get; set; }


        
    }
}
