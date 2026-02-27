using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.Domain.Entities;

internal class Genero
{
    [Key]
    public int GeneroId { get; set; }
    public string? Nome { get; set; }
    public ICollection<Livro>? Livros { get; set; }
}
