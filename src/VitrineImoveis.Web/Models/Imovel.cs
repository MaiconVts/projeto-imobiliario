// Local: VitrineImoveis.Web/Models/TipoImovel.cs

using System.ComponentModel.DataAnnotations; // precisamos disso para usar [Key] e [Required]
using System.ComponentModel.DataAnnotations.Schema; // precisamos disso para usar [ForeignKey] e [Column]

namespace VitrineImoveis.Web.Models
{
    // Este 'Enum' cria um tipo de dado customizado para o Status do Imóvel.
    // O C# vai guardar isso como um número (0, 1, 2, 3), mas para nós no código,
    // Podemos usar nomes, o que é muito mais legível.
    public enum StatusImovel { Disponivel, Reservado, Vendido, Alugado }

    public class Imovel
    {
        // --- Parte 1: Dados pricipais do imóvel ---
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string? CodigoReferencia { get; set; }

        [Required(ErrorMessage = "O título do imóvel é obrigatório.")]
        [StringLength(200)]
        public string Titulo { get; set; } = null!;

        public string? Descricao { get; set; }

        // [Column(TypeName = "...")] define o tipo exato do campo no banco de dados.
        [Column(TypeName = "decimal(12, 2)")] // 12 digitos no total, 2 deles depois da vírgula
        public decimal? PrecoVenda { get; set; } // preço de venda (opcional)

        [Column(typeName = "decimal(12, 2)")]
        public decimal? PrecoAluguel { get; set; } // preço de aluguel (opcional)

        [Required]
        public StatusImovel Status { get; set; } = StatusImovel.Disponivel; // Status do imóvel, padrão é Disponivel

        // --- Parte 2: Caracteristicas e detalhes ---
        [Required]
        public int Quartos { get; set; }

        public int Suites { get; set; } = 0;

        [Required]
        public int Banheiros { get; set; }

        public int VagasGaragem { get; set; } = 0;

        [Required]
        public int AreaTotal { get; set; } // em metros quadrados

        // --- Parte 3: localização ---
        [Strinlength(200, ErrorMessage = "O logradouro pode ter no máximo 200 caracteres.")]
        public string? Logradouro { get; set; } // Rua, Avenida, etc.

        [StringLength(20, ErrorMessage = "O número pode ter no máximo 20 caracteres.")]
        public string? Numero { get; set; } // Número da casa, apto, etc.

        [StringLength(100, ErrorMessage = "O Bairro pode ter no máximo 100 caracteres.")]
        public string? Bairro { get; set; } // Bairro, condomínio, etc.

        [StringLength(100, ErrorMessage = "A cidade pode ter no máximo 100 caracteres.")]
        public string? Cidade { get; set; } // Cidade

        [StringLength(2, ErrorMessage = "O estado der ter no máximo 2 caracteres(sigla).")]
        public string? Estado { get; set; } // Estado (sigla, ex: SP, RJ, MG)

        [StringLength(9, ErrorMessage = "O CEP deve ter o formato XXXXX-XXX")]
        public string? CEP { get; set; } // CEP

        // Campos para armazenas as coordenadas geográficas do imóvel no mapa
        // Serão preenchidas automaticamento pelo nosso sistema backend.
        public double? Latitude { get; set; } // Latitude do imóvel (opcional)
        public double? Longitude { get; set; } // Longitude do imóvel (opcional)
    }
}