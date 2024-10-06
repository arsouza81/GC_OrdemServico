using OrdemDeServico.Models;
using System.ComponentModel.DataAnnotations;

namespace OrdemDeServico.Dtos; 
public class ReadFormServidorDto {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Siape { get; set; }
    public string Bloco { get; set; }
    public int Sala { get; set; }
    public string DescricaoProblema { get; set; }
    public DateTime Data_Solicitacao { get; set; } = DateTime.Now;
    public string Status { get; set; }
    public string Protocolo { get; set; }
}
