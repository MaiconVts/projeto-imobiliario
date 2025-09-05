<p align="center">
  <img src="[URL_PARA_SEU_LOGO_OU_BANNER]" alt="Vitrine Imóveis" width="400"/>
</p>

# Vitrine Imóveis
*Portal Imobiliário Moderno para **[Nome da Imobiliária Cliente]***

<p align="center">
  <img src="https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow" alt="Status do Projeto">
  <img src="https://img.shields.io/badge/Licen%C3%A7a-Propriet%C3%A1rio-blue" alt="Licença">
  <img src="https://img.shields.io/badge/Backend-ASP.NET%20Core-blueviolet" alt="Backend">
  <img src="https://img.shields.io/badge/Frontend-Bootstrap%205-purple" alt="Frontend">
  <img src="https://img.shields.io/badge/Database-PostgreSQL-blue" alt="Banco de Dados">
</p>

<p align="center">
  <a href="#-descrição-do-projeto">Descrição</a> •
  <a href="#-funcionalidades-principais">Funcionalidades</a> •
  <a href="#-tecnologias-utilizadas">Tecnologias</a> •
  <a href="#-equipe-e-cliente">Equipe</a> •
  <a href="#-ambiente-de-demonstração">Acesso</a> •
  <a href="#-como-executar-localmente">Execução</a> •
  <a href="#-documentação-completa">Documentação</a>
</p>

---

## 🚀 Descrição do Projeto

O projeto **Vitrine Imóveis** é uma plataforma web de alta performance desenvolvida para o mercado imobiliário, servindo como uma vitrine digital para apresentação de imóveis e uma poderosa ferramenta de captação de leads. A aplicação oferece uma solução prática e profissional para que imobiliárias gerenciem seu portfólio de forma autônoma, enquanto proporciona aos potenciais compradores e inquilinos uma experiência de busca intuitiva, agradável e eficiente.

Com foco na usabilidade e na apresentação de qualidade, o sistema permite que a imobiliária fortaleça sua marca, otimize seu processo de vendas e construa um relacionamento direto com seu público. Para o usuário final, a plataforma simplifica a jornada de encontrar um novo lar, oferecendo ferramentas de busca avançada, informações claras e um canal de comunicação direto e confiável com os corretores.

## ✨ Funcionalidades Principais

* **🔍 Busca Avançada e Filtros Inteligentes:** Ferramentas intuitivas para que os usuários encontrem imóveis por localidade, preço, tipo, características e muito mais.
* **🏡 Vitrine de Imóveis Detalhada:** Páginas dedicadas para cada imóvel com galerias de fotos de alta resolução, mapas de localização interativos e descrições completas.
* **🖥️ Painel de Controle Autônomo:** Uma área administrativa segura e de fácil uso para que a equipe da imobiliária possa gerenciar todo o ciclo de vida dos anúncios (CRUD) sem necessidade de suporte técnico.
* **📱 Design Totalmente Responsivo:** Experiência de usuário otimizada para desktops, tablets e smartphones, seguindo a abordagem *Mobile-First*.
* **📧 Geração de Leads Integrada:** Formulários de contato diretos que conectam potenciais clientes à equipe de corretores de forma rápida e eficiente.
* **🎨 Tema Personalizável:** Opção de modo claro e escuro para uma experiência de visualização mais confortável para o usuário.

## 🛠️ Tecnologias Utilizadas

Este projeto foi construído utilizando as tecnologias mais modernas e robustas do ecossistema .NET, garantindo performance, segurança e escalabilidade.

| Categoria | Tecnologia |
| :--- | :--- |
| **Backend** | C#, ASP.NET Core 8 (MVC), Entity Framework Core 8 |
| **Frontend** | HTML5, CSS3, JavaScript, Bootstrap 5 |
| **Banco de Dados**| PostgreSQL (Gerenciado via Supabase) |
| **Hospedagem** | Microsoft Azure App Service, Supabase |
| **Ferramentas** | Visual Studio 2022, Git, GitHub Actions (CI/CD) |

## 👥 Equipe e Cliente

### Equipe de Desenvolvimento
* **[Maicon Vitor Theodoro da Silva]** - *Desenvolvedor Full-Stack (Foco em Backend)* - [GitHub](https://github.com/MaiconVts])
* **[Maicon Vitor Theodoro da Silva]** - *Desenvolvedor Full-Stack (Foco em Frontend)* - [GitHub](https://github.com/MaiconVts)

### Cliente
* **[Nome da Imobiliária ou do Contato Principal no Cliente]**

## 🌐 Ambiente de Demonstração

A aplicação está disponível para testes e demonstração no ambiente abaixo.

* **URL da Aplicação:** `https://[URL-DA-SUA-APLICACAO].azurewebsites.net/`
* **Status:** Em Desenvolvimento

#### Credenciais de Teste (Painel Administrativo)
* **Login:** `admin@imobiliaria.com`
* **Senha:** `Admin@2025`

## 🚀 Como Executar o Projeto (Localmente)

Siga os passos abaixo para configurar e executar o projeto em seu ambiente de desenvolvimento local.

1.  **Pré-requisitos:**
    * [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
    * [Git](https://git-scm.com/)
    * Uma instância de PostgreSQL (você pode usar o Docker ou um serviço como o Supabase).

2.  **Clonar o Repositório:**
    ```bash
    git clone [https://github.com/](https://github.com/)[SEU-USUARIO]/[SEU-REPOSITORIO].git
    cd [SEU-REPOSITORIO]
    ```

3.  **Configurar a Conexão com o Banco de Dados:**
    * Renomeie o arquivo `appsettings.Development.example.json` para `appsettings.Development.json`.
    * Abra o arquivo e insira a sua *connection string* do PostgreSQL.

4.  **Executar a Aplicação:**
    ```bash
    # Restaura as dependências do projeto
    dotnet restore

    # Aplica as migrations para criar o banco de dados
    dotnet ef database update

    # Inicia a aplicação
    dotnet run
    ```
5.  Acesse `http://localhost:5000` (ou a porta informada no terminal) no seu navegador.

## 📚 Documentação Completa

Toda a concepção, planejamento e arquitetura do projeto estão detalhados nos documentos abaixo.

<ol>
    <li><a href="docs/01-Documentação de Contexto.md"> Documentação de Contexto</a></li>
    <li><a href="docs/02-Especificação do Projeto.md"> Especificação do Projeto</a></li>
    <li><a href="docs/03-Metodologia.md"> Metodologia</a></li>
    <li><a href="docs/04-Projeto de Interface.md"> Projeto de Interface</a></li>
    <li><a href="docs/05-Arquitetura da Solução.md"> Arquitetura da Solução</a></li>
    <li><a href="docs/06-Template Padrão da Aplicação.md"> Template Padrão da Aplicação</a></li>
    <li><a href="docs/07-Programação de Funcionalidades.md"> Programação de Funcionalidades</a></li>
    <li><a href="docs/08-Plano de Testes de Software.md"> Plano de Testes de Software</a></li>
    <li><a href="docs/09-Registro de Testes de Software.md"> Registro de Testes de Software</a></li>
    <li><a href="docs/10-Plano de Testes de Usabilidade.md"> Plano de Testes de Usabilidade</a></li>
    <li><a href="docs/11-Registro de Testes de Usabilidade.md"> Registro de Testes de Usabilidade</a></li>
    <li><a href="docs/12-Apresentação do Projeto.md"> Apresentação do Projeto</a></li>
    <li><a href="docs/13-Referências.md"> Referências</a></li>
</ol>

## 📂 Código Fonte

<ul>
    <li><a href="src/README.md"> Acessar o Código Fonte da Aplicação</a></li>
</ul>

## 🎬 Apresentação

<ul>
    <li><a href="docs/12-Apresentação do Projeto.md"> Ver a Apresentação do Projeto</a></li>
</ul>