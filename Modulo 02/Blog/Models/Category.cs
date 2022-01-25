using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Gerar Chave direto no banco como Identity
        public int Id { get; set; }

        [Required]// Gerar a tabela no banco com campo - NOT NULL
        [MinLength(3)] // Válida quantidade de caracteres nivel do código.
        [MaxLength(80)]// Válida quantidade de caracteres nivel do código.
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; }

        [Required]// Gerar a tabela no banco com campo - NOT NULL
        [MinLength(3)] // Válida quantidade de caracteres nivel do código.
        [MaxLength(80)]// Válida quantidade de caracteres nivel do código.
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }
}