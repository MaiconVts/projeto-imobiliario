# Arquitetura da Solução

**Pré-requisitos:** [Projeto de Interface](./3-Projeto-de-Interface.md)

Esta seção define como o software é estruturado em termos de seus componentes lógicos, modelo de dados e o ambiente tecnológico de hospedagem. A arquitetura foi projetada para ser robusta, escalável e de fácil manutenção, utilizando a stack de tecnologia previamente definida.

## Diagrama de Classes

O diagrama de classes a seguir descreve a estrutura das classes de modelo (Models) no projeto ASP.NET Core MVC. Estas classes representam as entidades do domínio do negócio e são a base para a criação das tabelas no banco de dados via Entity Framework Core.

*(Ferramenta recomendada para visualização: Lucidchart)*

* **`Imovel`**
    * **Propriedades:** `int Id`, `string Titulo`, `string Descricao`, `decimal Preco`, `int Quartos`, `int Banheiros`, `int VagasGaragem`, `int AreaTotal`, `string Endereco`, `DateTime DataCadastro`
    * **Propriedades de Navegação:** `int TipoImovelId`, `virtual TipoImovel TipoImovel`, `int FinalidadeId`, `virtual Finalidade Finalidade`, `virtual ICollection<Foto> Fotos`, `virtual ICollection<ImovelCaracteristica> ImovelCaracteristicas`
    * **Relacionamentos:** Possui 1 `TipoImovel`, 1 `Finalidade` e Muitas `Fotos`. A relação com `Caracteristica` é N-para-N, intermediada pela classe `ImovelCaracteristica`.

* **`Foto`**
    * **Propriedades:** `int Id`, `string UrlImagem`, `bool IsPrincipal`
    * **Propriedades de Navegação:** `int ImovelId`, `virtual Imovel Imovel`
    * **Relacionamentos:** Pertence a 1 `Imovel`.

* **`TipoImovel`** (Ex: Casa, Apartamento)
    * **Propriedades:** `int Id`, `string Nome`
    * **Relacionamentos:** Pode estar associado a Muitos `Imoveis`.

* **`Finalidade`** (Ex: Venda, Aluguel)
    * **Propriedades:** `int Id`, `string Nome`
    * **Relacionamentos:** Pode estar associada a Muitas `Finalidades`.

* **`Caracteristica`** (Ex: Piscina, Churrasqueira)
    * **Propriedades:** `int Id`, `string Nome`
    * **Relacionamentos:** Pode estar associada a Muitos `Imoveis` através de `ImovelCaracteristica`.

* **`ImovelCaracteristica`** (Classe de Junção)
    * **Propriedades:** `int ImovelId`, `int CaracteristicaId`
    * **Propriedades de Navegação:** `virtual Imovel Imovel`, `virtual Caracteristica Caracteristica`
    * **Relacionamentos:** Conecta 1 `Imovel` a 1 `Caracteristica`.

* **`UsuarioAdmin`**
    * **Propriedades:** `string Id`, `string Nome`, `string Email` (Herda de `IdentityUser` do ASP.NET Core Identity).

## Modelo ER (Projeto Conceitual)

O Modelo Entidade-Relacionamento (ER) traduz a estrutura de classes para um nível conceitual de dados, representando as entidades e como elas se relacionam.

*(Ferramenta recomendada para visualização: LucidChart, Draw.io)*

* **Entidades:**
    * `IMOVEL`
    * `FOTO`
    * `TIPO_IMOVEL`
    * `FINALIDADE`
    * `CARACTERISTICA`
    * `USUARIO_ADMIN`

* **Relacionamentos:**
    * `TIPO_IMOVEL` (1) --- (N) `IMOVEL` : Um tipo de imóvel pode estar em muitos imóveis.
    * `FINALIDADE` (1) --- (N) `IMOVEL` : Uma finalidade pode estar em muitos imóveis.
    * `IMOVEL` (1) --- (N) `FOTO` : Um imóvel pode ter muitas fotos.
    * `IMOVEL` (N) --- (N) `CARACTERISTICA` : Um imóvel pode ter muitas características, e uma característica pode estar em muitos imóveis. Este relacionamento é resolvido pela entidade associativa `IMOVEL_CARACTERISTICA`.

## Projeto da Base de Dados

A seguir, a representação física do Modelo ER em tabelas do PostgreSQL, que será gerenciado pelo Entity Framework Core (Code-First).

| Tabela: **TiposImovel** | | |
| :--- | :--- | :--- |
| **Nome da Coluna** | **Tipo de Dado (PostgreSQL)** | **Restrições** |
| `Id` | `SERIAL` | `PRIMARY KEY` |
| `Nome` | `VARCHAR(50)` | `UNIQUE, NOT NULL`|

| Tabela: **Finalidades** | | |
| :--- | :--- | :--- |
| **Nome da Coluna** | **Tipo de Dado (PostgreSQL)** | **Restrições** |
| `Id` | `SERIAL` | `PRIMARY KEY` |
| `Nome` | `VARCHAR(50)` | `UNIQUE, NOT NULL`|

| Tabela: **Caracteristicas** | | |
| :--- | :--- | :--- |
| **Nome da Coluna** | **Tipo de Dado (PostgreSQL)** | **Restrições** |
| `Id` | `SERIAL` | `PRIMARY KEY` |
| `Nome` | `VARCHAR(100)` | `UNIQUE, NOT NULL`|

| Tabela: **Imoveis** | | |
| :--- | :--- | :--- |
| **Nome da Coluna** | **Tipo de Dado (PostgreSQL)** | **Restrições** |
| `Id` | `SERIAL` | `PRIMARY KEY` |
| `Titulo` | `VARCHAR(200)` | `NOT NULL` |
| `Descricao` | `TEXT` | |
| `Preco` | `DECIMAL(12, 2)` | `NOT NULL` |
| `Quartos` | `INTEGER` | `NOT NULL` |
| `Banheiros` | `INTEGER` | `NOT NULL` |
| `VagasGaragem` | `INTEGER` | `NOT NULL` |
| `AreaTotal` | `INTEGER` | `NOT NULL` |
| `Endereco` | `VARCHAR(255)`| |
| `DataCadastro` | `TIMESTAMP` | `DEFAULT now()` |
| `TipoImovelId`| `INTEGER` | `FOREIGN KEY (TiposImovel.Id)` |
| `FinalidadeId`| `INTEGER` | `FOREIGN KEY (Finalidades.Id)` |

| Tabela: **Fotos** | | |
| :--- | :--- | :--- |
| **Nome da Coluna** | **Tipo de Dado (PostgreSQL)** | **Restrições** |
| `Id` | `SERIAL` | `PRIMARY KEY` |
| `UrlImagem` | `VARCHAR(255)` | `NOT NULL` |
| `IsPrincipal` | `BOOLEAN` | `DEFAULT false` |
| `ImovelId` | `INTEGER` | `FOREIGN KEY (Imoveis.Id)` |

| Tabela: **ImoveisCaracteristicas** (Tabela de Junção) | | |
| :--- | :--- | :--- |
| **Nome da Coluna** | **Tipo de Dado (PostgreSQL)** | **Restrições** |
| `ImovelId` | `INTEGER` | `FOREIGN KEY (Imoveis.Id)` |
| `CaracteristicaId`| `INTEGER` | `FOREIGN KEY (Caracteristicas.Id)` |
| | | `PRIMARY KEY (ImovelId, CaracteristicaId)` |

*(As tabelas de `UsuarioAdmin`, como `AspNetUsers`, serão gerenciadas automaticamente pelo ASP.NET Core Identity).*

## Tecnologias Utilizadas

| Categoria | Tecnologia/Ferramenta |
| :--- | :--- |
| **Backend** | C#, ASP.NET Core 8 (MVC), Entity Framework Core 8 |
| **Frontend** | HTML5, CSS3, JavaScript, Bootstrap 5 |
| **Banco de Dados**| PostgreSQL 16 (via Supabase) |
| **IDE** | Visual Studio 2022 |
| **Controle de Versão**| Git & GitHub |
| **Design e Prototipagem** | Figma |

### Fluxo da Arquitetura em uma Requisição

O diagrama textual abaixo ilustra o ciclo de vida de uma requisição do usuário até a resposta do sistema:

1.  **Usuário**: Interage com o **Navegador Web** e clica em um imóvel.
2.  **Navegador**: Envia uma requisição `HTTP GET` para o servidor (ex: `/imoveis/detalhes/1`).
3.  **Servidor de Hospedagem (PaaS)**: Recebe a requisição e a encaminha para a aplicação ASP.NET Core.
4.  **ASP.NET Core (Middleware de Roteamento)**: Analisa a URL e direciona a requisição para a `Action` `Detalhes` do `ImoveisController`.
5.  **`ImoveisController`**: Executa a lógica da aplicação, solicitando os dados do imóvel ao próximo nível.
6.  **Entity Framework Core (`DbContext`)**: Recebe a solicitação do Controller, traduz uma consulta C# (LINQ) para uma instrução SQL otimizada.
7.  **Banco de Dados (PostgreSQL no Supabase)**: O EF Core envia a instrução SQL. O banco de dados executa a consulta e retorna os dados do imóvel correspondente.
8.  **Mapeamento**: O EF Core recebe os dados tabulares e os mapeia para um objeto C# (`Imovel`).
9.  **Renderização da View**: O Controller recebe o objeto `Imovel` e o passa para a `View Razor` (`Detalhes.cshtml`). O motor Razor processa o arquivo, mesclando o modelo de dados com o HTML.
10. **Resposta HTTP**: O servidor envia a página HTML completa de volta para o Navegador.
11. **Renderização no Cliente**: O Navegador renderiza o HTML, aplica o CSS (Bootstrap) e executa o JavaScript, exibindo a página final para o usuário.

## Hospedagem

A implantação da aplicação seguirá um modelo moderno baseado em serviços de nuvem (Platform as a Service - PaaS), que abstrai a complexidade de gerenciamento de infraestrutura.

* **Aplicação Web (ASP.NET Core):** A aplicação será hospedada em um serviço de PaaS com suporte nativo a .NET, como o **Microsoft Azure App Service** ou **Heroku**. Esses serviços gerenciam o servidor web, o sistema operacional e o runtime, permitindo um deploy simplificado e escalável.
* **Banco de Dados (PostgreSQL):** O banco de dados será provisionado e gerenciado pela plataforma **Supabase**. Isso garante um banco de dados seguro, com backups automáticos e escalabilidade, conectado à aplicação web através de uma *connection string* segura.
* **Processo de Lançamento (Deploy):** O deploy será automatizado via **CI/CD (Integração e Implantação Contínuas)** com **GitHub Actions**. Um workflow será configurado para que, a cada `push` na branch `main`, o código seja compilado, testado e publicado automaticamente no serviço de hospedagem (ex: Azure App Service), garantindo entregas rápidas e confiáveis.