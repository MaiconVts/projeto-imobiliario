// Local: VitrineImoveis.Web/Models/TipoImovel.cs

using System.ComponentModel.DataAnnotations; // precisamos disso para usar [Key] e [Required]
using System.ComponentModel.DataAnnotations.Schema;

namespace VitrineImoveis.Web.Models
{
    public class Caracteristica
    {
        // Tabela para armazenar as caracteristicas dos imoveis Ex: Piscina, Churrasqueira, Portão Eletrônico etc.
        [Key] // Esta etiqueta diz ao entity framework que Id é a chave primaria da tabela (PK)
        public int Id { get; set; } // Chave primaria

        [Required] // Esta etiqueta diz ao entity framework que Nome é obrigatorio (NOT NULL)
        [StringLength(100)] // Define o tamanho máximo do texto (VARCHAR(100)) no BD
        public string Nome { get; set; } = null!; // O = null! é para evitar o aviso de que a propriedade pode ser nula (nullable)

        // --- Relacionamento: UMA Caracteristica PERTENCE A UMA Categoria ---

        // 1. A Chave estrangeira (FK) que será criada no banco de dados.
        [ForeignKey("CategoriaDeCaracteristica")] // Diz ao EF que esta propriedade é uma FK
        public int CategoriaId { get; set; } // Propriedade que será a FK no banco de dados

        // 2. a 'Propridade de navegação' é um atalho do C# que permite acessar a CategoriaDeCaracteristica associada a esta Caracteristica
        // A Palavra 'Virtual' ajuda o Entity Framework a carregar esta propriedade 'sob demanda' (lazy loading)
        public virtual CategoriaDeCaracteristica CategoriaDeCaracteristica { get; set; } = null!; // Propriedade de navegação para acessar a Categoria associada a esta Caracteristica
    }
}