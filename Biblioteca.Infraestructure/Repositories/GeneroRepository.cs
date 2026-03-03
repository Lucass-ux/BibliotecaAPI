using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces;
using Biblioteca.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Infraestructure.Repositories
{
    public class GeneroRepository : Repository<Genero>, IGeneroRepository
    {
        public GeneroRepository(AppDbContext context): base(context) 
        {
        }
    }
}
