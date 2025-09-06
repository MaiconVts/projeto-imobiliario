using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public enum TipoPostInstagram { Imagem, Carrosel, Reel }
public class PostInstagram
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string UrlPost { get; set; } = null!;
    [Required]
    public string UrlImagemCapa { get; set; } = null!;
    [StringLength(255)]
    public string? Descricao { get; set; }
    [Required]
    public TipoPostInstagram TipoPost { get; set; }
    public bool IsDestaque { get; set; } = false; // o Botão de ênfase
    public int OrdemExibicao { get; set; } = 0; // Para controle da ordem de exibição no front-end
}