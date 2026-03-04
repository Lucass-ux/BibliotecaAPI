using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ILivroRepository Livro { get; }
        IGeneroRepository Genero { get; }
        Task Commit();
    }
}
