using OrdemDeServico.Models;
using System.ComponentModel.DataAnnotations;

namespace OrdemDeServico.Dtos; 
public class ReadUserDto {

    public int Id { get; set; }
    public string Cargo { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
