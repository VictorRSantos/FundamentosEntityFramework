using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Gerar Chave direto no banco como Identity
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")] // Gerar Chave estrangeira
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("AuthorId")] // Gerar Chave estrangeira
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}