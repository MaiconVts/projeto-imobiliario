// Local: VitrineImoveis.Web/Models/TipoImovel.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitrineImoveis.Web.Models
{
    // Representa uma unica foto na galeria de um imóvel
    public class Foto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UrlImage { get; set; } = null!; // URL da imagem

        [StringLength(150, Errormessage = "O Texto alternativo deve ter no máximo 150 caracteres.")]
        public string? TextoAlternativo { get; set; } // Importante para SEO e acessibilidade

        // Para sabermos qual foto usar como capa no card do imóvel
        public bool IsPrincipal { get; set; } = false;

        // Para definirmos a ordem em que as fotos aparecem na galeria
        public int Ordem { get; set; } = 0;

        // --- Relacionamento: UMA foto pertence a UM imóvel ---
        [ForeignKey("Imovel")] // Diz qual propriedade é a FK (chave estrangeira)
        public int ImovelId { get; set; } // Propriedade que será a FK no banco de dados
        public virtual Imovel Imovel { get; set; } = null!; // Propriedade de navegação para acessar o imóvel associado a esta foto
    }
}