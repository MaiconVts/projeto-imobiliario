## Personas

### Persona 1: Ana e Carlos, a Família em Busca de um Lar

**Informações:** Ana (36) e Carlos (38) são casados, têm dois filhos pequenos e moram em Belo Horizonte (MG). Ela é advogada e ele é engenheiro. Com o crescimento da família, o apartamento atual ficou pequeno.

**Objetivos:** O principal objetivo do casal é encontrar uma casa de 3 ou mais quartos em um bairro seguro e com boas escolas. Eles valorizam espaços externos, como um quintal ou área gourmet, e precisam de uma garagem para dois carros. A busca é feita principalmente à noite e nos fins de semana, geralmente pelo celular de Ana.

**Dores e Desafios:** A maior frustração de Ana e Carlos é a perda de tempo. Eles se sentem sobrecarregados com a quantidade de portais diferentes, muitos com anúncios duplicados ou desatualizados. Ficam desapontados com fotos de baixa qualidade que não mostram a realidade do imóvel e com a falta de filtros eficientes (ex: filtrar por "área externa").

**Como o Portal Imobiliário Ajuda:**
* Ana e Carlos podem usar a **Busca Avançada e Filtros (R3)** para encontrar rapidamente apenas as casas que atendem a todos os seus critérios.
* A **Página de Detalhes do Imóvel (R4)** oferece uma galeria de fotos de alta qualidade e um mapa de localização integrado **(R7)**, permitindo que eles avaliem o imóvel e a vizinhança sem sair de casa.
* O site com **Design Responsivo (R12)** garante que a experiência de busca no celular de Ana seja fluida e sem frustrações.
* Através do **Formulário de Contato (R5)**, eles podem agendar uma visita diretamente na página do imóvel que gostaram, otimizando o tempo.

### Persona 2: Cláudia, a Corretora Conectada

**Informações:** Cláudia tem 45 anos e é a gestora da imobiliária. Ela é experiente no mercado, mas sente que as ferramentas digitais que utiliza estão ultrapassadas. Ela gerencia uma equipe de 5 corretores.

**Objetivos:** O principal objetivo de Cláudia é ter uma vitrine digital profissional para os imóveis da sua carteira, que transmita a credibilidade da sua marca. Ela quer total autonomia para adicionar, editar e destacar anúncios rapidamente, sem depender de terceiros. Além disso, precisa de um canal eficaz para receber e gerenciar os contatos de novos clientes.

**Dores e Desafios:** A maior dor de Cláudia é a falta de controle e a alta competição nos grandes portais. Ela se sente "apenas mais uma" e acredita que a apresentação nesses sites não valoriza seus imóveis. Usar o site antigo da empresa é frustrante, pois ele é lento, difícil de atualizar e não funciona bem no celular.

**Como o Portal Imobiliário Ajuda:**
* Cláudia utiliza o **Sistema de Autenticação (R6)** para acessar um painel administrativo seguro.
* Com a **Gestão de Imóveis (R1)**, ela e sua equipe podem cadastrar um novo imóvel em minutos, com todas as suas características e fotos.
* A funcionalidade da **Homepage com Destaques (R11)** permite que ela escolha estrategicamente quais imóveis aparecerão na página inicial, impulsionando as vendas.
* Todos os contatos feitos pelo **Formulário de Contato (R5)** chegam diretamente no e-mail da imobiliária, centralizando a gestão de leads.

## Histórias de Usuários

| EU COMO... [QUEM] | QUERO/DESEJO... [O QUE] | PARA... [PORQUÊ] |
| :--- | :--- | :--- |
| **Ana (Compradora)** | Filtrar os imóveis por bairro, faixa de preço e número de quartos | Encontrar rapidamente apenas as opções relevantes para minha família. |
| **Cláudia (Corretora)**| Cadastrar um novo imóvel com fotos e detalhes de forma autônoma | Manter o portfólio do site sempre atualizado sem depender de um desenvolvedor. |
| **Ana (Compradora)** | Ver uma galeria de fotos completa e a localização do imóvel em um mapa | Avaliar se vale a pena agendar uma visita presencial. |
| **Cláudia (Corretora)**| Receber uma notificação por e-mail quando um cliente demonstrar interesse | Entrar em contato com o lead o mais rápido possível e não perder a oportunidade de negócio. |

## Requisitos do Projeto

### Requisitos Funcionais

| ID | Descrição | Prioridade |
| :--- | :--- | :--- |
| **R1** | **Gestão de Imóveis (Admin):** O administrador pode incluir, editar, excluir e visualizar todos os imóveis através de um painel seguro. | Alta |
| **R2** | **Listagem Pública de Imóveis:** O sistema deve exibir todos os imóveis ativos em uma página pública com layout de grid ou lista. | Alta |
| **R3** | **Busca Avançada e Filtros:** O usuário pode buscar imóveis por texto (bairro, cidade) e filtrar por tipo, finalidade, preço, quartos, etc. | Alta |
| **R4** | **Página de Detalhes do Imóvel:** Cada imóvel deve ter uma página própria com galeria de fotos, descrição, ficha técnica e características. | Alta |
| **R5** | **Formulário de Contato (Leads):** O usuário pode enviar uma mensagem de interesse a partir da página de detalhes do imóvel. | Alta |
| **R6** | **Autenticação de Administrador:** O sistema deve ter uma área de login segura para acesso ao painel de gerenciamento. | Alta |
| **R7** | **Integração com Mapa de Localização:** A página de detalhes deve exibir um mapa interativo (Google Maps/OpenStreetMap) com a localização do imóvel. | Média |
| **R8** | **Personalização do Tema (Modo Escuro):** Permitir ao usuário alternar entre um tema claro e um escuro na interface. | Média |
| **R9** | **Suporte a Múltiplos Idiomas:** O sistema deve permitir a tradução da interface para outros idiomas (ex: Inglês). | Baixa |
| **R10** | **Recursos de Acessibilidade:** O site deve ser compatível com leitores de tela e navegação por teclado (padrão WCAG). | Média |
| **R11** | **Homepage com Destaques:** A página inicial deve exibir uma seleção de imóveis em destaque, configuráveis pelo administrador. | Alta |
| **R12** | **Design Responsivo:** A interface deve se adaptar e ser totalmente funcional em desktops, tablets e smartphones. | Alta |


### Requisitos Não Funcionais

| ID | Descrição | Prioridade |
| :--- | :--- | :--- |
| **RNF-1**| **Performance:** O sistema deve garantir um tempo de carregamento de página (LCP) inferior a 3 segundos para todas as páginas principais. | Alta |
| **RNF-2**| **Segurança:** Implementação de HTTPS em todo o site, proteção contra ataques comuns (XSS, CSRF) e hashing seguro para senhas de administrador. | Alta |
| **RNF-3**| **Compatibilidade:** O site deve ser renderizado corretamente nas versões mais recentes dos navegadores Google Chrome, Firefox, Safari e Edge. | Alta |
| **RNF-4**| **Escalabilidade:** A arquitetura do sistema deve ser projetada para suportar picos de tráfego durante campanhas de marketing sem degradação de performance. | Média |

### Restrições

| ID | Restrição |
| :--- | :--- |
| **01** | O projeto deverá ser desenvolvido utilizando tecnologias primariamente open source (ASP.NET Core, PostgreSQL, Bootstrap). |