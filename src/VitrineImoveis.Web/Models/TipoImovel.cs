// Local: VitrineImoveis.Web/Models/TipoImovel.cs

using System.ComponentModel.DataAnnotations; // precisamos disso para usar [Key] e [Required]

namespace VitrineImoveis.Web.Models
{
    // Esta classe sera traduzida em uma tabela chamada TipoImovel no banco de dados.
    public class TipoImovel
    {
        [Key] // Esta etiqueta diz ao entity framework que Id é a chave primaria da tabela (PK)
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do tipo de imóvel é obrigatório.")] // Esta etiqueta diz ao entity framework que Nome é obrigatorio (NOT NULL)
        [StringLength(50)] // Define o tamanho máximo do texto (VARCHAR(50)) no BD
        public string Nome { get; set; } = null!; // O = null! é para evitar o aviso de que a propriedade pode ser nula (nullable)
    }
}