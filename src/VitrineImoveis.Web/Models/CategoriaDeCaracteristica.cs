// Local: VitrineImoveis.Web/Models/TipoImovel.cs

using System.ComponentModel.DataAnnotations; // precisamos disso para usar [Key] e [Required]

namespace VitrineImoveis.Web.Models
{
    // Tabela para agrupar caracteristicas Ex: Lazer, Segurança, Acabamentos etc.
    public class CategoriaDeCaracteristica
    {
        [Key] // Esta etiqueta diz ao entity framework que Id é a chave primaria da tabela (PK)
        public int Id { get; set; } // Chave primaria

        [Required] // Esta etiqueta diz ao entity framework que Nome é obrigatorio (NOT NULL)
        [StringLength(100)] // Define o tamanho máximo do texto (VARCHAR(100)) no BD
        public string Nome { get; set; } = null!; // O = null! é para evitar o aviso de que a propriedade pode ser nula (nullable)
    }
}