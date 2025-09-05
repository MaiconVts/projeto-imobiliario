# Template Padrão da Aplicação

**Pré-requisitos:** [Especificação do Projeto](./1-Documentação-de-Contexto.md), [Projeto de Interface](./3-Projeto-de-Interface.md), [Metodologia](./2-Gerenciamento-e-Metodologia.md)

Esta seção estabelece o layout padrão e a identidade visual que serão aplicados em todas as páginas do sistema. O objetivo é criar uma experiência de usuário consistente, profissional e memorável, definindo a aplicação de cores, tipografia, iconografia e os aspectos de responsividade.

## Identidade Visual e Elementos de Marca

A identidade visual é o coração do design da aplicação, transmitindo os valores da imobiliária através de um conjunto coeso de cores e elementos gráficos.

### Paleta de Cores

A paleta de cores combina tons azuis que transmitem confiança e profissionalismo com tons dourados e terrosos que evocam valor e sofisticação.

![paleta-de-cores.png](/docs/img/paleta-de-cores.png)

| Cor | Hexadecimal | Aplicação Principal |
| :--- | :--- | :--- |
| Amarelo Ouro Escuro | `#d4a413` | Cor secundária de destaque, detalhes, bordas |
| Amarelo Ouro Médio | `#efb810` | Cor de destaque primária para CTAs, títulos, realces |
| Amarelo Claro | `#f3c332` | Pontos de destaque sutis, texto em fundos escuros, ícones especiais |
| Azul Médio | `#155db1` | Cor principal de links, botões secundários, elementos de navegação |
| Azul Brilhante | `#2196f3` | Cor de destaque para interação, feedback, status ativos |
| **Neutras** | | |
| Branco | `#FFFFFF` | Fundo principal do Tema Claro, texto em fundos escuros |
| Cinza Claro | `#F8F9FA`| Fundo de seções secundárias para diferenciação visual |

### Logo

O logo é o principal ponto de reconhecimento da marca e deve ser tratado com destaque.

* **Estilo Recomendado:** Um design limpo e moderno, que pode combinar um ícone minimalista (abstração de uma casa, chave ou as iniciais da imobiliária) com uma tipografia forte e clara (wordmark). O design deve refletir a sofisticação da paleta de cores.
* **Aplicação:**
    * **Header:** Posicionado de forma proeminente no canto superior esquerdo em todas as páginas.
    * **Footer:** Centralizado ou à esquerda na seção de identidade do rodapé.
    * **Versões:** Deverão ser criadas versões do logo que funcionem em fundos claros (versão principal colorida) e em fundos escuros (versão monocromática em branco ou no tom `#f3c332`).

## Tipografia

A escolha das fontes é fundamental para garantir legibilidade e reforçar a personalidade da marca. A estratégia adotada é a combinação de uma fonte serifada elegante para títulos com uma fonte sans-serif limpa para o corpo de texto, criando uma hierarquia visual clara e sofisticada. As fontes serão importadas do **Google Fonts**.

### Recomendação de Fontes

* **Títulos (Headings):** **Playfair Display**
    * **Por quê?** É uma fonte serifada de alto contraste, que transmite elegância, luxo e tradição. É perfeita para um mercado como o imobiliário, que lida com bens de alto valor, e harmoniza lindamente com a paleta de cores escuras e douradas.
* **Corpo de Texto (Body):** **Lato**
    * **Por quê?** É uma fonte sans-serif humanista, conhecida por sua excelente legibilidade em qualquer tamanho. Sua clareza e aparência amigável oferecem o contraponto perfeito à natureza ornamental dos títulos, garantindo que as descrições dos imóveis e outros textos longos sejam confortáveis de ler.

### Hierarquia e Escala Tipográfica

| Elemento | Fonte | Peso (Weight) | Tamanho (Desktop) |
| :--- | :--- | :--- | :--- |
| **Título H1** | Playfair Display | `700` (Bold) | `48px` |
| **Título H2** | Playfair Display | `600` (SemiBold)| `36px` |
| **Título H3** | Playfair Display | `500` (Medium) | `24px` |
| **Corpo de Texto**| Lato | `400` (Regular) | `16px` |
| **Texto Pequeno/Legenda**| Lato | `400` (Regular) | `14px` |
| **Links/Botões**| Lato | `700` (Bold) | `16px` |

## Iconografia

Os ícones serão utilizados para melhorar a comunicação visual e a usabilidade, guiando o usuário de forma intuitiva.

* **Estilo:** Ícones de linha (line icons), minimalistas e limpos, para manter a consistência com a estética elegante da tipografia e do design geral.
* **Biblioteca Recomendada:** **Bootstrap Icons**. Por ser a biblioteca nativa do framework Bootstrap 5, sua integração é perfeita e garante consistência visual com os demais componentes do site.
* **Aplicação:**
    * **Características de Imóveis:** Ícones para quartos, banheiros, vagas de garagem e área.
    * **Interface:** Ícones para busca, filtros, fechar modais e navegação.
    * **Contato e Social:** Ícones para telefone, e-mail e redes sociais no rodapé.

## Layout Padrão e Responsividade

A aplicação seguirá uma estrutura de layout consistente e uma abordagem **Mobile-First**, garantindo uma experiência de alta qualidade em todos os dispositivos.

* **Estrutura do Layout:**
    * **Header (Cabeçalho):** Fixo no topo (`sticky`), contendo o logo, o menu de navegação principal e o seletor de tema (claro/escuro).
    * **Main (Conteúdo Principal):** Área central onde o conteúdo específico de cada página é renderizado, dentro de um container com largura máxima de `1280px` para melhor legibilidade em telas grandes.
    * **Footer (Rodapé):** Seção final da página, com links de navegação, informações de contato, logo e ícones de redes sociais.

* **Responsividade:**
    * O **Grid System do Bootstrap 5** será a base para a construção de todos os layouts, garantindo fluidez e adaptabilidade.
    * **Mobile:** O menu de navegação se transforma em um menu "hambúrguer". Grids de imóveis são exibidos em uma única coluna.
    * **Tablet:** A interface se expande para aproveitar o espaço extra, com grids de 2 colunas.
    * **Desktop:** O layout completo é exibido, com sidebars (para filtros), menus expandidos e grids de 3 ou mais colunas.