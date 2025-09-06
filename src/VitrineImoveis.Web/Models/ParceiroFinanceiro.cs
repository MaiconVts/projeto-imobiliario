using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class ParceiroFinanceiro
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string NomeBanco { get; set; } = null!;
    [Required]
    public string UrlLogo { get; set; } = null!;
    [Required]
    public string UrlSimulacao { get; set; } = null!;
    public bool IsAtivo { get; set; } = true; // Mantido para o Admin poder "desativar" um banco
    public int OrdemExibicao { get; set; } = 0; // Para controle da ordem de exibição no front-end
}