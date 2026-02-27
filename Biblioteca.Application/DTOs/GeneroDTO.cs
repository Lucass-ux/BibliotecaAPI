using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.Application.DTOs;

internal class GeneroDTO
{
    public int GeneroId { get; set; }

    [Required(ErrorMessage = "O nome do gênero é obrigatório!")]
    [StringLength(50, ErrorMessage = "O nome deve ter no máximo {1} caracteres")]
    public string Nome { get; set; }
}
