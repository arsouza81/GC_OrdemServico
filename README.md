# TVVS_OrdemServico

<h1>Organização do Projeto Ordem de Serviço</h1>

<h2>Backlog do Produto</h2>
<p>Tem como objetivo facilitar o gerenciamento de requisitos e o desenvolvimento do sistema de Ordem de Serviços.</p>
<p>Está disponível em: <a href="https://github.com/arsouza81/TVVS_OrdemServico/blob/main/sistema_ordem_servico/backlog.md">Backlog do Produto</a></p>

<h2>Dicionário de Dados</h2>
<p>Atua como um guia centralizado que documenta todos os elementos de dados do sistema, como tabelas, campos, tipos de dados e relações entre eles.</p>
<p>Está disponível em: <a href="https://github.com/arsouza81/TVVS_OrdemServico/blob/main/sistema_ordem_servico/dicionario_de_dados.md">Dicionário de Dados</a></p>

<h2>Exemplos de Uso</h2>
<p>Contém exemplos de uso de funcionalidades destinadas aos servidores e à Gerência de TI do ICET. Nesse documento encontraremos as relações entre as telas do Sistema Ordem de Serviço, 
  bem como os diagramas de atividades correspondentes às funcionalidades abordadas.</p>
<p>Está disponível em: <a href="https://github.com/arsouza81/TVVS_OrdemServico/blob/main/sistema_ordem_servico/exemplos_de_uso.md">Exemplos de Uso</a></p>

<h2>Diagrama de Classes</h2>
<p>O Diagrama de Classe oferece uma representação visual das classes que compõem um sistema, bem como das relações e interações entre elas.</p>
<p>Está disponível em: <a href="https://github.com/arsouza81/TVVS_OrdemServico/blob/main/sistema_ordem_servico/documentacao_tecnica/diagrama_de_classes.md">Diagrama de Classes</a></p>

<h2>Modelo C4</h2>
<p>Nesse documento podemos encontrar duas visões do Sistema Ordem de Serviço, uma visão mais ampla, Nível de Contexto, destacando a posição do sistema e a interação com o ambiente externo, 
  e outra visão simplificada da arquitetura do sistema, Nível de Container, destacando as tecnologias utilizadas e a maneira como ocorre a comunicação entre seus componentes.</p>
<p>Está disponível em: <a href="https://github.com/arsouza81/TVVS_OrdemServico/blob/main/sistema_ordem_servico/documentacao_tecnica/modelo_c4.md">Modelo C4</a></p>

<h2>Código Fonte</h2>
<p>O Código fonte é um conjunto de arquivos de texto contendo todas as instruções que devem ser executadas, expressas de forma ordenada numa linguagem de programação. A linguagem utilizada nesse projeto foi o C#.</p>
<p>Está disponível em: <a href="https://github.com/arsouza81/TVVS_OrdemServico/tree/main/sistema_ordem_servico/codigo_fonte">Código Fonte</a></p>
<p>O Manual de Instalação e configuração do Projeto Ordem de Serviço encontra-se no arquivo <a href="https://github.com/arsouza81/TVVS_OrdemServico/edit/main/README.md">readme</a> do projeto.</p>

<h2>Atividades de Verificação</h2>
<p>Essa etapa será responsável por realizar atividades de verificação para identificar e documentar os defeitos encontrados nos artefatos do software Ordem de Serviço.</p>
<p>Está disponível em: <a href="https://github.com/arsouza81/TVVS_OrdemServico/tree/main/verificacao">Atividades de Verificação</a></p>

<h2>Atividades de Validação</h2>
<p>Essa etapa será responsável por realizar atividades de validação para identificar e documentar, utilizando o método de avaliação Heurística, os problemas de usabilidade encontrados no Sistema Ordem de Serviço.</p>
<p>Está disponível em: <a href="https://github.com/arsouza81/TVVS_OrdemServico/tree/main/validacao">Atividades de Validação</a></p>

<h2>Plano de testes</h2>
<p>Essa etapa será essencial para o desenvolvimento do sistema de Ordem de Serviço, pois ela define uma estratégia estruturada para a validação de todas as funcionalidades e requisitos do software, garantindo que ele funcione conforme o esperado. Esse documento descreve os tipos de testes a serem realizados, como testes funcionais, além de especificar os recursos, prazos e responsáveis por cada etapa. A importância do plano de testes está na sua capacidade de organizar o processo de validação, reduzindo riscos e identificando possíveis falhas antes da implementação. Dessa forma, o plano contribui para assegurar a qualidade e confiabilidade do sistema, atendendo às necessidades dos usuários e minimizando problemas após o lançamento.</p>
<p>Está disponível em: <a href="https://github.com/arsouza81/TVVS_OrdemServico/blob/main/plano%20de%20testes/plano_de_testes.md">Plano de testes</a></p>
<br>
<br>

<h1>Manual de Instalação e Configuração do Projeto Ordem de Serviço</h1>

  <h2>1. Requisitos de Sistema</h2>
  <p>Antes de iniciar, certifique-se de que seu sistema atenda aos seguintes requisitos:</p>
  <ul>
      <li>Windows 10 ou superior</li>
      <li>Conexão com a internet para baixar as ferramentas necessárias</li>
  </ul>

  <h2>2. Instalando o Visual Studio 2022</h2>
  <ol>
      <li>Visite o site oficial do Visual Studio clicando no link abaixo:</li>
      <a href="https://visualstudio.microsoft.com/pt-br/downloads/">https://visualstudio.microsoft.com/pt-br/downloads/</a>
      <li>Na página de downloads, escolha a versão <strong>Community</strong> (gratuita) e clique em <strong>Download</strong>.</li>
      <li>Após o download, abra o instalador e siga as instruções na tela.</li>
      <li>Durante a instalação, selecione a carga de trabalho <strong>Desenvolvimento ASP.NET e Web</strong>.</li>
      <li>Aguarde até que a instalação seja concluída e o Visual Studio esteja pronto para uso.</li>
  </ol>

  <h2>3. Instalando o MySQL e MySQL Workbench</h2>
  <ol>
      <li>Visite o site oficial do MySQL clicando no link abaixo:</li>
      <a href="https://dev.mysql.com/downloads/installer/">https://dev.mysql.com/downloads/installer/</a>
      <li>Na página de downloads, escolha a opção <strong>MySQL Installer for Windows</strong> e clique em <strong>Download</strong>.</li>
      <li>Após o download, abra o instalador do MySQL.</li>
      <li>No instalador, selecione a opção <strong>Developer Default</strong>, que instalará o MySQL Server e o MySQL Workbench juntos.</li>
      <li>Siga as instruções na tela para configurar o MySQL Server:</li>
      <ul>
          <li>Escolha o tipo de instalação como <strong>Standalone MySQL Server</strong>.</li>
          <li>Defina a senha do usuário root (guarde essa senha, pois será necessária posteriormente).</li>
          <li>Complete as demais configurações padrão.</li>
      </ul>
      <li>Conclua a instalação e inicie o MySQL Workbench.</li>
  </ol>

  <h2>4. Baixando o Projeto do GitHub</h2>
  <p>Agora que você já tem o ambiente configurado, o próximo passo é baixar o projeto. Você pode fazer isso de duas formas:</p>
  
  <h3>4.1 Baixar com Git</h3>
  <ol>
      <li>Abra o terminal ou o Git Bash.</li>
      <li>Navegue até a pasta de sua preferência onde deseja salvar o projeto.</li>
      <li>Digite o seguinte comando para clonar o repositório:</li>
      <pre><code>git clone https://github.com/arsouza81/TVVS_OrdemServico.git</code></pre>
      <li>Aguarde até que o processo de clonagem seja concluído.</li>
  </ol>
  
  <h3>4.2 Baixar como arquivo zipado</h3>
  <ol>
      <li>Acesse o repositório através do link:</li>
      <a href="https://github.com/arsouza81/TVVS_OrdemServico">https://github.com/arsouza81/TVVS_OrdemServico</a>
      <li>Na página do repositório, clique no botão <strong>Code</strong>.</li>
      <li>Selecione a opção <strong>Download ZIP</strong>.</li>
      <li>Após o download, extraia o arquivo ZIP em uma pasta de sua preferência.</li>
  </ol>

  <h3>Imagem do site</h3>
  <p>Abaixo está uma imagem de como o site do GitHub aparecerá para você ao seguir essas instruções:</p>
  <img src="./images/images-for-readme/print.png" alt="Print da tela do repositório no GitHub">

  <h2>5. Abrindo o Projeto no Visual Studio</h2>
<p>Agora que o projeto já foi baixado, o próximo passo é abri-lo no Visual Studio. Siga as instruções abaixo:</p>

<h3>5.1 Abrir o Projeto</h3>
<ol>
    <li>Abra o Visual Studio 2022.</li>
    <li>Na tela inicial, clique em <strong>Abrir um projeto ou solução</strong>.</li>
    <li>Veja a imagem abaixo para referência:</li>
    <img src="./images/images-for-readme/print2.png" alt="Abrir um projeto ou solução no Visual Studio">
</ol>

<h3>5.2 Selecionar o Projeto</h3>
<ol>
    <li>Navegue até a pasta onde você baixou o projeto.</li>
    <li>Selecione o arquivo da solução <strong>.sln</strong> correspondente ao projeto e clique em <strong>Abrir</strong>.</li>
    <li>Veja a imagem abaixo para referência:</li>
    <img src="./images/images-for-readme/print3.png" alt="Selecionando o arquivo .sln do projeto">
</ol>

<h2>6. Configurando o appsettings.json</h2>
<p>Agora que o projeto está aberto no Visual Studio, o próximo passo é configurar o arquivo <strong>appsettings.json</strong> para ajustar as credenciais de conexão com o banco de dados.</p>
<ol>
    <li>No Visual Studio, localize o arquivo <strong>appsettings.json</strong> na árvore de arquivos do projeto.</li>
    <li>Abra o arquivo e encontre a seção <strong>ConnectionStrings</strong>.</li>
    <li>Substitua <strong>Username</strong> e <strong>Password</strong> pelas suas credenciais do MySQL.</li>
    <li>Veja a imagem abaixo para referência:</li>
    <img src="./images/images-for-readme/print4.png" alt="Editando o appsettings.json para alterar usuário e senha">
</ol>

<h2>7. Abrindo o Gerenciador de Pacotes NuGet</h2>
<p>Para realizar as migrações do banco de dados, precisamos usar o Gerenciador de Pacotes NuGet. Siga os passos abaixo para abrir o gerenciador:</p>
<ol>
    <li>No Visual Studio, vá até o menu <strong>Ferramentas</strong> (Tools) e selecione <strong>Gerenciador de Pacotes NuGet</strong>.</li>
    <li>Clique em <strong>Console do Gerenciador de Pacotes</strong> (Package Manager Console).</li>
    <li>Veja a imagem abaixo para referência:</li>
    <img src="./images/images-for-readme/print5.png" alt="Abrindo o Console do Gerenciador de Pacotes">
</ol>

<h2>8. Atualizando o Banco de Dados</h2>
<p>Com o Gerenciador de Pacotes NuGet aberto, você pode agora atualizar o banco de dados com as migrações. Siga os passos abaixo:</p>

<h3>8.1 Criando uma Migração</h3>
<ol>
    <li>Na <strong>Console do Gerenciador de Pacotes</strong>, digite o seguinte comando para criar uma migração:</li>
    <pre><code>Add-Migration NomeDaMigracao</code></pre>
    <li>Veja a imagem abaixo para referência:</li>
    <img src="./images/images-for-readme/print6.png" alt="Comando Add-Migration no Gerenciador de Pacotes">
</ol>

<h3>8.2 Atualizando o Banco de Dados</h3>
<ol>
    <li>Após criar a migração, digite o seguinte comando para atualizar o banco de dados:</li>
    <pre><code>Update-Database</code></pre>
    <li>Veja a imagem abaixo para referência:</li>
    <img src="./images/images-for-readme/print7.png" alt="Comando Update-Database no Gerenciador de Pacotes">
</ol>

<h2>9. Iniciando o Projeto</h2>
<p>Agora que todas as configurações foram feitas, o último passo é iniciar o projeto. Siga as instruções abaixo:</p>

<h3>9.1 Executando o Projeto</h3>
<ol>
    <li>Certifique-se de que o Visual Studio está configurado para rodar o projeto em <strong>https</strong>.</li>
    <li>Para iniciar o projeto, clique no botão <strong>Play</strong> no Visual Studio. O projeto será iniciado automaticamente no navegador padrão.</li>
    <li>Veja a imagem abaixo para referência:</li>
    <img src="./images/images-for-readme/print8.png" alt="Botão Play no Visual Studio para iniciar o projeto">
</ol>

<h3>9.2 Resolução de Problemas de Autorização</h3>
<ol>
    <li>Se encontrar erros relacionados à autorização ou execução no navegador padrão, você pode tentar executar o projeto em outro navegador.</li>
    <li>Copie o link do navegador que abriu e cole em outro navegador, como o Chrome ou Firefox.</li>
    <li>Veja a imagem abaixo para referência:</li>
    <img src="./images/images-for-readme/print9.png" alt="Copiando o link para abrir em outro navegador">
</ol>

<p>Com isso, o projeto estará rodando corretamente, e você poderá acessar as funcionalidades disponíveis.</p>
