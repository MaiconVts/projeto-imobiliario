# Registro de Testes de Software

**Pré-requisitos:** [Projeto de Interface](./3-Projeto-de-Interface.md), [Plano de Testes de Software](./8-Plano-de-Testes-de-Software.md)

Esta seção documenta a execução dos casos de teste definidos no plano de testes. Para cada caso, são apresentadas as evidências em vídeo (`screencast`) que comprovam o resultado obtido, seja ele de sucesso ou falha. Adicionalmente, um relatório detalhado analisa os resultados, discute as falhas encontradas e propõe estratégias de correção e melhorias para o projeto.

## Tabela de Registro de Evidências

| **Caso de Teste** | **CT-01 – Realizar busca e aplicar filtros** |
| :--- | :--- |
| **Requisito Associado** | **RF-02:** Listagem Pública de Imóveis <br> **RF-03:** Busca Avançada e Filtros |
| **Status** | Aprovado com Ressalvas |
| **Registro de evidência** | `https://[LINK-PARA-SEU-DRIVE]/ct-01.mp4` |

| **Caso de Teste** | **CT-02 – Visualizar detalhes de um imóvel** |
| :--- | :--- |
| **Requisito Associado** | **RF-04:** Página de Detalhes do Imóvel |
| **Status** | Aprovado com Ressalvas |
| **Registro de evidência** | `https://[LINK-PARA-SEU-DRIVE]/ct-02.mp4` |

| **Caso de Teste** | **CT-03 – Enviar formulário de contato (Gerar Lead)** |
| :--- | :--- |
| **Requisito Associado** | **RF-05:** Formulário de Contato (Leads) |
| **Status** | Aprovado |
| **Registro de evidência** | `https://[LINK-PARA-SEU-DRIVE]/ct-03.mp4` |

| **Caso de Teste** | **CT-04 – Efetuar login como administrador** |
| :--- | :--- |
| **Requisito Associado** | **RF-06:** Autenticação de Administrador |
| **Status** | Aprovado |
| **Registro de evidência** | `https://[LINK-PARA-SEU-DRIVE]/ct-04.mp4` |

| **Caso de Teste** | **CT-05 – Tentar login com credenciais inválidas** |
| :--- | :--- |
| **Requisito Associado** | **RF-06:** Autenticação de Administrador |
| **Status** | Aprovado |
| **Registro de evidência** | `https://[LINK-PARA-SEU-DRIVE]/ct-05.mp4` |

| **Caso de Teste** | **CT-06 – Cadastrar um novo imóvel no painel** |
| :--- | :--- |
| **Requisito Associado** | **RF-01:** Gestão de Imóveis (Admin) |
| **Status** | Aprovado com Ressalvas |
| **Registro de evidência** | `https://[LINK-PARA-SEU-DRIVE]/ct-06.mp4` |

| **Caso de Teste** | **CT-07 – Verificar responsividade do layout** |
| :--- | :--- |
| **Requisito Associado** | **RF-12:** Design Responsivo |
| **Status** | Aprovado |
| **Registro de evidência** | `https://[LINK-PARA-SEU-DRIVE]/ct-07.mp4` |

## Relatório de Testes de Software

A fase de testes abrangeu os 7 casos de teste definidos, cobrindo as funcionalidades críticas da aplicação, desde a perspectiva do visitante até as operações do painel administrativo. De modo geral, o sistema se mostrou estável e funcional, com a maioria dos critérios de êxito sendo alcançados. No entanto, foram identificados alguns pontos de atrito na experiência do usuário e oportunidades de melhoria que, se abordados, elevarão a qualidade final do produto.

### Discussão dos Resultados Obtidos

**Pontos Fortes:**
* A robustez do painel administrativo (**CT-04, CT-05, CT-06**) foi um destaque. O fluxo de login, a segurança contra acesso indevido e o processo de cadastro de imóveis funcionaram perfeitamente, atendendo com excelência às necessidades da imobiliária.
* A responsividade da aplicação (**CT-07**) atendeu plenamente aos critérios de êxito. O layout se adapta de forma fluida e consistente entre dispositivos móveis, tablets e desktops, garantindo uma boa usabilidade em todas as plataformas.
* A funcionalidade principal de busca (**CT-01**) e a visualização de detalhes (**CT-02**) são operacionais, permitindo que o usuário complete a jornada principal de encontrar e analisar um imóvel.

**Fragilidades Identificadas:**
* Foram observadas pequenas inconsistências de usabilidade que, embora não impeçam o funcionamento, impactam a fluidez da experiência do usuário. As principais fragilidades estão relacionadas ao comportamento dos filtros de busca (**CT-01**), ao carregamento de elementos na página de detalhes (**CT-02**) e à validação de formulários (**CT-03**).

### Principais Falhas Detectadas

1.  **Falha no Reset dos Filtros (Ref. CT-01):**
    * **Evidência:** `ct-01.mp4`
    * **Descrição:** Ao realizar uma busca e aplicar um filtro (ex: faixa de preço), se o usuário apagar o termo de busca para iniciar uma nova pesquisa, os filtros aplicados anteriormente não são limpos automaticamente, continuando a afetar os novos resultados.
    * **Impacto:** Causa confusão para o usuário, que pode não perceber que um filtro antigo ainda está ativo, levando-o a acreditar que não há imóveis disponíveis para sua nova busca.

2.  **Layout Shift no Carregamento do Mapa (Ref. CT-02):**
    * **Evidência:** `ct-02.mp4`
    * **Descrição:** Na página de detalhes do imóvel, o mapa de localização é o último elemento a ser carregado. Como ele não possui um espaço reservado, seu carregamento tardio causa um "salto" no conteúdo da página (Cumulative Layout Shift - CLS), prejudicando a experiência de leitura.
    * **Impacto:** Afeta negativamente a percepção de profissionalismo e a usabilidade, podendo frustrar o usuário enquanto ele lê a descrição do imóvel.

3.  **Feedback de Validação Atrasado no Formulário (Ref. CT-03):**
    * **Evidência:** `ct-03.mp4`
    * **Descrição:** O formulário de contato não valida o formato do e-mail em tempo real (client-side). A verificação só ocorre após o clique no botão "Enviar", quando a página é recarregada com uma mensagem de erro do servidor.
    * **Impacto:** Torna o processo de correção de erros mais lento para o usuário e pode levar a um aumento no número de leads com dados de contato inválidos.

### Estratégias de Correção e Aprimoramento

Com base nas falhas identificadas, as seguintes ações serão priorizadas na próxima iteração:

1.  **Correção do Filtro Persistente:** Implementar uma função JavaScript que, ao detectar o evento de `clear` ou `submit` de uma nova busca na barra principal, percorra todos os campos de filtro (`<input>`, `<select>`) e os redefina para seus valores padrão.
2.  **Prevenção do Layout Shift:** Aplicar uma regra de CSS que define uma altura mínima (`min-height`) para o container do mapa. Isso reservará o espaço vertical necessário no layout desde o carregamento inicial da página, eliminando o "salto" visual quando o mapa for renderizado.
3.  **Implementação de Validação Client-Side:** Adicionar validação com JavaScript no formulário de contato. Utilizar expressões regulares (regex) para verificar o formato do e-mail no evento `onblur` (quando o usuário desfoca o campo), fornecendo feedback visual imediato ao usuário antes do envio.

### Melhorias Propostas a Partir dos Testes

Os testes também revelaram oportunidades para funcionalidades que não estavam no escopo inicial, mas que agregariam grande valor:

* **Salvar Busca e Alertas:** Durante o teste dos filtros (**CT-01**), ficou evidente o valor de um botão "Salvar Busca". Essa funcionalidade permitiria que usuários cadastrados recebessem notificações por e-mail quando novos imóveis que atendem aos seus critérios fossem adicionados ao portal.
* **Status do Imóvel no Painel Admin:** No painel administrativo (**CT-06**), seria útil adicionar um campo de "Status" (ex: Disponível, Reservado, Vendido). Isso permitiria que a imobiliária gerenciasse melhor seu portfólio e pudesse, por exemplo, ocultar um imóvel do site público sem precisar excluí-lo do banco de dados.