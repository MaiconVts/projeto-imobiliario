# Programação de Funcionalidades

**Pré-requisitos:** [Documentação de Especificação](./1-Documentação-de-Contexto.md), [Projeto de Interface](./3-Projeto-de-Interface.md), [Metodologia](./2-Gerenciamento-e-Metodologia.md), [Arquitetura da Solução](./4-Arquitetura-da-Solução.md)

Nesta seção, detalhamos a implementação do sistema por meio dos requisitos funcionais definidos. O objetivo é estabelecer uma ligação clara entre cada requisito, os artefatos de código-fonte que serão produzidos para atendê-lo e o membro da equipe responsável pelo seu desenvolvimento.

### Tecnologias e Padrões de Desenvolvimento

Conforme definido na arquitetura, a implementação seguirá estritamente as tecnologias e os padrões aprovados para o projeto, em conformidade com as restrições estabelecidas.

**Tecnologias Utilizadas:**
* **IDE de Desenvolvimento:** Microsoft Visual Studio 2022
* **Backend:** C# 12 com o framework ASP.NET Core 8 (padrão MVC)
* **Frontend:** HTML5, CSS3, JavaScript e o framework responsivo Bootstrap 5
* **Base de Dados:** PostgreSQL (gerenciado via Supabase e acessado com Entity Framework Core 8)
* **Controle de Versão e Documentação:** Git e GitHub

**Restrições:**
* **NÃO** serão utilizados templates baseados em frameworks JavaScript como React, Angular ou Vue.
* A linguagem de programação para o backend será **exclusivamente C#**.

### Tabela de Implementação de Requisitos

A tabela a seguir detalha o plano de desenvolvimento para cada requisito funcional, associando-o aos artefatos de código e aos desenvolvedores responsáveis.

| ID | Descrição do Requisito | Artefatos Produzidos (Código-Fonte) | Desenvolvedor(a) Responsável |
| :--- | :--- | :--- | :--- |
| **RF-01** | **Gestão de Imóveis (Admin):** O administrador pode incluir, editar, excluir e visualizar todos os imóveis através de um painel seguro. | `- Models/Imovel.cs` <br> `- Data/ApplicationDbContext.cs` <br> `- Controllers/ImoveisAdminController.cs` <br> `- Views/ImoveisAdmin/Index.cshtml` <br> `- Views/ImoveisAdmin/Create.cshtml` <br> `- Views/ImoveisAdmin/Edit.cshtml` <br> `- Views/ImoveisAdmin/Delete.cshtml` | Desenvolvedor A (Backend) |
| **RF-02** | **Listagem Pública de Imóveis:** O sistema deve exibir todos os imóveis ativos em uma página pública. | `- Controllers/ImoveisController.cs` (Action `Index`) <br> `- Views/Imoveis/Index.cshtml` <br> `- Views/Shared/_ImovelCard.cshtml` (Partial View) | Desenvolvedor B (Frontend) |
| **RF-03** | **Busca Avançada e Filtros:** O usuário pode buscar imóveis por texto e filtrar por tipo, finalidade, preço, quartos, etc. | `- Lógica de consulta no `ImoveisController.cs` <br> `- ViewModels/FiltroViewModel.cs` <br> `- wwwroot/js/filtros.js` (para interatividade sem recarregar a página) | Desenvolvedor A (Backend) |
| **RF-04** | **Página de Detalhes do Imóvel:** Cada imóvel deve ter uma página própria com galeria de fotos, descrição, ficha técnica, etc. | `- Controllers/ImoveisController.cs` (Action `Detalhes`) <br> `- Views/Imoveis/Detalhes.cshtml` | Desenvolvedor B (Frontend) |
| **RF-05** | **Formulário de Contato (Leads):** O usuário pode enviar uma mensagem de interesse a partir da página de detalhes do imóvel. | `- ViewModels/ContatoViewModel.cs` <br> `- Lógica de envio no `ImoveisController.cs` <br> `- Services/IEmailSender.cs` (Interface para serviço de e-mail) | Desenvolvedor A (Backend) |
| **RF-06** | **Autenticação de Administrador:** O sistema deve ter uma área de login segura para acesso ao painel de gerenciamento. | `- Configuração do ASP.NET Core Identity` <br> `- Areas/Identity/Pages/Account/Login.cshtml` <br> `- Atributo `[Authorize]` nos Controllers administrativos | Desenvolvedor A (Backend) |
| **RF-07** | **Integração com Mapa de Localização:** A página de detalhes deve exibir um mapa interativo com a localização do imóvel. | `- wwwroot/js/mapa.js` (utilizando Leaflet.js com OpenStreetMap) <br> `- Integração do script na `Views/Imoveis/Detalhes.cshtml` | Desenvolvedor B (Frontend) |
| **RF-08** | **Personalização do Tema (Modo Escuro):** Permitir ao usuário alternar entre um tema claro e um escuro. | `- wwwroot/css/dark-theme.css` <br> `- wwwroot/js/theme-switcher.js` <br> `- Lógica de toggle no `_Layout.cshtml` | Desenvolvedor B (Frontend) |
| **RF-09** | **Suporte a Múltiplos Idiomas:** O sistema deve permitir a tradução da interface para outros idiomas. | `- Configuração de `Localization` no `Program.cs` <br> `- Criação de arquivos de recurso (`.resx`) para os textos da interface | Desenvolvedor A (Backend) |
| **RF-10** | **Recursos de Acessibilidade:** O site deve ser compatível com leitores de tela e navegação por teclado. | `- Implementação de atributos ARIA e HTML semântico em todos os arquivos `.cshtml` <br> `- Testes de navegação via teclado | Desenvolvedor B (Frontend) |
| **RF-11** | **Homepage com Destaques:** A página inicial deve exibir uma seleção de imóveis em destaque. | `- Controllers/HomeController.cs` (Action `Index`) <br> `- Lógica para buscar imóveis em destaque <br> `- Views/Home/Index.cshtml` | Desenvolvedor A (Backend) |
| **RF-12** | **Design Responsivo:** A interface deve se adaptar e ser totalmente funcional em todos os dispositivos. | `- Utilização do Grid System do Bootstrap 5 em todos os arquivos `.cshtml` <br> `- Testes em diferentes resoluções de tela | Desenvolvedor B (Frontend) |


## Instruções de Acesso e Verificação

A aplicação funcional estará disponível para acesso e verificação no ambiente de hospedagem a partir da Etapa 03 do cronograma do projeto.

* **URL da Aplicação:** `https://[URL-DA-SUA-APLICACAO].azurewebsites.net/`
* **URL do Painel Administrativo:** `https://[URL-DA-SUA-APLICACAO].azurewebsites.net/ImoveisAdmin`

* **Usuário de Teste (Admin):**
    * **Login:** `admin@imobiliaria.com`
    * **Senha:** `Admin@2025`

**Nota:** Os links e credenciais acima são exemplos e serão substituídos pelos dados de produção assim que o ambiente de hospedagem for configurado.