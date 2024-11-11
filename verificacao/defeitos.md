# Verificação do Sistema Ordem de Serviço

O objetivo principal deste documento é descrever a verificação aplicada ao sistema Ordem de Serviço. O processo de verificação tem como propósito confirmar que cada serviço e/ou produto de trabalho do processo ou do projeto atende apropriadamente os requisitos especificados. Para o projeto do sistema Ordem de Serviço, o processo de verificação foi feito com o objetivo de identificar e documentar pelo menos 10 defeitos em diversos artefatos de software do sistema, como:

- Backlog do produto
- Diagrama de Classes
- Código Fonte
- Modelo C4 do sistema

Para esse processo de verificação, foi utilizada a taxonomia do padrão IEEE (IEEE-1044, 2010) de anomalias de Software, que classifica os defeitos em cinco tipos:

- Dados
- Interface
- Lógica
- Sintaxe
- Padrões

Além disso, também foi utilizada a Taxonomia definida por Shull (1998), a partir do padrão IEEE (IEEE 830, 1998), que classifica as naturezas de defeitos em documentos de requisitos nas categorias:

- Omissão
- Ambiguidade
- Inconsistência
- Fato Incorreto
- Informação Estranha

Na verificação do sistema Ordem de Serviço, foram identificados um total de 10 defeitos entre os artefatos citados, todos documentados em um modelo de tabela passado pelo orientador em sala. Os defeitos encontrados e documentados estão disponíveis para visualização pública, é indicado que seja utilizado o filtro: autor > Kássia Ramos, para que sejam visualizados as issues do processo de verificação, os defeitos estão disponíveis através do seguinte endereço eletrônico:
[Defeitos do Sistema Ordem de Serviço](https://github.com/arsouza81/TVVS_OrdemServico/issues)

Abaixo, também disponibilizamos a tabela das falhas que foram referenciadas nas tabelas do defeito, para auxiliar no processo de análise do leitor:

## Tabelas de Falhas para "Referências de Falhas"
| **Falha**                                                              | **ID**  | **Descrição**                                                                                                                                                       |
|-------------------------------------------------------------------------|---------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Cadastro de Solicitações de Demandas Falsas ou Inconsistentes            | 001  | O sistema permite o cadastro de solicitações inválidas ou falsas quando não aplica atividades de verificação adequadas de dados dos solicitantes, o que pode resultar em demandas inconsistentes ou falsas sendo registradas no banco de dados. |
| Notificação para Gerência com Dados Vagos ou Faltantes                   | 002  | O sistema envia a mesma notificação tanto para o e-mail do solicitante quanto para o e-mail da gerência, quando a notificação da gerência deveria ser mais detalhada, o que pode causar retrabalho para a gerência e um atraso na resolução da solicitação. |
| Falta de Navegação Retroativa                                            | 003  | O sistema não possui opções de volta em determinadas etapas e seções, causando inconveniências para o usuário do sistema.                                          |
| Reclamações de Usuários                                                  | 004  | Os usuários estão relatando problemas ou insatisfação com o sistema, comprometendo sua experiência e a eficácia de suas operações.                                  |
| Falha de Prevenção ou Mensagens Claras de Erro                           | 005  | O sistema não apresenta ferramentas de prevenção de erros ou mensagens claras quando o erro acontece, como identificação de campos obrigatórios ou mensagens sucintas sobre o que deu errado, para facilitar a resolução do problema pelo usuário. |
| Falta de Documentação de Funcionalidades                                 | 006  | O backlog do produto não apresenta, em suas user stories, uma descrição sobre alguma funcionalidade já implementada no sistema. Isso pode gerar confusão entre os usuários, comprometendo a usabilidade e a compreensão do fluxo do sistema. |
| Falta de Feedback ao Usuário                                             | 007  | O sistema não oferece feedback ao usuário após a conclusão de ações importantes, como o envio de solicitações de demanda, o que pode causar insegurança aos usuários sobre o que foi ou não executado de fato. |

Com o processo de validação foi possível a identificação dos defeitos que quando corrigidos auxiliam a manter o sistema coerente com suas especificações, além de ajudar a manter a clareza dos objetivos do sistema para a equipe de desenvolvimento, para os clientes e usuários finais.
