using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces;
using Biblioteca.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Infraestructure.Repositories;

public class LivroRepository : Repository<Livro>, ILivroRepository
{
    public LivroRepository(AppDbContext context) : base(context)
    {
    }    
}
