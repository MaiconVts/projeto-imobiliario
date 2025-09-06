using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public enum OrigemLead { FormularioContatoGeral, PaginaDeImovel, Outro }

public class Lead
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(150)]
    public string Nome { get; set; } = null!;
    [Required]
    [EmailAdress]
    public string Email { get; set; } = null!;
    [StringLength(20)]

    public string? Telefone { get; set; }
    public string? Mensagem { get; set; }

    public DateTime DataContato { get; set; } = DateTime.UtcNow;
    [Required]
    public OrigemLead Origem { get; set; } // Campo mantido para análise

    [ForeignKey("Imovel")]
    public int? ImovelId { get; set; } 
    public virtual Imovel? Imovel { get; set; }
}