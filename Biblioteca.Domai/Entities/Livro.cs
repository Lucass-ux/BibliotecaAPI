using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Biblioteca.Domain.Entities;

internal class Livro
{
    [Key]
    public int LivroId { get; set; }

    [Required(ErrorMessage ="O nome do livro é obrigatório!")]
    [StringLength(50, ErrorMessage = "O nome deve ter no máximo {1} caracteres")]
    public string Nome { get; set; } = null;

    public string? Autor { get; set; } = null;

    public int Ano { get; set; }

    public int GeneroId { get; set; }

    [JsonIgnore]
    public Genero? Genero { get; set; }
}
