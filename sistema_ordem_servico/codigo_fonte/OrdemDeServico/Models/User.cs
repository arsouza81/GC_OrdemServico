using System.ComponentModel.DataAnnotations;
using System.Data;

namespace OrdemDeServico.Models; 
public class User {

    [Key]
    [Required(ErrorMessage = "O usuário não pode ficar sem um identificador")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O usuário deve ter uma função")]
    [StringLength(90, ErrorMessage = "O cargo do usuário não pode ultrapassar de 90 caracteres")]
    public string Cargo { get; set; }

    [Required(ErrorMessage = "O usuário precisa de um nome")]
    [StringLength(90, ErrorMessage = "O usuário não pode ter o nome com mais de 90 caracteres")]
    public string Name { get; set; }

    [Required(ErrorMessage = "O usuário precisa de um e-mail")]
    [StringLength(90, ErrorMessage = "O usuário não pode ter o e-mail com mais de 90 caracteres")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O usuário precisa de uma senha")]
    [StringLength(255, ErrorMessage = "O usuário não pode ter a senha com mais de 255 caracteres")]
    public string Password { get; set; }


}