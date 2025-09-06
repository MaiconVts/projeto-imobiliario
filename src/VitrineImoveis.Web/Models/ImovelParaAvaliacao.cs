using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ImovelParaAvaliacao
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(150)]
    public string NomeProprietario { get; set; } = null!;
    [Required]
    [EmailAddress]
    public string EmailProprietario { get; set; } = null!;
    [Required]
    [StringLength(20)]
    public string TelefoneProprietario { get; set; } = null!;
    [Required]
    public string EnderecoImovel { get; set; } = null!;
    public string? DescricaoImovel { get; set; }
    [Column(TypeName = "decimal(12,2)")]
    public decimal? PrecoSugerido { get; set; }
    public DateTime DataEnvio { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = "Novo"; // Status simples para controle interno
}