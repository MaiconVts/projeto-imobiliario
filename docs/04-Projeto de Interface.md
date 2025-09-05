# Projeto de Interface

**Pré-requisitos:** [Documentação de Especificação](./01-Documentação%20de%20Contexto.md)

Esta seção apresenta a visão geral da interação do usuário com as telas do sistema e descreve o protótipo de baixa fidelidade (wireframes) das funcionalidades essenciais. As interfaces foram elaboradas para atender diretamente aos requisitos funcionais, não funcionais e às histórias de usuário abordados na Documentação de Especificação, garantindo uma experiência coesa, intuitiva e alinhada aos objetivos do projeto.

## Diagrama de Fluxo

O diagrama de fluxo do portal imobiliário mapeia as duas jornadas centrais da aplicação: a do **visitante** em busca de um imóvel e a do **administrador** gerenciando o portfólio. Este diagrama foi desenvolvido para garantir que a navegação seja lógica, eficiente e que os pontos de conversão (geração de leads) sejam facilmente alcançados.

O fluxo de interação foi projetado considerando os seguintes aspectos:

- **Descoberta e Busca:** Processo de chegada do usuário ao site, exploração inicial e utilização das ferramentas de busca e filtragem para encontrar imóveis relevantes.
- **Análise e Avaliação:** Jornada do usuário ao analisar um imóvel específico, incluindo a visualização de fotos, detalhes técnicos e localização.
- **Geração de Lead (Contato):** Fluxo simplificado para que um usuário interessado possa entrar em contato com a imobiliária de forma rápida.
- **Gestão de Conteúdo (Admin):** Fluxo seguro e eficiente para que o administrador da imobiliária possa gerenciar todo o ciclo de vida de um anúncio, desde o cadastro até a remoção.

## Wireframes

Foram desenvolvidos wireframes para todas as principais telas e funcionalidades do portal. Criados com foco na usabilidade e na arquitetura da informação, estes wireframes servem como um esqueleto para o design de UI (Interface do Usuário) e para o desenvolvimento frontend, seguindo as melhores práticas de UX (Experiência do Usuário).

### Principais Telas e Funcionalidades

#### Tela 1: Homepage
- **Objetivo:** Causar uma primeira impressão profissional, facilitar a busca imediata e destacar os principais imóveis, em linha com o requisito **R11**.
- **Principais Elementos:**
    - **Seção "Hero":** Com uma imagem de impacto, título principal e a barra de busca rápida.
    - **Galeria de Imóveis em Destaque:** Uma seleção de imóveis (lançamentos, oportunidades) que podem ser gerenciados pelo administrador.
    - **Blocos de Acesso Rápido:** Seções que levam para as páginas de "Venda" e "Aluguel".
    - **Seção Institucional:** Um breve resumo sobre a imobiliária para gerar confiança.
    - **Footer Padrão:** Com navegação, contatos e redes sociais.

#### Tela 2: Página de Listagem de Imóveis (Resultados da Busca)
- **Objetivo:** Oferecer uma ferramenta de exploração poderosa e intuitiva, atendendo à história de usuário de "Ana e Carlos" e ao requisito **R3**.
- **Principais Elementos:**
    - **Sidebar de Filtros Avançados:** Controles para refinar a busca por tipo de imóvel, faixa de preço, número de quartos, características, etc.
    - **Área de Resultados:** Grid responsivo com os "cards" dos imóveis, exibindo foto principal, título, preço e informações essenciais.
    - **Controles de Ordenação:** Opções para ordenar os resultados (ex: por maior preço, menor área).
    - **Paginação:** Para navegação entre as diferentes páginas de resultados.

#### Tela 3: Página de Detalhes do Imóvel
- **Objetivo:** Converter o interesse do usuário em uma ação de contato (lead), fornecendo todas as informações necessárias de forma clara e atraente, conforme o requisito **R4**.
- **Principais Elementos:**
    - **Galeria de Mídia:** Carrossel de imagens em alta resolução.
    - **Bloco de Informações Chave:** Título, preço, endereço e especificações principais (área, quartos, banheiros).
    - **Descrição Completa:** Texto detalhado sobre o imóvel.
    - **Mapa de Localização:** Mapa interativo integrado via API (**R7**).
    - **Formulário de Contato:** Formulário "Tenho Interesse" para geração de lead (**R5**).

#### Tela 4 e 5: Área Administrativa (Login, Dashboard e Formulários)
- **Objetivo:** Prover ao cliente (imobiliária) uma ferramenta autônoma e segura para gerenciar seu portfólio, conforme os requisitos **R1** e **R6**.
- **Principais Elementos:**
    - **Tela de Login:** Formulário de autenticação simples e seguro.
    - **Dashboard Principal (Pós-login):** Uma tabela com a lista de todos os imóveis cadastrados, com opções de "Editar", "Excluir" e um botão de destaque "Adicionar Novo Imóvel".
    - **Formulário de Cadastro/Edição de Imóvel:** Uma página com campos para todas as informações do imóvel (título, preço, descrição, etc.) e um sistema de upload para múltiplas imagens.

### Validação de Usabilidade

Os wireframes e o fluxo de interação serão validados através de um processo iterativo, garantindo que a versão final seja o mais otimizada possível antes do início do desenvolvimento. A estratégia de validação inclui:

- **Testes com Usuários (Planejado):** Protótipos interativos serão apresentados a um grupo de usuários que se encaixam nas personas para observar suas interações e coletar feedbacks diretos sobre a facilidade de uso.
- **Análise de Heurísticas:** A interface será avaliada internamente com base nas **10 Heurísticas de Usabilidade de Nielsen** para identificar e corrigir problemas comuns de design de interação.
- **Revisão por Pares:** A equipe de desenvolvimento realizará revisões cruzadas dos fluxos e wireframes para garantir que a lógica esteja correta e que todos os requisitos funcionais foram contemplados.
- **Iterações Baseadas em Feedback:** Os insights coletados em todas as etapas de validação serão utilizados para refinar os wireframes, garantindo que o produto final atenda às necessidades reais tanto do visitante quanto do administrador.