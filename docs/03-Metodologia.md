## Metodologia

A metodologia para condução do projeto será o **Scrum**. O trabalho será organizado em **Sprints de duas semanas**, um ciclo que permite focar em um conjunto de funcionalidades, iterar rapidamente e adaptar-se a novas demandas. Cada Sprint seguirá os rituais e utilizará os artefatos do Scrum para garantir alinhamento e progresso contínuo.

### Rituais (Cerimônias)

* **Sprint Planning (Planejamento):** Reunião realizada no início de cada Sprint com o objetivo de selecionar as tarefas de maior prioridade do *Product Backlog* e movê-las para o *Sprint Backlog*, que será o foco do ciclo de duas semanas.
* **Daily Scrum (Reuniões Diárias):** Reuniões rápidas (até 15 minutos) no início de cada dia para sincronizar o trabalho. Cada membro responde: O que fiz ontem? O que farei hoje? Há algum impedimento?
* **Sprint Review (Revisão):** Ao final da Sprint, a equipe apresenta as funcionalidades concluídas. O objetivo é demonstrar o incremento de software funcionando e coletar feedbacks para validar o trabalho entregue.
* **Sprint Retrospective (Retrospectiva):** Após a Review, a equipe se reúne para avaliar o processo de trabalho da Sprint que terminou, discutindo o que funcionou bem, o que pode ser melhorado e definindo ações concretas para a próxima Sprint.

### Artefatos

* **Product Backlog:** A lista completa e priorizada de todas as funcionalidades, requisitos, melhorias e correções desejadas para o projeto. É um artefato vivo, gerenciado como *Issues* no GitHub.
* **Sprint Backlog:** O conjunto de itens do *Product Backlog* selecionados para serem desenvolvidos durante uma Sprint.

## Controle de Versão

A ferramenta de controle de versão adotada é o **Git**, com o **GitHub** sendo utilizado para hospedagem do repositório central e colaboração.

### Estratégia de Branches

O projeto segue um fluxo baseado no GitFlow, com branches que representam diferentes estágios do desenvolvimento:

* **main:** Versão de produção. Contém o código estável que está em deploy. Só recebe merges da branch `release` ou `hotfix`.
* **develop:** Branch principal de desenvolvimento. Integra todas as funcionalidades concluídas e serve como base para novas features. É a versão mais atual do que será o próximo lançamento.
* **feature/`<nome-da-feature>`:** Branches criadas a partir da `develop`. Cada nova funcionalidade (ex: `feature/login-admin`) é desenvolvida em sua própria branch. Ao ser concluída, é mesclada de volta na `develop` via Pull Request.
* **release/`vX.X.X`:** Branch criada a partir da `develop` quando um conjunto de funcionalidades está pronto para ser lançado. Nela, são feitos apenas os últimos ajustes e testes antes do merge para a `main`.
* **hotfix/`<correcao-urgente>`:** Branch criada a partir da `main` para corrigir bugs críticos em produção. Ao ser concluída, é mesclada tanto na `main` quanto na `develop`.

### Gerenciamento de Commits, Issues e Pull Requests

* **Commits:** As mensagens de commit seguirão o padrão **Conventional Commits** (ex: `feat: Adiciona filtro de preço`, `fix: Corrige bug no formulário de contato`), para manter o histórico claro e organizado.
* **Issues:** A gerência de tarefas é feita via **GitHub Issues**. Cada tarefa, bug ou melhoria é uma Issue, que contém descrição, critérios de aceite e é atribuída a um responsável. As Issues são etiquetadas para facilitar a organização:
    * `documentation`: Melhorias ou acréscimos à documentação.
    * `bug`: Uma funcionalidade apresenta um problema.
    * `enhancement`: Uma funcionalidade existente precisa ser melhorada.
    * `feature`: Uma nova funcionalidade a ser implementada.
* **Pull Requests (PRs):** Toda e qualquer integração de código nas branches `develop` e `main` será feita exclusivamente através de Pull Requests. Cada PR deve estar vinculado a uma Issue, passar pela revisão do outro membro da equipe (code review) e, idealmente, por verificações automatizadas (CI/CD) antes de ser aprovado e mesclado.

## Gerenciamento de Projeto

### Divisão de Papéis

Sendo uma equipe de dois membros, os papéis são fluidos e colaborativos, mas com focos primários para garantir a cobertura de todas as áreas do projeto:

* **Membro A:** Desenvolvedor Full-Stack com foco em **Backend**. Responsável principal pela arquitetura da solução em ASP.NET Core, modelagem do banco de dados com EF Core e configuração da lógica de negócio.
* **Membro B:** Desenvolvedor Full-Stack com foco em **Frontend**. Responsável principal pela implementação das interfaces com HTML/CSS/Bootstrap, interatividade com JavaScript e garantia da responsividade e usabilidade.

Ambos os membros compartilham a responsabilidade pela gestão do projeto, participação nos rituais do Scrum e revisão de código (code review) um do outro.

### Processo e Quadro Kanban

A equipe utiliza um quadro **Kanban no GitHub Projects** para gerenciar visualmente o fluxo de trabalho dentro de cada Sprint.

* **Link do Quadro:** `https://github.com/[SEU-USUARIO]/[SEU-REPOSITORIO]/projects/1` (substituir pelo link real)
* **Colunas:**
    * **Backlog:** Todas as Issues do projeto.
    * **To Do:** Issues selecionadas para a Sprint atual.
    * **In Progress:** Issue que está sendo desenvolvida ativamente.
    * **Review:** A Issue foi desenvolvida e um Pull Request está aberto para revisão.
    * **Done:** O Pull Request foi aprovado e mesclado. A tarefa está concluída.

## Ferramentas

| Categoria | Ferramenta | Propósito |
| :--- | :--- | :--- |
| **Controle de Versão e Colaboração** | **Git & GitHub** | Controle de código-fonte, colaboração e gestão integrada do projeto. |
| **Gerenciamento de Projeto** | **GitHub Projects, Issues, Discussions, PRs**| Gestão de tarefas (Kanban), rastreamento de bugs, discussões técnicas e revisão de código. |
| **Desenvolvimento (Backend)** | **Visual Studio 2022, ASP.NET Core, EF Core** | IDE de desenvolvimento e frameworks para construção da lógica de negócio e API. |
| **Desenvolvimento (Frontend)** | **Visual Studio Code, HTML, CSS, JS, Bootstrap**| Edição de código e tecnologias para a construção da interface do usuário. |
| **Banco de Dados** | **Supabase (PostgreSQL)** | Plataforma para hospedagem e gerenciamento do banco de dados na nuvem. |
| **Design de Interface (UI/UX)** | **Figma** | Criação de wireframes, protótipos e o design visual da aplicação. |

## Justificativa das Escolhas

* **GitHub:** Escolhido por sua integração completa entre controle de versão, gerenciamento de projetos e colaboração, centralizando todo o ciclo de vida do desenvolvimento em um único local.
* **Git:** Ferramenta padrão da indústria para controle de versão, com excelente integração com o GitHub e essencial para o trabalho colaborativo.
* **GitHub Projects:** Permite uma visualização clara do fluxo de trabalho através do Kanban, facilitando o acompanhamento do progresso e a identificação de gargalos.
* **GitHub Issues:** Sistema robusto para rastreamento de tarefas com integração nativa ao repositório, commits e Pull Requests, garantindo total rastreabilidade.
* **GitHub Discussions:** Facilita a comunicação da equipe e a documentação de decisões técnicas, criando um registro histórico consultável.
* **GitHub Pull Requests:** Sistema eficiente para revisão de código (code review), uma prática fundamental para garantir a qualidade do software e compartilhar conhecimento.