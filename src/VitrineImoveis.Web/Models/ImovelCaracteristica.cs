// Local: VitrineImoveis.Web/Models/TipoImovel.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitrineImoveis.Web.Models
{
    // Esta classe repesenta a TABELA DE JUNÇÃO para o relacionamento N:N
    // entre Imovel e Caracteristica. Ela não tem um 'Id' proprio.
    // Sua chave primaria é composta por ImovelId e CaracteristicaId
    public class ImovelCaracteristica
    {
        // Chave estrangeira para Imovel
        [ForeigenKey("Imovel")]
        public int ImovelId { get; set; }
        public Imovel Imovel { get; set; } = null!; // Propriedade de navegação para Imovel

        // Chave estrangeira para Caracteristica
        [ForeigenKey("Caracteristica")]
        public int CaracteristicaId { get; set; }
        public Caracteristica Caracteristica { get; set; } = null!; // Propriedade de navegação para Caracteristica
    }
}