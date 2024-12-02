# Relatório de Auditoria do Sistema Ordem de Serviço

## INTRODUÇÃO
O presente documento apresenta os resultados da auditoria realizada no Sistema de Ordem de Serviço, com o objetivo de avaliar a conformidade do projeto em relação às correções e atualizações priorizadas pela equipe de desenvolvimento. Esta auditoria busca garantir que os defeitos identificados previamente foram devidamente corrigidos, que as atualizações necessárias foram implementadas, e que os itens de configuração atendem aos padrões de qualidade estabelecidos para o sistema.

A auditoria foi conduzida seguindo uma abordagem sistemática, utilizando check-list previamente elaborado na reunião de revisão anterior realizada na data 29/11/2024 com os membros da equipe, com análises de evidências, e validações realizadas em ambiente de desenvolvimento. Nesta reunião de revisão foi acordado com toda a equipe os defeitos identificados, seguido da priorização dos defeitos que deveriam ser corrigidos até a data desta auditoria. Os defeitos que deveriam ser corrigidos foram listados por meio de um check-list e foi definido cada responsável para a correção de cada defeito.

Este relatório detalha os itens auditados, as evidências observadas, e as conclusões obtidas, além de fornecer recomendações para melhoria contínua do processo de desenvolvimento do sistema. O objetivo principal é assegurar que o Sistema de Ordem de Serviço esteja alinhado com os requisitos definidos, promovendo um produto final de alta qualidade que atenda às necessidades da instituição.

---

## Identificação da Auditoria

- **Projeto:** Ordem de Serviço  
- **Data:** 02/12/2024  
- **Duração da Auditoria:** 40min de duração  
- **Responsável e Mediador da Auditoria:** Kássia Ramos Oliveira  
- **Objetivo:** Verificar se os defeitos e atualizações priorizados na última reunião de revisão foram corrigidos e implementados corretamente até o prazo estipulado.  

---

## Itens Auditados

Nesta seção são apresentados os defeitos priorizados para correção no projeto, bem como seu tipo, status, responsável, evidência de correção e observação.

| **Item**     | **Tipo**      | **Status**          | **Responsável**    | **Evidência**                                                                                              | **Observação**                                       |
|--------------|---------------|---------------------|--------------------|-----------------------------------------------------------------------------------------------------------|-----------------------------------------------------|
| Issue 2      | Defeito       | Análise finalizada  | Alicia Caldeira    | commit `419059915f9a8c981d6ef569d727782bb4752dbb` - fix: correção issue 2 - correção do siape              | -                                                   |
| Issue 3      | Defeito       | Análise finalizada  | Rennan Alves       | commit `09b96eb6a836704f8eea83c16e4e324a6ea793bc` - fix: correção da issue 3: enviando mais informações por e-mail para a gerência | -                                                   |
| Issue 4      | Defeito       | Análise finalizada  | Diandre Pires      | commit `68c1632c433d26e1f311f0eace568b07d8297a11` - fix: correção issue 4 - descrição não permite mais de 600 caracteres | -                                                   |
| Issue 8      | Defeito       | Análise finalizada  | Anderson           | commit `19334614921dcb8271807584d1bc0d973674ab3a` - DOCS: correção do defeito da issue 08 - inserindo métodos no diagrama de classes | -                                                   |
| Issue 9      | Falso Positivo| Análise finalizada  | Kássia Ramos       | -                                                                                                         | No processo de correção foi identificado que não seria preciso modificação. |
| Readme       | Atualização   | Análise finalizada  | Anderson           | commit `f135d6bf69767f4404a40d83dc6aae96c592516a` - DOCS: Atualizando o readme.md                         | -                                                   |

---

## Resumo Quantitativo

- **Total de Itens Auditados:** 04 Defeitos, 01 defeito falso positivo e 01 atualização.  
- **Itens Corrigidos/Concluídos:** 04 Defeitos corrigidos e 06 atualizações concluídas no repositório do sistema.  
- **Itens Pendentes:**  
  - Dos itens definidos para esta auditoria: 0 pendências.  
  - Para o projeto em si: verificar os faltantes em próximas reuniões e auditorias.  

---

## Conclusão

### Defeitos
Todos os 04 defeitos priorizados para a correção foram corrigidos e devidamente documentados em atualizações no repositório.

### Atualizações
A atualização do Readme do projeto no repositório foi realizada para refletir as mudanças no sistema. Além disso, o documento desta auditoria também será disponibilizado no repositório para a leitura dos interessados no projeto. A atualização deste documento no repositório será feita pela responsável da auditoria.

### Impactos
Apesar dos defeitos priorizados serem corrigidos, eles não foram os únicos encontrados no sistema. Os defeitos pendentes e não priorizados devem ser listados e corrigidos em um momento oportuno. A priorização e correção destes defeitos documentados se deu porque não bloqueiam o funcionamento do sistema, embora possam afetar, em pequena escala, a experiência do usuário.

---

## Pautas das Próximas Auditorias/Recomendações

- Tratar os defeitos pendentes e documentados no GitHub, com definição de prazos para correção antes do próximo ciclo de auditoria.  
- Implementar testes automatizados para validação contínua de funcionalidades corrigidas.  
- Planejar a próxima auditoria para garantir a conformidade com os requisitos do projeto e sua qualidade.

---

## Participaram desta Auditoria

- Alicia Caldeira da Silva  
- Anderson de Souza Rodrigues  
- Diandre Pires Bruce  
- Kássia Ramos Oliveira  
- Rennan de Souza Alves  
