# Plano de Testes - Sistema de Ordem de Serviço

- **Nome do Projeto:** Sistema Ordem de Serviço
- **Versão do Plano de Teste:** 1.0
- **Data de Criação:** 04/11/2024
- **Data de Revisão:** -
- **Nome do Gerente de Testes:** Kassia Ramos Oliveira
- **Equipe de Testes:** Alicia Caldeira da Silva, Anderson Rodrigues de Souza, Diandre Pires Bruce e Rennan de Souza Alves

## 1. Escopo e Objetivo

<p align=justify>O sistema de Ordem de Serviço foi desenvolvido para otimizar e simplificar o processo de solicitação de serviços de TI entre os servidores do Instituto Federal de Ciências Exatas e Tecnologia (ICET) e a equipe de suporte da Gerência de TI. Seu objetivo principal é criar um canal único e organizado para que os usuários possam registrar suas solicitações de maneira prática e centralizada, facilitando a gestão e o acompanhamento dessas demandas. Por meio do sistema, os usuários conseguem descrever o problema ou serviço necessário, especificar sua localização e encaminhar a solicitação diretamente para o setor responsável, tudo em uma interface de fácil acesso.</p>

<p align=justify>Além disso, o sistema de Ordem de Serviço oferece um ambiente seguro para o registro e armazenamento das informações, garantindo que todos os dados das solicitações estejam protegidos e possam ser acessados pela equipe de TI de forma estruturada. A Gerência de TI é notificada a cada nova solicitação, o que permite uma resposta ágil e direcionada às demandas. O sistema também inclui funcionalidades que permitem ao usuário acompanhar o status de suas solicitações em tempo real, desde o registro inicial até a conclusão do serviço, com atualizações automáticas e notificações sobre o andamento. Dessa forma, o sistema busca não apenas facilitar a comunicação entre os servidores e a equipe de TI, mas também aumentar a eficiência do processo de atendimento, proporcionando maior transparência e controle para ambos os lados.</p>

## 2. Características do produto a serem testadas

<p align=justify>O sistema Ordem de Serviço, é um sistema com funcionalidades básicas e objetivas, nesta parte do documento, vamos apresentar as funcionalidades classificadas para os testes, a equipe de testes desenvolveu os casos de teste na funcionalidades que julgaram mais críticas do sistema e estão descritas abaixo, juntamento com seus subcasos de testes.</p>

- Cadastro de Solicitações de Serviços
  - Validação do campo Nome
  - Validação do campo Email
  - Validação do campo Siape
  - Validação do campo Bloco
  - Validação do campo Sala
  - Validação do campo Descrição do Problema

- Login da Gerência
  - Validação do Campo Email.
  - Validação do Campo senha.


- Busca de Protocolo no sistema
  - Validação do código de protocolo para busca.

## 3. Abordagem a ser uitilizada

<p align=justify>A abordagem de teste do sistema de Ordem de Serviço define técnicas, métodos e ferramentas específicas para garantir que todas as funcionalidades e fluxos do sistema sejam validados de maneira abrangente. A abordagem inclui testes funcionais, assegurando que o sistema atenda às necessidades dos usuários do Instituto Federal de Ciências Exatas e Tecnologia (ICET).</p>

<table>
  <tr>
    <th>Item</th>
    <th colspan=4>Descrição</th>
  </tr>
  <tr>
    <td><b>Objetivo</b></td>
    <td colspan=4 aling=justify>Verificar se o processo de cadastro de solicitação de serviços atende às especificações dos requisitos, validando os campos nome, email, siape, bloco, sala e descrição do problema do formulário de cadastro de ordem de serviço.</td>
  </tr>
  <tr>
    <td><b>Técnica</b></td>
    <td colspan=2>( ) Manual</td>
    <td colspan=2>(X) Automática</td>
  </tr>
  <tr>
    <td><b>Estágio do Teste</b></td>
    <td>(X) Unidade</td>
    <td>( ) Integração</td>
    <td>( ) Sistema</td>
    <td>( ) Aceitação</td>
  </tr>
  <tr>
    <td><b>Abordagem do Teste</b></td>
    <td colspan=2>( ) Caixa Branca</td>
    <td colspan=2>(X) Caixa Preta</td>
  </tr>
  <tr>
    <td><b>Responsáveis</b></td>
    <td colspan=4>Equipe de Testes</td>
  </tr>
</table>

**Testes Funcionais:** Testar todo o fluxo do processo para o cadastro de solicitações de serviços, validando os campos nome, email, siape, bloco, sala e descrição do problema do formulário de cadastro de ordem de serviço. <br>
**Ferramentas utilizadas:** XUnit (Teste de Unidade).

## 4. Itens a serem testados

<p align = justify>Serão testados todos os campos do formulário de cadastro de solicitações de serviços que é a primeira funcionalidade, com o objetivo de verificar o fluxo para o processo de cadastro das solicitações, após será testado todos os campos do login da Gerência, e por fim a funcionalidade de busca do sistema, abaixo apresentamos os tópicos a serem testados separadamente:</p>

- Cadastro de Solicitações de Serviços
  - Validação do campo Nome
  - Validação do campo Email
  - Validação do campo Siape
  - Validação do campo Bloco
  - Validação do campo Sala
  - Validação do campo Descrição do Problema

- Login da Gerência
  - Validação do Campo Email.
  - Validação do Campo senha.


- Busca de Protocolo no sistema
  - Validação do código de protocolo para busca.


## 5. Cronograma para o Teste

<p align = justify>O cronograma do sistema de Ordem de Serviço define os prazos estimados para a execução de cada fase essencial do plano de testes, garantindo que todas as atividades sejam organizadas e realizadas dentro de um período adequado. Esse cronograma detalha o tempo necessário para preparar o ambiente de testes, definir os casos e cenários a serem testados, realizar os testes funcionais e revisar os resultados de cada etapa.</p>
<p align = justify>O planejamento temporal é fundamental para assegurar que cada fase do teste contribua para a identificação de possíveis problemas antes do lançamento do sistema. Com isso, o cronograma facilita o acompanhamento do progresso e permite ajustes quando necessário, garantindo que o sistema atenda a todos os requisitos de qualidade no prazo estabelecido. Além disso, ele ajuda a coordenar as equipes envolvidas, organizando as tarefas de modo que os recursos estejam disponíveis e as etapas possam ser realizadas sequencialmente ou em paralelo, conforme o plano do projeto. Dessa forma, o cronograma contribui diretamente para que o sistema de Ordem de Serviço seja entregue com eficiência, qualidade e dentro do período esperado.</p>

- **Semana 1:** Revisão do plano de testes e preparação do ambiente.
- **Semana 2-3:** Execução dos testes funcionais na funcionalidade de cadastro de solicitações de serviços.
- **Semana 4:** Avaliação final, relatório de bugs e liberação para produção.

## 6. Pessoal responsável pelas diferentes atividades de teste

<p align = justify>A lista dos testadores identifica detalhadamente os responsáveis por cada atividade ou etapa específica do processo de testes do sistema de Ordem de Serviço. Esse documento é fundamental para organizar e distribuir as tarefas entre a equipe de testes, garantindo que cada membro esteja ciente das suas atribuições e responsabilidades. A lista especifica quem estará encarregado de conduzir os testes funcionais, bem como os responsáveis pelo planejamento dos cenários de teste, execução dos scripts de teste automatizados e análise dos resultados obtidos.</p>
<p align = justify>Além de definir a atuação individual, a lista facilita a coordenação do trabalho em equipe, assegurando que as atividades de teste ocorram de forma integrada e eficiente. Ela também possibilita uma visão clara de quem procurar em caso de dúvidas ou problemas em cada fase do processo de testes, promovendo a comunicação entre os membros e o alinhamento dos esforços. Dessa maneira, a lista dos testadores contribui para que o processo de validação do sistema ocorra de maneira organizada e dentro dos prazos estabelecidos, assegurando que todas as funcionalidades do sistema de Ordem de Serviço sejam testadas de forma completa e minuciosa.</p>

- **Responsáveis por Testes Funcionais:** Anderson Rodrigues de Souza e Alicia Caldeira da Silva
- **Responsável por Automação de Testes:** Rennan de Souza Alves
- **Gerente de Testes:** Kassia Ramos Oliveira
- **Analista de Qualidade:** Diandre Pires Bruce

## 7. Os riscos associados aos testes

<p align = justify>Os riscos associados ao processo de testes incluem possíveis problemas que podem afetar a execução das atividades de validação ou o sucesso do sistema. Identificar e planejar a mitigação desses riscos é essencial para manter o cronograma de testes e assegurar a entrega de um produto de alta qualidade.</p>

**Riscos Específicos para o Sistema de Ordem de Serviço:**

- **Dependência de Integração com Serviços Internos:** Caso o serviço de envio de acesso ao banco de dados não esteja plenamente operacional no ambiente de testes, a execução pode ser comprometida, resultando em atrasos e dificuldade para simular adequadamente as funcionalidades.
- **Recursos Limitados na Equipe de Testes:** Se o número de testadores for insuficiente para cobrir todos os casos e cenários dentro do prazo estipulado, isso poderá resultar em falhas de cobertura dos testes. Isso afetaria a identificação de possíveis problemas no sistema, especialmente em casos de uso menos frequentes mas críticos para a operação.
- **Ambiente de Teste Não Alinhado com o Ambiente Real:** Caso o ambiente de testes não simule com precisão o ambiente de produção, há o risco de que certos problemas não sejam detectados durante os testes, resultando em falhas quando o sistema estiver em uso.

<p align = justify>Esses riscos devem ser continuamente monitorados e, sempre que possível, medidas preventivas e planos de contingência devem ser implementados para reduzir o impacto no processo de testes e garantir a entrega de um sistema de Ordem de Serviço confiável e eficiente.</p>

<br>

# Especificação dos Casos de Teste

## 1. Caracterização do Caso de Teste

<p align = justify>Cada caso de teste representa uma situação particular ou uma funcionalidade específica do Sistema de Ordem de Serviço que deve ser analisada detalhadamente. Através desses testes, verifica-se o comportamento do sistema em diferentes cenários, garantindo que ele esteja executando corretamente as tarefas para as quais foi projetado. Essa abordagem é essencial para identificar possíveis erros ou falhas, permitindo que sejam feitos ajustes antes que o sistema seja utilizado em um ambiente de produção. Assim, os casos de teste são uma ferramenta importante para assegurar que o sistema atende aos requisitos definidos e funciona de acordo com as expectativas dos usuários.</p>

<p align = justify>Abaixo vamos apresentar os casos de teste elaborados a partir das classes de equivalência feitas para cada funcionalidade, vamos separar os casos de teste por cada funcionalidade apresentada anteriormente. Para uma funcionalidade foi possível criar mais de 1 classe de equivalência e automaticamente os seus subcasos de teste:</p>

- Cadastro de Solicitações de Serviços


<table border="1">
  <tr>
    <th>Identificador</th>
    <td>CT-01</td>
  </tr>
  <tr>
    <th>Caso de teste</th>
    <td>Finalizar o cadastro de solicitação de serviço</td>
  </tr>
  <tr>
    <th>Descrição</th>
    <td>Verificar se os campos do cadastro de solicitação de serviço foram preenchidos corretamente.</td>
  </tr>
  <tr>
    <th>Entradas</th>
    <td>. Nome: "Leilane Cardoso".<br>. Email: "leilCardoso@ufam.edu.br".<br>. Siape: "1234567".<br>. Bloco: "C".<br>. Sala: "301".<br>. Descrição do Problema: "Computador reiniciando automaticamente"</td>
  </tr>
  <tr>
    <th>Resultados Esperados</th>
    <td>. Se os campos estiverem preenchidos corretamente, o cadastro da solicitação é realizado com sucesso.<br>. Se os campos não estiverem preenchidos corretamente, uma mensagem de erro deve ser exibida informando o campo e o erro a serem corrigidos.</td>
  </tr>
  <tr>
    <th>Critérios para Aprovação/Rejeição</th>
    <td>. Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.</td>
  </tr>
  <tr>
    <th>Recursos para o Caso de Teste</th>
    <td>. Ambiente de Teste: Navegador e banco de dados do sistema. . Ferramentas: XUnit</td>
  </tr>
  <tr>
    <th>Restrições de Uso</th>
    <td>. Todos os campos devem ser preenchidos corretamente.</td>
  </tr>
  <tr>
    <th>Dependências</th>
    <td>Não se aplica</td>
  </tr>
  <tr>
    <th>Observações Adicionais</th>
    <td>. Realizar testes com diversos dados para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
  </tr>
</table>

<br>

<table border="1">
  <tr>
    <th>Identificador</th>
    <td>CT-02</td>
  </tr>
  <tr>
    <th>Caso de teste</th>
    <td>Validar o campo nome para finalizar o cadastro de solicitação de serviço</td>
  </tr>
  <tr>
    <th>Descrição</th>
    <td>Verificar se o nome do solicitante é informado corretamente, sendo composto apenas por letras</td>
  </tr>
  <tr>
    <th>Entradas</th>
    <td>. Nome: "Leil4ne Cardoso"</td>
  </tr>
  <tr>
    <th>Resultados Esperados</th>
    <td>. Se o nome for composto apenas por letras, o cadastro da solicitação é realizado com sucesso.<br>. Se o nome não for composto apenas por letras, uma mensagem de erro deve ser exibida informando o erro.</td>
  </tr>
  <tr>
    <th>Critérios para Aprovação/Rejeição</th>
    <td>. Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.</td>
  </tr>
  <tr>
    <th>Recursos para o Caso de Teste</th>
    <td>. Ambiente de Teste: Navegador e banco de dados do sistema.<br>. Ferramentas: XUnit</td>
  </tr>
  <tr>
    <th>Restrições de Uso</th>
    <td>. O nome é um campo obrigatório e deve conter apenas letras, não pode ter dígitos, caracteres especiais</td>
  </tr>
  <tr>
    <th>Dependências</th>
    <td>Não se aplica</td>
  </tr>
  <tr>
    <th>Observações Adicionais</th>
    <td>. Realizar testes com diferentes sequências de nomes para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
  </tr>
</table>

<br>

<table border="1">
  <tr>
    <th>Identificador</th>
    <td>CT-03</td>
  </tr>
  <tr>
    <th>Caso de teste</th>
    <td>Validar o campo nome para finalizar o cadastro de solicitação de serviço</td>
  </tr>
  <tr>
    <th>Descrição</th>
    <td>Verificar se o nome do solicitante é informado corretamente, sendo composto apenas por letras</td>
  </tr>
  <tr>
    <th>Entradas</th>
    <td>. Nome: "Leil#ne Cardoso"</td>
  </tr>
  <tr>
    <th>Resultados Esperados</th>
    <td>. Se o nome for composto apenas por letras, o cadastro da solicitação é realizado com sucesso.<br>. Se o nome não for composto apenas por letras, uma mensagem de erro deve ser exibida informando o erro.</td>
  </tr>
  <tr>
    <th>Critérios para Aprovação/Rejeição</th>
    <td>. Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.</td>
  </tr>
  <tr>
    <th>Recursos para o Caso de Teste</th>
    <td>. Ambiente de Teste: Navegador e banco de dados do sistema.<br>. Ferramentas: XUnit</td>
  </tr>
  <tr>
    <th>Restrições de Uso</th>
    <td>. O nome é um campo obrigatório e deve conter apenas letras, não pode ter dígitos, caracteres especiais</td>
  </tr>
  <tr>
    <th>Dependências</th>
    <td>Não se aplica</td>
  </tr>
  <tr>
    <th>Observações Adicionais</th>
    <td>. Realizar testes com diferentes sequências de nomes para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
  </tr>
</table>

<br>

<table border="1">
  <tr>
    <th>Identificador</th>
    <td>CT-04</td>
  </tr>
  <tr>
    <th>Caso de teste</th>
    <td>Validar o campo nome para finalizar o cadastro de solicitação de serviço</td>
  </tr>
  <tr>
    <th>Descrição</th>
    <td>Verificar se o nome do solicitante é informado corretamente, sendo composto apenas por letras</td>
  </tr>
  <tr>
    <th>Entradas</th>
    <td>Nome: "    "</td>
  </tr>
  <tr>
    <th>Resultados Esperados</th>
    <td>. Se o nome for composto apenas por letras, o cadastro da solicitação é realizado com sucesso.<br>. Se o nome não for composto apenas por letras, uma mensagem de erro deve ser exibida informando o erro.</td>
  </tr>
  <tr>
    <th>Critérios para Aprovação/Rejeição</th>
    <td>. Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.</td>
  </tr>
  <tr>
    <th>Recursos para o Caso de Teste</th>
    <td>. Ambiente de Teste: Navegador e banco de dados do sistema.<br>. Ferramentas: XUnit</td>
  </tr>
  <tr>
    <th>Restrições de Uso</th>
    <td>O nome é um campo obrigatório e deve conter apenas letras, não podendo ter dígitos e caracteres especiais</td>
  </tr>
  <tr>
    <th>Dependências</th>
    <td>Não se aplica</td>
  </tr>
  <tr>
    <th>Observações Adicionais</th>
    <td>. Realizar testes com diferentes sequências de nomes para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
  </tr>
</table>

<br>

<table border="1">
  <tr>
    <th>Identificador</th>
    <td>CT-05</td>
  </tr>
  <tr>
    <th>Caso de teste</th>
    <td>Validar o campo email para finalizar o cadastro de solicitação de serviço</td>
  </tr>
  <tr>
    <th>Descrição</th>
    <td>Verificar se o email do solicitante é informado corretamente, seguindo o domínio padrão da UFAM (nome@ufam.edu.br)</td>
  </tr>
  <tr>
    <th>Entradas</th>
    <td>Email: "leilCardoso@gmail.com"</td>
  </tr>
  <tr>
    <th>Resultados Esperados</th>
    <td>. Se o email seguir o domínio padrão da UFAM (nome@ufam.edu.br), o cadastro da solicitação é realizado com sucesso.<br>. Se o email não seguir o domínio padrão da UFAM (nome@ufam.edu.br), uma mensagem de erro deve ser exibida informando o erro.</td>
  </tr>
  <tr>
    <th>Critérios para Aprovação/Rejeição</th>
    <td>. Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.</td>
  </tr>
  <tr>
    <th>Recursos para o Caso de Teste</th>
    <td>Ambiente de Teste: Navegador e banco de dados do sistema.<br>. Ferramentas: XUnit</td>
  </tr>
  <tr>
    <th>Restrições de Uso</th>
    <td>O email é um campo obrigatório e deve seguir o domínio padrão da UFAM (nome@ufam.edu.br)</td>
  </tr>
  <tr>
    <th>Dependências</th>
    <td>O caso de teste "Validar o campo email para finalizar o cadastro de solicitação de serviço" depende do caso de teste "Validar o campo nome para finalizar o cadastro de solicitação de serviço".</td>
  </tr>
  <tr>
    <th>Observações Adicionais</th>
    <td>. Realizar testes com diferentes domínios de emails para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
  </tr>
</table>

<br>

<table border="1">
  <tr>
    <th>Identificador</th>
    <td>CT-06</td>
  </tr>
  <tr>
    <th>Caso de teste</th>
    <td>Validar o campo email para finalizar o cadastro de solicitação de serviço</td>
  </tr>
  <tr>
    <th>Descrição</th>
    <td>Verificar se o email do solicitante é informado corretamente, seguindo o domínio padrão da UFAM (nome@ufam.edu.br)</td>
  </tr>
  <tr>
    <th>Entradas</th>
    <td>Email: " "</td>
  </tr>
  <tr>
    <th>Resultados Esperados</th>
    <td>. Se o email seguir o domínio padrão da UFAM (nome@ufam.edu.br), o cadastro da solicitação é realizado com sucesso.<br>. Se o email não seguir o domínio padrão da UFAM (nome@ufam.edu.br), uma mensagem de erro deve ser exibida informando o erro.</td>
  </tr>
  <tr>
    <th>Critérios para Aprovação/Rejeição</th>
    <td>. Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.</td>
  </tr>
  <tr>
    <th>Recursos para o Caso de Teste</th>
    <td>Ambiente de Teste: Navegador e banco de dados do sistema. Ferramentas: XUnit</td>
  </tr>
  <tr>
    <th>Restrições de Uso</th>
    <td>O email é um campo obrigatório e deve seguir o domínio padrão da UFAM (nome@ufam.edu.br)</td>
  </tr>
  <tr>
    <th>Dependências</th>
    <td>O caso de teste "Validar o campo email para finalizar o cadastro de solicitação de serviço" depende do caso de teste "Validar o campo nome para finalizar o cadastro de solicitação de serviço".</td>
  </tr>
  <tr>
    <th>Observações Adicionais</th>
    <td>. Realizar testes com diferentes domínios de emails para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
  </tr>
</table>

<br>

<table border="1">
    <tr>
        <th>Identificador</th>
        <td>CT-07</td>
    </tr>
    <tr>
        <th>Caso de teste</strong></th>
        <td>Validar o campo siape para finalizar o cadastro de solicitação de serviço</td>
    </tr>
    <tr>
        <th>Descrição</th>
        <td>Verificar se o siape do solicitante é informado corretamente, sendo composto por 7 dígitos (0-9)</td>
    </tr>
    <tr>
        <th>Entradas</th>
        <td>Siape: "123d567"</td>
    </tr>
    <tr>
        <th>Resultados Esperados</th>
        <td>
            . Se o siape for composto, exatamente, por 7 dígitos (0-9), o cadastro da solicitação é realizado com sucesso.<br>. Se o siape não for composto por apenas dígitos, ou for composto por mais de 7 dígitos, ou for composto por menos de 7 dígitos, uma mensagem de erro deve ser exibida informando o erro.
        </td>
    </tr>
    <tr>
        <th>Critérios para Aprovação/Rejeição</th>
        <td>
            . Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.
        </td>
    </tr>
    <tr>
        <th>Recursos para o Caso de Teste</th>
        <td>
            . Ambiente de Teste: Navegador e banco de dados do sistema. <br>. Ferramentas: XUnit
        </td>
    </tr>
    <tr>
        <td><strong>Restrições de Uso</strong></td>
        <td>O siape é um campo obrigatório e deve ser composto por 7 dígitos (0-9).</td>
    </tr>
    <tr>
        <th>Dependências</th>
        <td>O caso de teste "Validar o campo siape para finalizar o cadastro de solicitação de serviço" depende do caso de teste "Validar o campo email para finalizar o cadastro de solicitação de serviço".</td>
    </tr>
    <tr>
        <th>Observações Adicionais</th>
        <td>. Realizar testes com diferentes sequências de dígitos, letras e caracteres especiais para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
    </tr>
</table>

<br>

<table border="1">
    <tr>
        <th>Identificador</th>
        <td>CT-08</td>
    </tr>
    <tr>
        <th>Caso de teste</th>
        <td>Validar o campo siape para finalizar o cadastro de solicitação de serviço</td>
    </tr>
    <tr>
        <th>Descrição</th>
        <td>Verificar se o siape do solicitante é informado corretamente, sendo composto por 7 dígitos (0-9)</td>
    </tr>
    <tr>
        <th>Entradas</th>
        <td>Siape: "!234567"</td>
    </tr>
    <tr>
        <th>Resultados Esperados</th>
        <td>
            . Se o siape for composto, exatamente, por 7 dígitos (0-9), o cadastro da solicitação é realizado com sucesso.<br>. Se o siape não for composto por apenas dígitos, ou for composto por mais de 7 dígitos, ou for composto por menos de 7 dígitos, uma mensagem de erro deve ser exibida informando o erro.
        </td>
    </tr>
    <tr>
        <th>Critérios para Aprovação/Rejeição</th>
        <td>
            . Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.
        </td>
    </tr>
    <tr>
        <th>Recursos para o Caso de Teste</th>
        <td>
            . Ambiente de Teste: Navegador e banco de dados do sistema.<br>. Ferramentas: XUnit
        </td>
    </tr>
    <tr>
       <th>Restrições de Uso</th>
        <td>O siape é um campo obrigatório e deve ser composto por 7 dígitos (0-9).</td>
    </tr>
    <tr>
        <th>Dependências</th>
        <td>O caso de teste "Validar o campo siape para finalizar o cadastro de solicitação de serviço" depende do caso de teste "Validar o campo email para finalizar o cadastro de solicitação de serviço".</td>
    </tr>
    <tr>
        <th>Observações Adicionais</th>
        <td>. Realizar testes com diferentes sequências de dígitos, letras e caracteres especiais para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
    </tr>
</table>

<br>

<table border="1">
    <tr>
        <th>Identificador</th>
        <td>CT-09</td>
    </tr>
    <tr>
        <th>Caso de teste</th>
        <td>Validar o campo siape para finalizar o cadastro de solicitação de serviço</td>
    </tr>
    <tr>
        <th>Descrição</th>
        <td>Verificar se o siape do solicitante é informado corretamente, sendo composto por 7 dígitos (0-9)</td>
    </tr>
    <tr>
        <th>Entradas</th>
        <td>Siape: "123456"</td>
    </tr>
    <tr>
        <th>Resultados Esperados</th>
        <td>
            . Se o siape for composto, exatamente, por 7 dígitos (0-9), o cadastro da solicitação é realizado com sucesso.<br>. Se o siape não for composto por apenas dígitos, ou for composto por mais de 7 dígitos, ou for composto por menos de 7 dígitos, uma mensagem de erro deve ser exibida informando o erro.
        </td>
    </tr>
    <tr>
        <th>Critérios para Aprovação/Rejeição</th>
        <td>
            . Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.
        </td>
    </tr>
    <tr>
        <th>Recursos para o Caso de Teste</th>
        <td>
            . Ambiente de Teste: Navegador e banco de dados do sistema.<br>. Ferramentas: XUnit.
        </td>
    </tr>
    <tr>
        <th>Restrições de Uso</th>
        <td>O siape é um campo obrigatório e deve ser composto por 7 dígitos (0-9).</td>
    </tr>
    <tr>
        <th>Dependências</th>
        <td>O caso de teste "Validar o campo siape para finalizar o cadastro de solicitação de serviço" depende do caso de teste "Validar o campo email para finalizar o cadastro de solicitação de serviço".</td>
    </tr>
    <tr>
        <th>Observações Adicionais</th>
        <td>. Realizar testes com diferentes sequências de dígitos, letras e caracteres especiais para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
    </tr>
</table>

<br>

<table border="1">
    <tr>
        <th>Identificador</th>
        <td>CT-10</td>
    </tr>
    <tr>
        <th>Caso de teste</th>
        <td>Validar o campo siape para finalizar o cadastro de solicitação de serviço</td>
    </tr>
    <tr>
        <th>Descrição</th>
        <td>Verificar se o siape do solicitante é informado corretamente, sendo composto por 7 dígitos (0-9)</td>
    </tr>
    <tr>
        <th>Entradas</th>
        <td>Siape: "12345678"</td>
    </tr>
    <tr>
        <th>Resultados Esperados</th>
        <td>
            . Se o siape for composto, exatamente, por 7 dígitos (0-9), o cadastro da solicitação é realizado com sucesso.<br>. Se o siape não for composto por apenas dígitos, ou for composto por mais de 7 dígitos, ou for composto por menos de 7 dígitos, uma mensagem de erro deve ser exibida informando o erro.
        </td>
    </tr>
    <tr>
        <th>Critérios para Aprovação/Rejeição</th>
        <td>
            . Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.
        </td>
    </tr>
    <tr>
        <th>Recursos para o Caso de Teste</th>
        <td>
            . Ambiente de Teste: Navegador e banco de dados do sistema.<br>. Ferramentas: XUnit.
        </td>
    </tr>
    <tr>
        <th>Restrições de Uso</th>
        <td>O siape é um campo obrigatório e deve ser composto por 7 dígitos (0-9).</td>
    </tr>
    <tr>
        <th>Dependências</th>
        <td>O caso de teste "Validar o campo siape para finalizar o cadastro de solicitação de serviço" depende do caso de teste "Validar o campo email para finalizar o cadastro de solicitação de serviço".</td>
    </tr>
    <tr>
        <th>Observações Adicionais</th>
        <td>. Realizar testes com diferentes sequências de dígitos, letras e caracteres especiais para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
    </tr>
</table>

<br>

<table border="1">
    <tr>
        <th>Identificador</th>
        <td>CT-11</td>
    </tr>
    <tr>
        <th>Caso de teste</th>
        <td>Validar o campo siape para finalizar o cadastro de solicitação de serviço</td>
    </tr>
    <tr>
        <th>Descrição</th>
        <td>Verificar se o siape do solicitante é informado corretamente, sendo composto por 7 dígitos (0-9)</td>
    </tr>
    <tr>
        <th>Entradas</th>
        <td>Siape: "  "</td>
    </tr>
    <tr>
        <th>Resultados Esperados</th>
        <td>
            . Se o siape for composto, exatamente, por 7 dígitos (0-9), o cadastro da solicitação é realizado com sucesso.<br>. Se o siape não for composto por apenas dígitos, ou for composto por mais de 7 dígitos, ou for composto por menos de 7 dígitos, uma mensagem de erro deve ser exibida informando o erro.
        </td>
    </tr>
    <tr>
        <th>Critérios para Aprovação/Rejeição</th>
        <td>
            . Aprovação: O cadastro da solicitação de serviço é realizado com sucesso.<br>. Rejeição: O cadastro da solicitação de serviço não é realizado e o sistema exibe uma mensagem informando o erro.
        </td>
    </tr>
    <tr>
        <th>Recursos para o Caso de Teste</th>
        <td>
            . Ambiente de Teste: Navegador e banco de dados do sistema.<br>. Ferramentas: XUnit
        </td>
    </tr>
    <tr>
        <th>Restrições de Uso</th>
        <td>O siape é um campo obrigatório e deve ser composto por 7 dígitos (0-9).</td>
    </tr>
    <tr>
        <th>Dependências</th>
        <td>O caso de teste "Validar o campo siape para finalizar o cadastro de solicitação de serviço" depende do caso de teste "Validar o campo email para finalizar o cadastro de solicitação de serviço".</td>
    </tr>
    <tr>
        <th>Observações Adicionais</th>
        <td>. Realizar testes com diferentes sequências de dígitos, letras e caracteres especiais para garantir a eficácia e a cobertura dos testes.<br>. Documentar quaisquer anomalias ou comportamentos inesperados.</td>
    </tr>
</table>

<br>

- Login da Gerência:


| Identificador               | CT-01                                            |
|-----------------------------|--------------------------------------------------|
| **Caso de Teste**           | Efetuar o login da gerência do sistema           |
| **Descrição**               | Verificar se o login da gerência no sistema é feito da forma correta, com os campos email e senha preenchidos e existentes no sistema. |
| **Entradas**                | - Email Institucional válido: `anderson.souza@ufam.edu.br`<br>- Senha válida: `12345678` |
| **Resultados Esperados**    | - Com o email `anderson.souza@ufam.edu.br` e a senha `12345678`, o cadastro do usuário é encontrado e é exibida a tela de acesso da gerência.<br>- Se os dados de login forem inseridos de forma incorreta, uma mensagem de erro deve ser exibida. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O perfil é encontrado no sistema e é exibida ao usuário a tela de controle da gerência.<br>- **Rejeição**: O sistema não encontra o perfil, não exibe a tela de acesso e exibe mensagens de erro ao usuário. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador e Banco de Dados do Sistema.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - O email deve estar exatamente no formato institucional e deve ter sido registrado no sistema.<br>- A senha deve conter no mínimo 8 caracteres e deve estar relacionada com o email informado. |
| **Dependências**            | - Não há dependências.                           |
| **Observações Adicionais**  | - Realizar testes com diferentes emails e senhas para garantir a cobertura da funcionalidade.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-02                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Efetuar login com e-mail fora do formato institucional |
| **Descrição**               | Verifique se o sistema exibe uma mensagem de erro ao tentar fazer login com e-mail fora do formato institucional. |
| **Entradas**                | - E-mail: `anderson.souza@gmail.com`<br>- Senha: `12345678` |
| **Resultados Esperados**    | - O sistema exibe uma mensagem de erro informando que o e-mail é fora do formato institucional. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe mensagem de erro sobre o formato incorreto do e-mail.<br>- **Rejeição**: O sistema aceita o e-mail ou exibe uma mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - O e-mail não deve seguir o formato institucional. |
| **Dependências**            | - Não há dependências.                               |
| **Observações Adicionais**  | - Verificar se o sistema exibe mensagens de erro; se sim, analisar a clareza da mensagem de erro exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-03                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Efetuar login com e-mail válido, mas não registrado  |
| **Descrição**               | Verifique se o sistema exibe uma mensagem de erro ao tentar fazer login com um e-mail válido que não está registrado no sistema. |
| **Entradas**                | - E-mail: `inexistente@ufam.edu.br`<br>- Senha: `12345678` |
| **Resultados Esperados**    | - O sistema exibe uma mensagem de erro que o e-mail não foi encontrado no sistema. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe uma mensagem de erro sobre o e-mail não registrado.<br>- **Rejeição**: O sistema permite o login ou exibe uma mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - O e-mail deve ser institucional, mas não ser registrado no sistema. |
| **Dependências**            | - Não há dependências.                               |
| **Observações Adicionais**  | - Verificar se o sistema exibe mensagens de erro; se sim, analisar a clareza da mensagem de erro exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-04                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Efetuar login com e-mail incompleto                  |
| **Descrição**               | Verifique se o sistema exibe uma mensagem de erro ao tentar fazer login com um e-mail institucional incompleto. |
| **Entradas**                | - E-mail: `anderson.souza@ufam`<br>- Senha: `12345678` |
| **Resultados Esperados**    | - O sistema exibe uma mensagem de erro informando que o e-mail está incompleto. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe mensagem de erro sobre o e-mail incompleto.<br>- **Rejeição**: O sistema aceita o e-mail ou exibe uma mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - O e-mail deve estar incompleto e não registrado.   |
| **Dependências**            | - Não há dependências.                               |
| **Observações Adicionais**  | - Testar diferentes formatos de e-mails incompletos.<br>- Verificar se o sistema exibe mensagens de erro; se sim, analisar a clareza da mensagem de erro exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-05                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Efetuar login com campo de e-mail vazio              |
| **Descrição**               | Verifique se o sistema exibe uma mensagem de erro ao tentar fazer login sem preencher o campo de e-mail. |
| **Entradas**                | - E-mail: vazio<br>- Senha: `12345678`               |
| **Resultados Esperados**    | - O sistema exibe uma mensagem de erro solicitando o preenchimento do campo de e-mail. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe mensagem de erro sobre o e-mail não informado.<br>- **Rejeição**: O sistema permite o login ou exibe uma mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - O campo de e-mail deve estar vazio.               |
| **Dependências**            | - Não há dependências.                               |
| **Observações Adicionais**  | - Testar senhas diferentes para garantir cobertura.<br>- Verificar se o sistema exibe mensagens de erro; se sim, analisar a clareza da mensagem de erro exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-06                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Efetuar login com senha de menos de 8 caracteres     |
| **Descrição**               | Verifique se o sistema exibe uma mensagem de erro ao tentar fazer login com uma senha com menos de 8 caracteres. |
| **Entradas**                | - E-mail: `anderson.souza@ufam.edu.br`<br>- Senha: `123456` |
| **Resultados Esperados**    | - O sistema exibe uma mensagem de erro informando que a senha deve ter no mínimo 8 caracteres. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe mensagem de erro sobre uma senha incompleta.<br>- **Rejeição**: O sistema permite o login ou exibe uma mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - A senha deve ter menos de 8 caracteres.            |
| **Dependências**            | - Não há dependências.                               |
| **Observações Adicionais**  | - Testar senhas diferentes com menos de 8 caracteres para garantir cobertura.<br>- Verificar se o sistema exibe mensagens de erro; se sim, analisar a clareza da mensagem de erro exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-07                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Efetuar login com senha não registrada no sistema    |
| **Descrição**               | Verifique se o sistema exibe uma mensagem de erro ao tentar fazer login com uma senha incorreta. |
| **Entradas**                | - E-mail: `anderson.souza@ufam.edu.br`<br>- Senha: `08765423` |
| **Resultados Esperados**    | - O sistema exibe uma mensagem de erro informando que a senha não foi encontrada no sistema. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe mensagem de erro sobre a senha incorreta.<br>- **Rejeição**: O sistema permite o login ou exibe uma mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - A senha deve ser diferente da cadastrada para o e-mail informado. |
| **Dependências**            | - Não há dependências.                               |
| **Observações Adicionais**  | - Testar senhas diferentes para garantir cobertura.<br>- Verificar se o sistema exibe mensagens de erro; se sim, analisar a clareza da mensagem de erro exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |



| Identificador               | CT-08                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Efetuar login com campo de senha vazio               |
| **Descrição**               | Verifique se o sistema exibe uma mensagem de erro ao tentar fazer login sem preencher o campo de senha. |
| **Entradas**                | - E-mail: `anderson.souza@ufam.edu.br`<br>- Senha: vazio |
| **Resultados Esperados**    | - O sistema exibe uma mensagem de erro solicitando o preenchimento do campo de senha. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe mensagem de erro sobre a senha não informada.<br>- **Rejeição**: O sistema permite o login ou exibe uma mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - O campo de senha deve estar vazio.                |
| **Dependências**            | - Não há dependências.                               |
| **Observações Adicionais**  | - Testar com diferentes e-mails para garantir cobertura.<br>- Verificar se o sistema exibe mensagens de erro; se sim, analisar a clareza da mensagem de erro exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


- Busca de Protocolo:

| Identificador               | CT-01                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Busca de Protocolo da Solicitação de Serviço        |
| **Descrição**               | Verificar se o código de protocolo é aplicado corretamente com 8 caracteres e se este existe no sistema. |
| **Entradas**                | Código de Protocolo Válido: `L578MQ04`               |
| **Resultados Esperados**    | - Com o código `L578MQ04`, a busca da solicitação de serviço é realizada com sucesso no sistema e exibida ao usuário. <br> - Código inválido exibe mensagem de erro. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O código é encontrado e a solicitação cadastrada é exibida ao usuário.<br>- **Rejeição**: O sistema não encontra o código, exibe erro e não exibe resultados. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador e Banco de Dados do Sistema.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - O código deve conter exatamente 8 caracteres.<br>- O código deve estar registrado no sistema. |
| **Dependências**            | O caso de teste "Busca de Protocolo da Solicitação de Serviço" depende do caso de teste "Finalizar o Cadastro de Solicitação de Serviço". |
| **Observações Adicionais**  | - Realizar testes com diferentes códigos, para garantir a cobertura.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-02                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Busca de Protocolo da Solicitação de Serviço com Código Inexistente |
| **Descrição**               | Verificar se o sistema responde corretamente ao tentar buscar um protocolo de 8 caracteres que não está registrado no sistema. |
| **Entradas**                | Código de Protocolo Inválido: `BHDSSAA`               |
| **Resultados Esperados**    | Exibir mensagem de erro indicando que o código não foi encontrado no sistema. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe uma mensagem clara indicando que o código não foi encontrado.<br>- **Rejeição**: O sistema realiza a busca e exibe resultados incorretos. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador e Banco de Dados do Sistema.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | - O código deve conter exatamente 8 caracteres.<br>- O código testado não deve estar registrado no sistema. |
| **Dependências**            | Não há dependências. |
| **Observações Adicionais**  | - Verificar a clareza e o conteúdo da mensagem de erro exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-03                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Busca de Protocolo da Solicitação de Serviço com Campo Vazio |
| **Descrição**               | Verificar se o sistema responde corretamente ao tentar buscar uma solicitação sem informar o código de protocolo. |
| **Entradas**                | Código de Protocolo: Campo deixado em branco. |
| **Resultados Esperados**    | Exibir mensagem de erro solicitando o preenchimento do campo de código de protocolo. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema não realiza a busca e exibe uma mensagem clara informando a necessidade de preenchimento do campo.<br>- **Rejeição**: O sistema permite a busca sem código ou exibe mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador e Banco de Dados do Sistema.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | O campo de código de protocolo deve estar vazio. |
| **Dependências**            | Não há dependências. |
| **Observações Adicionais**  | - Avaliar a clareza da mensagem exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-04                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Busca de Protocolo da Solicitação de Serviço com Código de Mais de 8 Caracteres |
| **Descrição**               | Verificar se o sistema responde corretamente ao tentar buscar uma solicitação com código de protocolo contendo mais de 8 caracteres. |
| **Entradas**                | Código de Protocolo: `L123AB4567` |
| **Resultados Esperados**    | Exibir mensagem de erro informando que o código de protocolo deve ter exatamente 8 caracteres. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe uma mensagem clara sobre o formato incorreto do código.<br>- **Rejeição**: O sistema permite a busca ou exibe uma mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador e Banco de Dados do Sistema.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | O código de protocolo deve conter mais de 8 caracteres. |
| **Dependências**            | Não há dependências. |
| **Observações Adicionais**  | - Avaliar a clareza da mensagem exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |


| Identificador               | CT-05                                                |
|-----------------------------|------------------------------------------------------|
| **Caso de Teste**           | Busca de Protocolo da Solicitação de Serviço com Código de Menos de 8 Caracteres |
| **Descrição**               | Verificar se o sistema responde corretamente ao tentar buscar uma solicitação com código de protocolo contendo menos de 8 caracteres. |
| **Entradas**                | Código de Protocolo: `L12AB34` |
| **Resultados Esperados**    | Exibir mensagem de erro informando que o código de protocolo deve ter exatamente 8 caracteres. |
| **Critérios para Aprovação/Rejeição** | - **Aprovação**: O sistema exibe uma mensagem clara sobre o formato incorreto do código.<br>- **Rejeição**: O sistema permite a busca ou exibe uma mensagem incorreta. |
| **Recursos para o Caso de Teste** | - **Ambiente de Teste**: Navegador e Banco de Dados do Sistema.<br>- **Ferramentas**: XUnit. |
| **Restrições de Uso**       | O código de protocolo deve conter menos de 8 caracteres. |
| **Dependências**            | Não há dependências. |
| **Observações Adicionais**  | - Avaliar a clareza da mensagem exibida ao usuário.<br>- Documentar quaisquer anomalias ou comportamentos inesperados. |



## 2. Especificação de Entradas, Resultados Esperados e Casos de Testes

<p align = justify>Esta seção abordará em detalhes as diferentes entradas que o sistema deverá processar, especificando os resultados esperados para cada uma dessas entradas ao serem analisadas. O objetivo é descrever como o sistema deve responder em cada situação prevista, garantindo que o comportamento seja conforme esperado. Para alcançar essa validação de forma eficiente, será aplicada a técnica de particionamento por classes de equivalência.</p>

<p align = justify> A técnica de particionamento por classes de equivalência, amplamente utilizada em testes de software, consiste em dividir o conjunto de possíveis entradas em classes de equivalência, onde cada classe representa um grupo de dados que o sistema processa de maneira semelhante. As classes de equivalência incluem tanto entradas válidas, que o sistema deve aceitar e processar, quanto entradas inválidas, que o sistema deve identificar e rejeitar adequadamente. Com esse método, é possível reduzir o número de testes necessários, focando apenas em casos representativos que têm maior probabilidade de revelar falhas, minimizando o esforço enquanto se maximiza a detecção de possíveis erros no sistema</p>
<br>

## 3. Abordagem a ser utilizada

<p align = justify>Nesta seção apresentaremos as tabelas de classes de quivalência elaboradas para cada funcionalidade, juntamente com a tabela dos casos de teste que foram especificados anteriormente.</p>

- Cadastro de Solicitações de Serviços:

<table border="1">
  <tr> 
    <th  colspan =7>Classes de Equivalência</th>
  </tr>
  <tr>
    <th>Condição de Entrada</th>
    <th>Classes Válidas</th>
    <th>Classes Inválidas</th>
    <th>Classes Inválidas</th>
    <th>Classes Inválidas</th>
    <th>Classes Inválidas</th>
    <th>Classes Inválidas</th>
  </tr>
  <tr>
    <td>Nome</td>
    <td>1) somente letras (A-Z, a-z)</td>
    <td>2) contém dígitos (0-9)</td>
    <td>3) contém caracteres especiais (#, @, !, entre outros)</td>
    <td>4) campo vazio</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Email</td>
    <td>5) domínio padrão da ufam (nome@ufam.edu.br)</td>
    <td>6) fora do domínio padrão da ufam</td>
    <td>7) campo vazio</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Siape</td>
    <td>8) 7 dígitos (0-9)</td>
    <td>9) contém letras (A-Z, a-z)</td>
    <td>10) contém caracteres especiais (#, @, !, entre outros)</td>
    <td>11) menos de 7 dígitos</td>
    <td>12) mais de 7 dígitos</td>
    <td>13) campo vazio</td>
  </tr>
  <tr>
    <td>Bloco</td>
    <td>14) 1 letra (A-F, a-f)</td>
    <td>15) letras fora do intervalo (G-Z, g-z)</td>
    <td>16) contém dígito (0-9)</td>
    <td>17) contém caractere especial (#, @, !)</td>
    <td>18) contém mais de 1 letra</td>
    <td>19) campo vazio</td>
  </tr>
  <tr>
    <td>Sala</td>
    <td>20) três dígitos (0-9)</td>
    <td>21) contém letras (A-Z, a-z)</td>
    <td>22) contém caracteres especiais (#, @, !, entre outros)</td>
    <td>23) contém mais de 3 dígitos</td>
    <td>24) contém menos de 3 dígitos</td>
    <td>25) campo vazio</td>
  </tr>
  <tr>
    <td>Descrição do Problema</td>
    <td>26) máximo 300 caracteres alfanuméricos (A-Z, a-z, 0-9)</td>
    <td>27) mais de 300 caracteres alfanuméricos</td>
    <td>28) campo vazio</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
</table>

<br>

<table border="1">
  <tr> 
    <th  colspan =7>Casos de Testes</th>
  </tr>
  <tr>
    <th>Nº Caso de Teste</th>
    <th>Classes de Equivalência</th>
    <th>Entradas</th>
    <th>Resultado Esperado</th>
  </tr>
  <tr>
    <td>1</td>
    <td>1, 5, 8, 14, 20, 26</td>
    <td>Entradas válidas</td>
    <td>Cadastro de solicitação de serviço realizado com sucesso</td>
  </tr>
  <tr>
    <td>2</td>
    <td>2, 5, 8, 14, 20, 26</td>
    <td>Nome inválido</td>
    <td>Falha no cadastro de solicitação de serviço, nome contém dígitos (0-9)</td>
  </tr>
  <tr>
    <td>3</td>
    <td>3, 5, 8, 14, 20, 26</td>
    <td>Nome inválido</td>
    <td>Falha no cadastro de solicitação de serviço, nome contém caracteres especiais (#, @, !, etc.)</td>
  </tr>
  <tr>
    <td>4</td>
    <td>4, 5, 8, 14, 20, 26</td>
    <td>Nome vazio</td>
    <td>Falha no cadastro de solicitação de serviço, campo de nome é obrigatório</td>
  </tr>
  <tr>
    <td>5</td>
    <td>1, 6, 8, 14, 20, 26</td>
    <td>Email inválido</td>
    <td>Falha no cadastro de solicitação de serviço, email fora do domínio padrão da ufam</td>
  </tr>
  <tr>
    <td>6</td>
    <td>1, 7, 8, 14, 20, 26</td>
    <td>Email vazio</td>
    <td>Falha no cadastro de solicitação de serviço, campo de email é obrigatório</td>
  </tr>
  <tr>
    <td>7</td>
    <td>1, 5, 9, 14, 20, 26</td>
    <td>Siape inválido</td>
    <td>Falha no cadastro de solicitação de serviço, siape contém letras (A-Z, a-z)</td>
  </tr>
  <tr>
    <td>8</td>
    <td>1, 5, 10, 14, 20, 26</td>
    <td>Siape inválido</td>
    <td>Falha no cadastro de solicitação de serviço, siape contém caracteres especiais (#, @, !, etc.)</td>
  </tr>
  <tr>
    <td>9</td>
    <td>1, 5, 11, 14, 20, 26</td>
    <td>Siape inválido</td>
    <td>Falha no cadastro de solicitação de serviço, siape contém menos de 7 dígitos</td>
  </tr>
  <tr>
    <td>10</td>
    <td>1, 5, 12, 14, 20, 26</td>
    <td>Siape inválido</td>
    <td>Falha no cadastro de solicitação de serviço, siape contém mais de 7 dígitos</td>
  </tr>
  <tr>
    <td>11</td>
    <td>1, 5, 13, 14, 20, 26</td>
    <td>Siape vazio</td>
    <td>Falha no cadastro de solicitação de serviço, campo de siape é obrigatório</td>
  </tr>
  <tr>
    <td>12</td>
    <td>1, 5, 8, 15, 20, 26</td>
    <td>Bloco inválido</td>
    <td>Falha no cadastro de solicitação de serviço, bloco com letra fora do intervalo (G-Z, g-z)</td>
  </tr>
  <tr>
    <td>13</td>
    <td>1, 5, 8, 16, 20, 26</td>
    <td>Bloco inválido</td>
    <td>Falha no cadastro de solicitação de serviço, bloco contém dígito (0-9)</td>
  </tr>
  <tr>
    <td>14</td>
    <td>1, 5, 8, 17, 20, 26</td>
    <td>Bloco inválido</td>
    <td>Falha no cadastro de solicitação de serviço, bloco contém caractere especial (#, @, !, etc.)</td>
  </tr>
  <tr>
    <td>15</td>
    <td>1, 5, 8, 18, 20, 26</td>
    <td>Bloco inválido</td>
    <td>Falha no cadastro de solicitação de serviço, bloco contém mais de uma letra</td>
  </tr>
  <tr>
    <td>16</td>
    <td>1, 5, 8, 19, 20, 26</td>
    <td>Bloco vazio</td>
    <td>Falha no cadastro de solicitação de serviço, campo bloco é obrigatório</td>
  </tr>
  <tr>
    <td>17</td>
    <td>1, 5, 8, 14, 21, 26</td>
    <td>Sala inválido</td>
    <td>Falha no cadastro de solicitação de serviço, sala contém letras (A-Z, a-z)</td>
  </tr>
  <tr>
    <td>18</td>
    <td>1, 5, 8, 14, 22, 26</td>
    <td>Sala inválido</td>
    <td>Falha no cadastro de solicitação de serviço, sala contém caracteres especiais (#, @, !, etc.)</td>
  </tr>
  <tr>
    <td>19</td>
    <td>1, 5, 8, 14, 23, 26</td>
    <td>Sala inválido</td>
    <td>Falha no cadastro de solicitação de serviço, sala contém mais de 3 dígitos</td>
  </tr>
  <tr>
    <td>20</td>
    <td>1, 5, 8, 14, 24, 26</td>
    <td>Sala inválido</td>
    <td>Falha no cadastro de solicitação de serviço, sala contém menos de 3 dígitos</td>
  </tr>
  <tr>
    <td>21</td>
    <td>1, 5, 8, 14, 25, 26</td>
    <td>Sala vazio</td>
    <td>Falha no cadastro de solicitação de serviço, campo sala é obrigatório</td>
  </tr>
  <tr>
    <td>22</td>
    <td>1, 5, 8, 14, 20, 27</td>
    <td>Descrição do Problema inválido</td>
    <td>Falha no cadastro de solicitação de serviço, descrição do problema contém mais de 300 caracteres</td>
  </tr>
  <tr>
    <td>23</td>
    <td>1, 5, 8, 14, 20, 28</td>
    <td>Descrição do Problema vazio</td>
    <td>Falha no cadastro de solicitação de serviço, campo descrição do problema é obrigatório</td>
  </tr>
</table>

- Login da Gerência:

| Condição de Entrada | Classe válida                                                                 | Inválida                                  | Inválida                                       | Inválida                              | Inválida         |
|---------------------|------------------------------------------------------------------------------|-------------------------------------------|------------------------------------------------|---------------------------------------|------------------|
| **Email**           | Email institucional com formato: `fulanodetal@ufam.edu.br` e registrado no sistema. (1) | Email fora do formato (2)                 | Email não encontrado no sistema/não registrado (3) | Email incompleto (4)                 | Campo vazio (5) |
| **Senha**           | Senha com no mínimo 8 caracteres e correspondente ao email. (6)              | Senha com menos de 8 caracteres (7)       | Senha não encontrada no sistema (8)              | Campo vazio (9)                       | X               |

---

| **Caso de Teste ID** | **Classes** | **Entrada**                                        | **Resultado Esperado**                                                                                 |
|----------------------|-------------|----------------------------------------------------|--------------------------------------------------------------------------------------------------------|
| **CT-01**            | 1,6 (Válida) | Email e senha informados corretamente e registrados no sistema. | Login efetuado com sucesso no sistema.                                                                 |
| **CT-02**            | 2,6 (Inválida) | E-mail fora do formato, senha correta.              | Falha de login, email fora do formato padrão de email institucional.                                   |
| **CT-03**            | 3,6 (Inválida) | E-mail válido, mas não registrado no sistema, senha correta. | Falha de login, email não registrado no sistema.                                                       |
| **CT-04**            | 4,6 (Inválida) | E-mail incompleto, senha correta.                  | Falha de login, email incompleto.                                                                     |
| **CT-05**            | 5,6 (Inválida) | Campo de e-mail vazio, senha correta.              | Falha de login, email não informado.                                                                  |
| **CT-06**            | 7,1 (Inválida) | E-mail válido e registrado, senha com menos de 8 caracteres | Falha de login, senha incompleta.                                                                     |
| **CT-07**            | 8,1 (Inválida) | E-mail válido e registrado, senha incorreta ou diferente do cadastro | Falha de login, senha não encontrada no sistema.                                                      |
| **CT-08**            | 9,1 (Inválida) | E-mail válido e registrado, campo de senha vazio   | Falha de login, senha não informada.                                                                  |


- Busca de Protocolo do sistema:

| Condição de Entrada      | Classe válida                                   | Inválida                               | Inválida                         | Inválida                           | Inválida                         |
|--------------------------|-------------------------------------------------|----------------------------------------|----------------------------------|------------------------------------|----------------------------------|
| **Código de Protocolo**  | Código com 8 caracteres e existente no sistema. (1) | Código inexistente no sistema/não encontrado (2) | Campo vazio (3)                | Código com mais de 8 caracteres (4) | Código com menos de 8 caracteres (5) |

---

| **Caso de Teste ID** | **Classe** | **Entrada**                                       | **Resultado Esperado**                                                                              |
|----------------------|------------|---------------------------------------------------|-----------------------------------------------------------------------------------------------------|
| **CT-01**            | 1          | Código com 8 caracteres e existente no sistema    | Busca de protocolo realizada com sucesso.                                                           |
| **CT-02**            | 2          | Código com 8 caracteres, mas inexistente no sistema | Falha de busca, código não encontrado no sistema.                                                   |
| **CT-03**            | 3          | Campo vazio                                       | Falha de busca, protocolo não informado para busca.                                                 |
| **CT-04**            | 4          | Código com mais de 8 caracteres                    | Falha de busca, protocolo informado incorretamente: com mais de 8 caracteres.                       |
| **CT-05**            | 5          | Código com menos de 8 caracteres                   | Falha de busca, protocolo informado incorretamente: com menos de 8 caracteres.                      |

