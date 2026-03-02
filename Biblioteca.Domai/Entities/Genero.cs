using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Biblioteca.Domain.Entities;

public class Genero
{
    [Key]
    public int GeneroId { get; set; }

    [Required(ErrorMessage = "O nome do livro é obrigatório!")]
    [StringLength(50, ErrorMessage = "O nome deve ter no máximo {1} caracteres")]
    public string Nome { get; set; }

    [JsonIgnore]
    public ICollection<Livro>? Livros { get; set; }
}
