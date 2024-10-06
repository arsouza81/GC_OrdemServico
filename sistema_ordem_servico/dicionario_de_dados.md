# DICIONÁRIO DE DADOS

<p align=justify>O Dicionário de Dados é uma ferramenta fundamental para o desenvolvimento de qualquer projeto de software, incluindo o sistema de Ordem de Serviço. Ele atua como um guia centralizado que documenta todos os elementos de dados do sistema, como tabelas, campos, tipos de dados e relações entre eles. Sua importância é ainda mais evidente em projetos que lidam com um grande volume de informações, como um sistema de Ordem de Serviço, onde é necessário organizar e gerenciar dados de clientes, serviços, equipamentos, técnicos, e outras informações relevantes de maneira eficiente e consistente.</p>
<p align=justify>No contexto do projeto de Ordem de Serviço, o Dicionário de Dados ajuda a padronizar a forma como os dados são armazenados, acessados e manipulados, garantindo que todos os membros da equipe de desenvolvimento tenham um entendimento claro e uniforme dos componentes do banco de dados. Além disso, ele facilita a comunicação entre desenvolvedores, analistas de sistemas, e outros stakeholders, ao fornecer uma referência detalhada sobre cada elemento de dado utilizado no sistema.</p>
<p align=justify>Essa documentação é essencial para assegurar a integridade e a qualidade dos dados ao longo de todo o ciclo de vida do projeto, auxiliando não apenas na fase de implementação, mas também na manutenção e na evolução futura do sistema. Ao definir claramente como os dados são estruturados e utilizados, o Dicionário de Dados contribui para um desenvolvimento mais organizado, minimizando erros e inconsistências, e promovendo um software mais robusto e confiável.</p>

<table>
<tr align=center>
  <td><b>NOME DO DADO</b></td>
  <td><b>TIPO DO DADO</b></td>
  <td><b>DESCRIÇÃO</b></td>
  <td><b>FORMATO</b></td>
  <td><b>RESTRIÇÃO</b></td>
</tr>
  
<tr>
  <td>Bloco</td>
  <td>String</td>
  <td>Letra que identifca o bloco</td>
  <td>Até 5 caracteres</td>
  <td>Não pode ser vazio</td>
</tr>

<tr>
  <td>Cargo</td>
  <td>String</td>
  <td>Cargo de concurso do Gerente e Subgerente de TI</td>
  <td>Até 90 caracteres</td>
  <td>Não pode ser vazio</td>
</tr>

<tr>
  <td>Data_solicitacao</td>
  <td>Data</td>
  <td>Data do cadastro da solcitação de serviço</td>
  <td>DD/MM/AAAA</td>
  <td>Deve ser a data em que ocorreu o cadastro da solicitação de serviço</td>
</tr>

<tr>
<td>DescricaoProblema</td>
<td>String</td>
<td>Descreve sucintamente o problema que está acontecendo com equipamentos e estruturas de TI</td>
<td>Até 600 caracteres</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Docente</td>
<td>String</td>
<td>Servidor que exerce a função de professor</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Email</td>
<td>String</td>
<td>Email do Servidor</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Email institucional</td>
<td>String</td>
<td>Email disponibilizado pela organização para o servidor</td>
<td>tiicet@ufam.edu.br</td>
<td>O email insitucional deve conter o dominio ufam.edu.br</td>
</tr>

<tr>
<td>Funcionalidades restritas</td>
<td>String</td>
<td>Funcionalidades do sistema direcionadas para a gerência de TI</td>
<td align=center> -	</td>
<td>É necessário autenticação de usuário para acessar as funcionalidades restritas</td>
</tr>

<tr>
<td>Gerência</td>
<td>String</td>
<td>Técnicos Administrativo em Educação que ocupam os cargos de Gerente de TI e de Subgerente de TI</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Gerente de TI</td>
<td>String</td>
<td>Técnico Administrativo em Educação que ocupa cargo de Gerente de TI</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>ICET</td>
<td>String</td>
<td>Abreviatura para Instituto de Ciências Exatas e Tecnologia</td>
<td>Instituto de Ciências Exatas e Tecnologia</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>id</td>
<td>Inteiro</td>
<td>Código que identifica cada registro (chave primária)</td>
<td>Número inteiro</td>
<td>Deve ser único para cada registro</td>
</tr>

<tr>
<td>Instituto de Ciências Exatas e Tecnologia</td>
<td>String</td>
<td>Instituto para o qual está sendo desenvolvido o sistema Ordem de Serviço</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Login</td>
<td>String</td>
<td>Processo de autenticação de usuário</td>
<td>Usuário e Senha</td>
<td>Para realizar o login é necessário informar usuário e senha cadastrados</td>
</tr>

<tr>
<td>Name</td>
<td>String</td>
<td>Nome do servidor ocupante dos cargos de Gerente de TI e Subgerente de TI</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Nome</td>
<td>String</td>
<td>Nome do Servidor</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Notificação</td>
<td>Booleano</td>
<td>Status que indica se uma notificação de cadastro de solicitação de serviço foi enviada</td>
<td>true/false</td>
<td>True se a solicitação de serviço foi cadastrada com sucesso</td>
</tr>

<tr>
<td>Protocolo</td>
<td>String</td>
<td>Código utilizado pelo solicitante para acompanhar a situação da solicitação de serviço</td>
<td>Até 8 caracteres</td>
<td>Deve ser único para cada solcitação de serviço</td>
</tr>

<tr>
<td>Sala</td>
<td>inteiro</td>
<td>Número que identifica a sala</td>
<td>Número inteiro</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Senha</td>
<td>String</td>
<td>Senha utilizada pela gerência de TI para acessar as funcionalidades restritas do sistema</td>
<td>Até 255 caracteres</td>
<td>Não pode ser vazio / deve ser <= 8 caracteres / deve ser formada por 1 caractere especial, 1 letra maiúscula, 1 letra minúscula e 1 número</td>
</tr>

<tr>
<td>Servidor</td>
<td>String</td>
<td>O servidor poderá ser um Técnico Administrativo em Educação ou um docente</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Siape</td>
<td>inteiro</td>
<td>Código que identifica cada servidor</td>
<td>Número inteiro</td>
<td>Não pode ser vazio</td>
</tr>

<tr>
<td>Solicitação de Serviço</td>
<td>String</td>
<td>Ato em que o servidor realiza um pedido de serviços de instalação e manutenção em equipamentos e estruturas de TI</td>
<td>Até 255 caracteres</td>
<td>Não pode ser vazio</td>	
</tr>

<tr>
<td>Status</td>
<td>String</td>
<td>Situação em que se encontra a solicitação de serviço</td>
<td>em andamento / concluída / pendente / descartada</td>
<td>Não pode ser vazio</td>	
</tr>

<tr>
<td>Subgerente de TI</td>
<td>String</td>
<td>Técnico Administrativo em Educação que ocupa cargo de Subgerência de TI</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>	
</tr>

<tr>
<td>TAE</td>
<td>String</td>
<td>Abreviatura para Técnico Administrativo em Educação</td>
<td>Técnico Administrativo em Educação</td>
<td>Não pode ser vazio</td>	
</tr>

<tr>
<td>Técnico Administrativo em Educação</td>
<td>String</td>
<td>Servidor que exerce a função de técnico especialista</td>
<td>Até 90 caracteres</td>
<td>Não pode ser vazio</td>	
</tr>

<tr>
<td>TI</td>
<td>String</td>
<td>Abreviatura para Tecnologia da Informação</td>
<td>Tecnologia da Informação</td>
<td>Não pode ser vazio</td>
</tr>

</table>
