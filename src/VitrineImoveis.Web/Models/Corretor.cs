// Local: VitrineImoveis.Web/Models/TipoImovel.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitrineImoveis.Web.Models
{
    // Esta classe será a tabela "Corretores" no banco de dados"
    public class Corretor
    {
        [Key]
        public int Id { get; set; } // Chave primaria

        [Required(ErrorMessage = "O nome do corretor é obrigatório.")]
        [StringLength(150)]
        public string Nome { get; set; } = null!; // Nome do corretor

        [Required(ErrorMessage = "O e-mail do corretor é obrigatório.")]
        [EmailAddress(ErrorMessage = "Por favor, insira um e-mail válido.")]
        public string Email { get; set; } = null!; // E-mail do corretor

        [StringLength(20)]
        public string? Telefone { get; set; } // Telefone do corretor (opcional) o "?" indica que a propriedade pode ser nula (nullable)

        [StringLength(20)]
        public string? Creci { get; set; } // Creci do corretor (opcional)

        public string? UrlFoto { get; set; } // URL da foto do corretor (opcional

        [StringLength(1000)]
        public string? Bio { get; set; } // Biografia do corretor (opcional)
    }
}