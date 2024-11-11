# Validação de Sistema

## Avaliadora 1

**Nome:** Alicia Caldeira da Silva

## Objetivos e Escopo da Avaliação

O objetivo desta avaliação é realizar uma inspeção heurística do sistema, analisando suas interfaces e fluxos de interação, identificando problemas de usabilidade e violações de heurísticas de Nielsen. O escopo da avaliação abrange a verificação de sete telas do sistema, com foco em usabilidade e prevenção de erros.

## Método Utilizado

Para a validação, foi adotada a **inspeção heurística** baseada nas **10 heurísticas de usabilidade de Nielsen**. Os avaliadores inspecionaram o sistema de maneira independente, focando em problemas de usabilidade e propondo soluções para melhorar a interface e a experiência do usuário.

### Conjunto de Heurísticas Utilizado:
1. **H1. Visibilidade do status do sistema**
2. **H2. Compatibilidade entre o sistema e o mundo real**
3. **H3. Controle e liberdade do usuário**
4. **H5. Prevenção de erros**
5. **H6. Reconhecer ao invés de lembrar**
6. **H7. Flexibilidade e eficiência de uso**
7. **H8. Estética e design minimalista**
8. **H9. Ajuda a reconhecer, diagnosticar e corrigir erros**
9. **H10. Ajuda e documentação**

## Perfil e Quantidade dos Avaliadores

As avaliadoras as avaliadoras possuem bom entendimento de interfaces web. No total, 2 (duas) avaliadoras participaram do processo de inspeção.

### Avaliadora 1: Técnica em Desenvolvimento de Sistemas

**Nome:** Alicia Caldeira da Silva

**Formação:** Técnica em Desenvolvimento de Sistemas

**Curso:** Engenharia de Software

**Experiência:** 
- Participou de avaliações de usabilidade em projetos anteriores, contribuindo na identificação de problemas de interface e inconsistências na interação do usuário.

### Avaliadora 2: Técnica em Informática

**Nome:** Diandre Pires Bruce

**Formação:** Técnica em Informática

**Curso:** Engenharia de Software

**Experiência:** 
- Já realizou avaliações de usabilidade em projetos anteriores, contribuindo na identificação de problemas de interface e inconsistências na interação do usuário.

## Processo de Inspeção

O processo foi dividido nas seguintes fases:

1. **Detecção de Defeitos**: Os avaliadores inspecionaram as telas do sistema, buscando defeitos e violações das heurísticas de usabilidade.
2. **Coleção de Defeitos**: Os defeitos encontrados foram coletados e organizados para avaliação.
3. **Discriminação de Defeitos**: Os defeitos foram analisados e categorizados de acordo com o grau de severidade e a heurística violada.

## Lista de Problemas de Usabilidade Encontrados

### Tela 1:
- **H1. Visibilidade do status do sistema** (Severidade: 4)  
  - **Ponto positivo**: Há um botão "Buscar" e campos de preenchimento claros.
  - **Sugestão**: Incluir feedback visual ou mensagem quando uma ordem de serviço for inexistente.

- **H2. Compatibilidade entre o sistema e o mundo real** (Severidade: 1)  
  - **Ponto positivo**: Termos como "Nome", "Email", e "Descrição do Problema" são familiares aos usuários.
  - **Sugestão**: Incluir uma explicação para o termo "Siape", que pode ser desconhecido para alguns usuários.

- **H3. Controle e liberdade do usuário** (Severidade: 2)  
  - **Análise**: Não há opção de editar ou revisar informações antes de enviar.
  - **Sugestão**: Permitir a revisão de dados ou a inclusão de um botão "Cancelar" para evitar submissões acidentais.

- **H5. Prevenção de erros** (Severidade: 3)  
  - **Análise**: Não há validações nos campos obrigatórios.
  - **Sugestão**: Implementar validação nos campos, como endereço de e-mail válido.

- **H9. Ajuda os usuários a reconhecer, diagnosticar e corrigir erros** (Severidade: 4)  
  - **Análise**: Não há feedback para erros no envio do formulário.
  - **Sugestão**: Incluir mensagens de erro específicas, como "Campo obrigatório" ou "Insira um e-mail válido".

- **H10. Ajuda e documentação** (Severidade: 2)  
  - **Análise**: Não há ajuda visível.
  - **Sugestão**: Incluir um botão para acessar uma seção de ajuda ou FAQ.

---

### Tela 2:
- **H3. Controle e liberdade do usuário** (Severidade: 3)  
  - **Análise**: Há um link "voltar", mas a opção de visualizar senhas enquanto digita melhoraria a experiência.
  - **Sugestão**: Implementar a opção de visualizar senha.

- **H5. Ajudar os usuários a reconhecer, diagnosticar e corrigir erros** (Severidade: 3)  
  - **Análise**: Não há validação em tempo real para campos como e-mail ou senha.
  - **Sugestão**: Implementar validações em tempo real com mensagens claras, como "E-mail inválido".

- **H8. Estética e design minimalista** (Severidade: 2)  
  - **Ponto positivo**: Design limpo e minimalista.
  - **Sugestão**: O centro da tela está vazio, poderia haver uma breve explicação ou imagem para preencher o espaço.

- **H10. Ajuda e documentação** (Severidade: 2)  
  - **Análise**: Não há links de ajuda visíveis.
  - **Sugestão**: Incluir um link para suporte técnico.

---

### Tela 3:
- **H3. Controle e liberdade do usuário** (Severidade: 3)  
  - **Análise**: Não há opção de retornar à página anterior.
  - **Sugestão**: Incluir a opção de voltar.

- **H9. Ajuda os usuários a reconhecer, diagnosticar e corrigir erros** (Severidade: 4)  
  - **Análise**: Não há mensagens de erro para solicitações não encontradas.
  - **Sugestão**: Incluir uma mensagem clara quando uma solicitação não for encontrada.

---

### Tela 4:
- **H7. Flexibilidade e eficiência de uso** (Severidade: 2)  
  - **Análise**: O calendário é útil, mas seria interessante permitir a seleção de um intervalo de datas.
  - **Sugestão**: Implementar filtros adicionais ou intervalos de datas.

- **H9. Ajuda os usuários a reconhecer, diagnosticar e corrigir erros** (Severidade: 3)  
  - **Análise**: Não há feedback para erros de pesquisa.
  - **Sugestão**: Incluir mensagens para erros de pesquisa, como "Nenhuma solicitação encontrada".

---

### Tela 5:
- **H6. Reconhecer ao invés de lembrar** (Severidade: 3)  
  - **Análise**: O usuário não sabe onde clicar para acessar os detalhes da solicitação.
  - **Sugestão**: Incluir um botão ou link visível para navegação.

---

### Tela 7:
- **H3. Controle e liberdade do usuário** (Severidade: 3)  
  - **Análise**: Não há uma opção para o usuário cancelar a tarefa.
  - **Sugestão**: Incluir um botão de "Cancelar".

---

## Consolidação dos Resultados

Os resultados indicam que o sistema apresenta uma série de violações das heurísticas de usabilidade, especialmente relacionadas ao feedback de erros e à liberdade do usuário. As recomendações feitas visam melhorar a interação e a usabilidade geral, com foco na prevenção de erros e na flexibilidade para os usuários.

## Recomendações Gerais
- **Validações**: Implementar validações de campos em tempo real em todas as telas.
- **Mensagens de Erro**: Fornecer mensagens de erro claras e detalhadas.
- **Navegação**: Garantir que o usuário tenha controle sobre suas ações, com botões de "Cancelar" e a opção de retornar às telas anteriores.
- **Ajuda e Documentação**: Adicionar seções de ajuda e suporte visíveis para melhorar a experiência do usuário.




_______________________________________________________________________________________________________________________________________________

# Relatório de Validação de Software

### Avaliadora 2

**Nome:** Diandre Pires Bruce


## 1. Introdução
O objetivo deste relatório é realizar uma **validação heurística** de um sistema de software utilizando o conjunto de heurísticas de Nielsen. Esta atividade inspeciona as telas do sistema em busca de problemas de usabilidade, classificando o grau de severidade de cada problema e propondo recomendações para melhorias.

---

## 2. Objetivos e Escopo
O foco da validação é garantir que o sistema ofereça uma boa experiência ao usuário e que erros comuns de interação sejam evitados. A análise foi baseada em heurísticas de usabilidade, sem a execução de testes funcionais.

---

## 3. Método Utilizado
Para realizar a validação, utilizamos o conjunto de **10 heurísticas de Nielsen**:
H1. Visibilidade do status do sistema.
H2. Correspondência entre o sistema e o mundo real.
H3. Controle e liberdade do usuário.
H4. Consistência e padrões.
H5. Prevenção de erros.
H6. Reconhecimento ao invés de lembrar.
H7. Flexibilidade e eficiência de uso.
H8. Estética e design minimalista.
H9. Ajudar os usuários a reconhecerem, diagnosticarem e corrigirem erros.
H10. Ajuda e documentação.

---

## 4. Processo de Inspeção
O processo de inspeção foi dividido em três fases:
1. **Detecção dos problemas:** Identificar onde os problemas ocorrem no sistema.
2. **Coleta dos problemas:** Registrar os problemas encontrados em cada tela.
3. **Discriminação dos problemas:** Classificar os problemas quanto ao grau de severidade.

---

## 5. Resultados da Validação

### Tela 1
- **Local do Problema:** Campo "SIAPE".
- **Descrição:** O termo "SIAPE" pode não ser familiar para todos os usuários.
- **Heurística Violada:** H2 - Correspondência entre o sistema e o mundo real.
- **Grau de Severidade:** Média.
- **Recomendação:** Incluir uma breve explicação ou exemplo do termo "SIAPE" para melhorar a compreensão.
---


- **Local do Problema:** Formulário de submissão.
- **Descrição:** Falta de opção para cancelar ou editar informações antes de enviar.
- **Heurística Violada:** H3 - Controle e liberdade do usuário.
- **Grau de Severidade:** Alta.
- **Recomendação:** Adicionar um botão "Cancelar" e permitir ao usuário editar as informações antes do envio.
---


- **Local do Problema:** Formulário de submissão.
- **Descrição:** Não há validação dos campos obrigatórios, permitindo o envio de dados incompletos ou incorretos.
- **Heurística Violada:** H5 - Prevenção de erros.
- **Grau de Severidade:** Alta.
- **Recomendação:** Implementar validação nos campos de entrada, como verificação de formato de email.
---


- **Local do Problema:** Sistema de feedback.
- **Descrição:** O sistema não exibe mensagens de erro ao encontrar um problema nos dados enviados.
- **Heurística Violada:** H9 - Ajudar os usuários a reconhecerem, diagnosticarem e corrigirem erros.
- **Grau de Severidade:** Alta.
- **Recomendação:** Adicionar mensagens de erro claras e específicas, informando o usuário sobre o campo que precisa ser corrigido.
---



### Tela 2
- **Local do Problema:** Campos de email e senha.
- **Descrição:** Não há placeholders ou exemplos para guiar o preenchimento correto dos campos.
- **Heurística Violada:** H5 - Prevenção de erros.
- **Grau de Severidade:** Alta.
- **Recomendação:** Inserir exemplos ou placeholders nos campos de email e senha para orientar o preenchimento correto.
  
---

- **Local do Problema:** Sistema de feedback.
- **Descrição:** O sistema não informa o usuário sobre erros ao inserir dados incorretos.
- **Heurística Violada:** H9 - Ajudar os usuários a reconhecerem, diagnosticarem e corrigirem erros.
- **Grau de Severidade:** Alta.
- **Recomendação:** Implementar mensagens de erro que apareçam diretamente nos campos onde ocorreu o problema, informando o que precisa ser corrigido.

---

### Tela 3
- **Local do Problema:** Navegação.
- **Descrição:** Não há opção de "Voltar" na tela, obrigando o usuário a utilizar o botão de navegação do navegador.
- **Heurística Violada:** H3 - Controle e liberdade do usuário.
- **Grau de Severidade:** Alta.
- **Recomendação:** Incluir um botão de "Voltar" para melhorar a navegação do usuário entre as telas do sistema.
---


- **Local do Problema:** Feedback de dados.
- **Descrição:** Quando não há registros de solicitações, o sistema não exibe nenhuma mensagem informando o usuário.
- **Heurística Violada:** H9 - Ajudar os usuários a reconhecerem, diagnosticarem e corrigirem erros.
- **Grau de Severidade:** Média.
- **Recomendação:** Exibir uma mensagem clara e objetiva, como "Não há solicitações registradas", para informar o usuário quando não houver dados.

---

### Tela 4
- **Local do Problema:** Seleção de registros.
- **Descrição:** Não há uma maneira clara de selecionar cada registro de solicitação separadamente.
- **Heurística Violada:** H6 - Reconhecimento ao invés de lembrar.
- **Grau de Severidade:** Média.
- **Recomendação:** Tornar visível e acessível a seleção de registros individuais, permitindo ao usuário visualizar e navegar entre os registros.

---

### Tela 5
- **Local do Problema:** Atualização de status.
- **Descrição:** O botão de atualização de status não está visível ou claro para o usuário.
- **Heurística Violada:** H6 - Reconhecimento ao invés de lembrar.
- **Grau de Severidade:** Média.
- **Recomendação:** Tornar o botão de atualização de status mais visível e acessível, permitindo ao usuário atualizar o status com facilidade.

---

### Tela 6
- **Local do Problema:** Navegação e controle de ações.
- **Descrição:** Não há opção de "Cancelar" ou "Voltar" ao atualizar o status, forçando o usuário a seguir adiante com a ação.
- **Heurística Violada:** H3 - Controle e liberdade do usuário.
- **Grau de Severidade:** Alta.
- **Recomendação:** Incluir botões de "Cancelar" e "Voltar", permitindo ao usuário cancelar ou retornar a uma etapa anterior sem ter que completar a ação.

---

## 6. Consolidação dos Resultados
Os problemas foram detectados em várias telas do sistema, com predominância de problemas relacionados à falta de feedback e controle do usuário.
