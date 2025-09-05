# Plano de Testes de Usabilidade

**Pré-requisitos:** [Especificação do Projeto](./1-Documentação-de-Contexto.md), [Projeto de Interface](./3-Projeto-de-Interface.md)

Este documento detalha o plano para a execução de testes de usabilidade, cujo objetivo é avaliar a qualidade da interação do usuário com a interface do portal imobiliário. Através da observação de usuários reais executando tarefas específicas, buscaremos identificar pontos de atrito, validar a eficácia do design e coletar feedbacks para aprimorar a experiência geral da aplicação.

## 1. Definição dos Objetivos

Antes de iniciar os testes, foram definidos os seguintes objetivos centrais para a avaliação de usabilidade do sistema:

- Verificar se os usuários, representando as personas do projeto, conseguem concluir a jornada essencial (buscar, encontrar, analisar e contatar) sem dificuldades significativas.
- Identificar barreiras de navegação e pontos de confusão na interface que possam levar à frustração ou abandono do site.
- Avaliar a eficiência do fluxo de busca e filtragem, medindo o tempo e o esforço necessários para encontrar imóveis relevantes.
- Medir a satisfação subjetiva do usuário em relação à clareza das informações, apelo visual e facilidade de uso geral do portal.
- Testar a eficácia de funcionalidades específicas, como o modo escuro, e a acessibilidade geral da aplicação.

## 2. Seleção dos Participantes

Para garantir que os resultados dos testes sejam representativos do uso real do sistema, os participantes serão selecionados com base nas personas desenvolvidas na fase de especificação do projeto.

**Critérios para Seleção dos Participantes:**
- Perfis que se alinhem com as personas "Ana e Carlos" (família buscando imóvel para comprar) e "Lucas" (jovem profissional buscando aluguel).
- Indivíduos que estejam ativamente buscando um imóvel ou que tenham passado por esse processo nos últimos 12 meses.
- Níveis variados de familiaridade com tecnologia, incluindo tanto usuários experientes em portais imobiliários quanto iniciantes.
- Se possível, incluir um participante que faça uso de tecnologias assistivas (ex: leitor de tela) para validar os requisitos de acessibilidade.

**Quantidade Recomendada:**
- **Mínimo:** 5 participantes.
- **Ideal:** Entre 8 e 12 participantes para obter uma maior diversidade de feedbacks e insights.

## 3. Definição de Cenários de Teste

Foram definidos 5 cenários de teste que representam as tarefas mais críticas e comuns que os usuários executarão no portal.

---
### Cenário 1: A Busca Efetiva

| **Objetivo** | Avaliar a facilidade e a eficiência do usuário em encontrar um tipo específico de imóvel em uma localidade desejada utilizando a busca e os filtros. |
| :--- | :--- |
| **Contexto** | Você e sua família moram em um apartamento e estão procurando uma casa maior para comprar em um bairro específico da cidade. Seu orçamento máximo é de R$ 800.000 e vocês precisam de pelo menos 3 quartos. |
| **Tarefa(s)** | 1. Acessar a página inicial do portal. <br> 2. Utilizar a barra de busca para pesquisar pelo bairro desejado. <br> 3. Na página de resultados, utilizar os filtros para refinar a busca, selecionando "Casa", "3 quartos ou mais" e ajustando a faixa de preço. <br> 4. Analisar os resultados apresentados. |
| **Critério(s) de Sucesso** | - O usuário consegue aplicar todos os filtros sem dificuldade. <br> - A lista de resultados é atualizada corretamente após cada filtro. <br> - O usuário expressa confiança de que os resultados são relevantes para sua busca. <br> - A tarefa é concluída em menos de 3 minutos. |

---
### Cenário 2: Análise e Geração de Contato (Lead)

| **Objetivo** | Avaliar a clareza das informações na página de detalhes e a simplicidade do processo para entrar em contato com a imobiliária. |
| :--- | :--- |
| **Contexto** | Após encontrar uma casa que pareceu interessante no cenário anterior, você quer analisar todos os detalhes, ver mais fotos, saber a localização exata e, finalmente, enviar uma mensagem para agendar uma visita. |
| **Tarefa(s)** | 1. A partir da página de listagem, clicar em um dos imóveis. <br> 2. Navegar pela galeria de fotos. <br> 3. Ler a descrição e a ficha técnica para encontrar a área total do imóvel. <br> 4. Visualizar a localização do imóvel no mapa integrado. <br> 5. Preencher e enviar o formulário "Tenho Interesse". |
| **Critério(s) de Sucesso** | - O usuário navega pela galeria de fotos de forma intuitiva. <br> - Todas as informações importantes são encontradas facilmente. <br> - O formulário de contato é preenchido e enviado com sucesso na primeira tentativa. <br> - O usuário recebe uma mensagem de confirmação clara após o envio. |

---
### Cenário 3: A Jornada do Administrador (Cadastro de Imóvel)

| **Objetivo** | Avaliar a usabilidade e a eficiência do painel administrativo para o cliente (a imobiliária). |
| :--- | :--- |
| **Contexto** | Você é um corretor da imobiliária e acaba de receber autorização para anunciar uma nova cobertura de 4 quartos. Você precisa adicionar este imóvel ao portal o mais rápido possível. |
| **Tarefa(s)** | 1. Acessar a página de login do painel administrativo e efetuar o login. <br> 2. Navegar até a seção de gerenciamento de imóveis. <br> 3. Iniciar o cadastro de um novo imóvel. <br> 4. Preencher todos os campos obrigatórios (título, preço, descrição, 4 quartos, etc.). <br> 5. Fazer o upload de 5 fotos do imóvel. <br> 6. Salvar o novo anúncio e verificar se ele aparece na lista. |
| **Critério(s) de Sucesso** | - O administrador consegue realizar o login e encontrar a função de adicionar imóvel sem dificuldades. <br> - O formulário de cadastro é claro e todos os campos são compreensíveis. <br> - O processo de upload de imagens é simples e rápido. <br> - O imóvel é salvo com sucesso e fica visível tanto no painel quanto no site público. |

---
### Cenário 4: Descoberta e Exploração Livre

| **Objetivo** | Avaliar a arquitetura de informação do site e a facilidade com que um novo usuário descobre o conteúdo e entende o propósito da imobiliária. |
| :--- | :--- |
| **Contexto** | Você ouviu falar desta imobiliária por um amigo e decidiu visitar o site pela primeira vez, sem um objetivo de busca específico, apenas para conhecer a empresa e ver o tipo de imóvel com que ela trabalha. |
| **Tarefa(s)** | 1. A partir da página inicial, navegar pelos imóveis em destaque. <br> 2. Encontrar e acessar a página "Sobre Nós" para conhecer a história da empresa. <br> 3. Localizar o endereço físico e o telefone principal da imobiliária. |
| **Critério(s) de Sucesso** | - O usuário consegue navegar de forma fluida entre as diferentes seções do site. <br> - A proposta de valor da imobiliária é compreendida através da navegação. <br> - As informações de contato institucionais são encontradas em menos de 1 minuto. |

---
### Cenário 5: Teste de Preferências e Acessibilidade

| **Objetivo** | Avaliar a funcionalidade de personalização da interface (Modo Escuro) e a legibilidade geral do site. |
| :--- | :--- |
| **Contexto** | Você está navegando no site à noite e o brilho da tela com fundo branco está incomodando seus olhos. Você procura uma forma de tornar a visualização mais confortável. |
| **Tarefa(s)** | 1. Na página inicial, localizar e ativar a funcionalidade de "Modo Escuro". <br> 2. Navegar para uma página de listagem e uma página de detalhes para observar como o tema é aplicado. <br> 3. Desativar o "Modo Escuro", retornando ao tema padrão. |
| **Critério(s) de Sucesso** | - O controle para alternar o tema é encontrado facilmente. <br> - Todas as páginas e componentes se adaptam corretamente ao tema escuro, sem elementos ilegíveis. <br> - O contraste entre texto e fundo no modo escuro é confortável para a leitura. |

---
## 4. Métodos de Coleta de Dados

Para capturar uma visão completa da experiência do usuário, utilizaremos uma combinação de métodos qualitativos e quantitativos.

- **Observação Direta (Protocolo Think-Aloud):** Os testes serão conduzidos com um moderador que observará o participante enquanto ele executa as tarefas, incentivando-o a verbalizar seus pensamentos, dúvidas e frustrações em tempo real.

- **Métricas Quantitativas:** Para cada cenário, serão coletadas as seguintes métricas:
    - **Taxa de Sucesso da Tarefa:** O participante conseguiu completar a tarefa com sucesso? (Sim/Não).
    - **Tempo para Conclusão:** Tempo total, em minutos e segundos, para realizar cada tarefa.
    - **Número de Erros:** Quantidade de cliques ou ações que não levaram à conclusão da tarefa.

- **Métricas Qualitativas:** Serão registradas anotações sobre:
    - **Comentários e Citações:** Frases literais dos participantes que revelem suas percepções.
    - **Pontos de Dificuldade:** Partes específicas da interface onde o usuário hesitou, demonstrou confusão ou expressou frustração.

- **Questionário Pós-Teste:** Ao final da sessão, será aplicado um breve questionário com perguntas como:
    - De 1 a 5, quão fácil foi navegar no site?
    - Houve alguma tarefa que você considerou particularmente difícil? Qual?
    - O que você mais gostou na interface?
    - Se você pudesse mudar uma coisa no site, o que seria?

**Conformidade com a LGPD:** Todos os dados coletados durante os testes serão anonimizados. Nenhuma informação pessoal que possa identificar os participantes será armazenada ou divulgada nos relatórios, em total conformidade com a Lei Geral de Proteção de Dados (LGPD).