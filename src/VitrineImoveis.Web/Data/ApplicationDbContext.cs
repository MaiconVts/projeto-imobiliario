// Local: VitrineImoveis.web/Data/ApplicationDbContext.cs

// Precisei "importar" as bibliotecas que vamos usar, como o EntityFrameworkCore,
// e também o namespace onde estão nossas classes de Modelo.
using Microsoft.EntityFrameworkCore;
using VitrineImoveis.Web.Models;

namespace VitrineImoveis.Web.Data
{
    // Nossa classe "Herda" de 'DbContext', Isso significa que
    //  ela ganha todos os poderes da nossa classe base do Entity Framework Core.
    public class ApplicationDbContext : DbContext
    {
        // Este é o 'construtor' da nossa classe. É um método especial que é
        // executado sempre que um novo objeto 'ApplicationDbContext' é criado.
        // Ele serve para receber as configurações de conexão do nosso projeto.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // --- MAPEAMENTO DAS TABELAS ---
        // Cada propriedade 'DbSet<T>' aqui diz ao Entity Framework Core: "Ei, transoforme a classe 'T'
        // em uma tabela no banco de dados". O nome da propriedade será o nome da tabela.

        // Tabelas Principais e de Suporte
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Corretor> Corretores { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<TipoImovel> TiposImovel { get; set; }
        public DbSet<Finalidade> Finalidades { get; set; }
        public DbSet<Caracteristica> Caracteristicas { get; set; }
        public DbSet<CategoriaDeCaracteristica> CategoriaDeCaracteristicas { get; set; }

        // Tabela de Junção para o relacionamento N-N muitos-para-muitos
        public DbSet<ImovelCaracteristica> ImoveisCaracteristicas { get; set; }

        // Tabelas para as funcionalidades extras que planejamos implementar
        public DbSet<ImovelParaAvaliacao> ImoveisParaAvaliacao { get; set; }
        public DbSet<ParceiroFinanceiro> ParceirosFinanceiros { get; set; }
        public DbSet<PostInstagram> PostsInstagram { get; set; }
        public DbSet<Lead> Leads { get; set; }



        // --- CONFIGURAÇÕES AVANÇADAS DO MODELO ---
        // Este método especial nos permite dar intruções extras ao entity framework
        // sobre como ele deve criar o banco de dados e as tabelas.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Instruções especifica para a tabela de junção 'ImovelCaracteristica':
            // Estamos definindo que a chave primária dela é a COMBINAÇÃO das duas chaves estrangeiras.
            // Isso garante a integridade dos dados, impedindo que a mesma característica
            // seja adicionada duas vezes ao mesmo imóvel
            modelBuilder.Entity<ImovelCaracteristica>()
                .HasKey(ic => new { ic.ImovelId, ic.CaracteristicaId });
        }

    }
}