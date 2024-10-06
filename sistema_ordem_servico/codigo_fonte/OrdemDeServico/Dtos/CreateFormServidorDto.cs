using OrdemDeServico.Models;
using System.ComponentModel.DataAnnotations;

namespace OrdemDeServico.Dtos; 
public class CreateFormServidorDto {

    [Required(ErrorMessage = "O formulário precisa de um nome de usuário")]
    [StringLength(90, ErrorMessage = "O usuário não pode ter o nome com mais de 90 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O formulário precisa de um e-mail")]
    [StringLength(90, ErrorMessage = "O usuário não pode ter o e-mail com mais de 90 caracteres")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O formulário precisa de um siape")]
    public int Siape { get; set; }

    [Required(ErrorMessage = "O formulário precisa de um bloco")]
    [StringLength(5, ErrorMessage = "O bloco não pode ter mais de 5 caracteres")]
    public string Bloco { get; set; }

    [Required(ErrorMessage = "O formulário precisa de uma sala")]
    public int Sala { get; set; }

    [Required(ErrorMessage = "O formulário precisa de uma descrição para o problema")]
    public string DescricaoProblema { get; set; }

    [Required(ErrorMessage = "A data de criação é obrigatória")]
    public DateTime Data_Solicitacao { get; set; } = DateTime.Now;
}
