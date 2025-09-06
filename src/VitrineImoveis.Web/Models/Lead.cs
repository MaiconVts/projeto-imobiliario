using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// CORREÇÃO 1: A palavra correta é 'namespace'
namespace VitrineImoveis.Web.Models
{
    public enum OrigemLead { FormularioContatoGeral, PaginaDeImovel, Outro }

    public class Lead
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(150)]
        public string Nome { get; set; } = null!;
        
        [Required]
        [EmailAddress] // CORREÇÃO 2: O correto é 'EmailAddress' com dois 'd'
        public string Email { get; set; } = null!;
        
        [StringLength(20)]
        public string? Telefone { get; set; }
        
        public string? Mensagem { get; set; }
        
        public DateTime DataContato { get; set; } = DateTime.UtcNow;
        
        [Required]
        public OrigemLead Origem { get; set; }

        [ForeignKey("Imovel")]
        public int? ImovelId { get; set; }
        public virtual Imovel? Imovel { get; set; }
    }
}