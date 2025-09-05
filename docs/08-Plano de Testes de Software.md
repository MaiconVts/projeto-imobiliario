# Plano de Testes de Software

**Pré-requisitos:** [Especificação do Projeto](./1-Documentação-de-Contexto.md), [Projeto de Interface](./3-Projeto-de-Interface.md)

Este documento apresenta os cenários de teste de software elaborados para validar a implementação do portal imobiliário. Cada caso de teste foi projetado para verificar o cumprimento de requisitos funcionais específicos, garantindo que as principais funcionalidades da aplicação operem conforme o esperado, desde a perspectiva do visitante até a do administrador.

---
### Caso de Teste CT-01 – Realizar busca e aplicar filtros

| **Requisito Associado** | **RF-02:** Listagem Pública de Imóveis <br> **RF-03:** Busca Avançada e Filtros |
| :--- | :--- |
| **Objetivo do Teste** | Verificar se o usuário consegue buscar e filtrar imóveis de forma eficaz para encontrar resultados relevantes. |
| **Passos** | 1. Acessar o navegador. <br> 2. Informar o endereço do site: `https://[URL-DA-SUA-APLICACAO].azurewebsites.net/`. <br> 3. Na página inicial, digitar um bairro ou cidade no campo de busca e clicar em "Buscar". <br> 4. Na página de resultados, verificar se a lista de imóveis corresponde à busca. <br> 5. Na sidebar de filtros, selecionar o tipo "Apartamento". <br> 6. Ajustar o filtro de "Faixa de Preço" para um valor específico. <br> 7. Selecionar "3 quartos" no filtro correspondente. |
| **Critério de Êxito** | A lista de imóveis na tela deve ser atualizada a cada filtro aplicado, exibindo apenas os apartamentos de 3 quartos que se encaixam na faixa de preço e na localidade pesquisada. |

---
### Caso de Teste CT-02 – Visualizar detalhes de um imóvel

| **Requisito Associado** | **RF-04:** Página de Detalhes do Imóvel |
| :--- | :--- |
| **Objetivo do Teste** | Verificar se todas as informações de um imóvel selecionado são exibidas corretamente em sua página de detalhes. |
| **Passos** | 1. Acessar a página de listagem de imóveis. <br> 2. Clicar em um dos "cards" de imóvel disponíveis. |
| **Critério de Êxito** | O usuário é redirecionado para a página de detalhes do imóvel selecionado. A página exibe corretamente a galeria de fotos, título, preço, descrição completa, ficha técnica e o mapa de localização (**RF-07**). |

---
### Caso de Teste CT-03 – Enviar formulário de contato (Gerar Lead)

| **Requisito Associado** | **RF-05:** Formulário de Contato (Leads) |
| :--- | :--- |
| **Objetivo do Teste** | Verificar se um visitante consegue enviar com sucesso uma mensagem de interesse em um imóvel. |
| **Passos** | 1. Acessar a página de detalhes de um imóvel. <br> 2. Localizar o formulário "Tenho Interesse". <br> 3. Preencher os campos obrigatórios: Nome, E-mail e Telefone. <br> 4. Digitar uma mensagem no campo de texto. <br> 5. Clicar no botão "Enviar Mensagem". |
| **Critério de Êxito** | O sistema exibe uma mensagem de sucesso na tela para o usuário (ex: "Sua mensagem foi enviada com sucesso!"). Um e-mail contendo os dados do formulário e o link do imóvel de interesse é recebido na caixa de entrada da imobiliária. |

---
### Caso de Teste CT-04 – Efetuar login como administrador

| **Requisito Associado** | **RF-06:** Autenticação de Administrador |
| :--- | :--- |
| **Objetivo do Teste** | Verificar se um usuário com credenciais válidas consegue acessar o painel administrativo. |
| **Passos** | 1. Acessar o endereço do painel administrativo: `https://[URL-DA-SUA-APLICACAO].azurewebsites.net/ImoveisAdmin`. <br> 2. Preencher o campo de e-mail com `admin@imobiliaria.com`. <br> 3. Preencher o campo de senha com `Admin@2025`. <br> 4. Clicar no botão "Entrar". |
| **Critério de Êxito** | O login é realizado com sucesso e o usuário é redirecionado para o dashboard administrativo, onde a lista de imóveis cadastrados é exibida. |

---
### Caso de Teste CT-05 – Tentar login com credenciais inválidas

| **Requisito Associado** | **RF-06:** Autenticação de Administrador |
| :--- | :--- |
| **Objetivo do Teste** | Verificar se o sistema impede o acesso de usuários com credenciais incorretas, garantindo a segurança do painel. |
| **Passos** | 1. Acessar o endereço do painel administrativo. <br> 2. Preencher o campo de e-mail com `admin@imobiliaria.com`. <br> 3. Preencher o campo de senha com uma senha incorreta (ex: `senhaerrada`). <br> 4. Clicar no botão "Entrar". |
| **Critério de Êxito** | O usuário permanece na página de login e uma mensagem de erro apropriada é exibida na tela (ex: "Tentativa de login inválida."). |

---
### Caso de Teste CT-06 – Cadastrar um novo imóvel no painel

| **Requisito Associado** | **RF-01:** Gestão de Imóveis (Admin) |
| :--- | :--- |
| **Objetivo do Teste** | Verificar se o administrador consegue cadastrar um novo imóvel com sucesso através do painel. |
| **Passos** | 1. Efetuar login como administrador (conforme CT-04). <br> 2. No dashboard, clicar no botão "Adicionar Novo Imóvel". <br> 3. Preencher todos os campos do formulário de cadastro (título, preço, descrição, quartos, etc.). <br> 4. Fazer o upload de ao menos uma imagem. <br> 5. Clicar no botão "Salvar" ou "Criar". |
| **Critério de Êxito** | O imóvel é salvo no banco de dados. O sistema redireciona para a lista de imóveis, exibindo o novo cadastro. O novo imóvel também aparece corretamente no site público. |

---
### Caso de Teste CT-07 – Verificar responsividade do layout

| **Requisito Associado** | **RF-12:** Design Responsivo |
| :--- | :--- |
| **Objetivo do Teste** | Verificar se a interface da aplicação se adapta corretamente a diferentes tamanhos de tela (desktop, tablet e mobile). |
| **Passos** | 1. Acessar o site em um navegador desktop. <br> 2. Abrir as Ferramentas de Desenvolvedor (geralmente F12). <br> 3. Ativar o modo de visualização de dispositivos e selecionar diferentes perfis (ex: "iPhone 12 Pro", "iPad Air"). <br> 4. Navegar pelas páginas principais (Homepage, Listagem e Detalhes) em cada um dos perfis. |
| **Critério de Êxito** | Em todos os dispositivos, o layout é exibido sem quebras, barras de rolagem horizontais ou elementos sobrepostos. O menu principal se transforma em um menu "hambúrguer" em telas menores. O conteúdo permanece legível e todos os botões são facilmente clicáveis. |