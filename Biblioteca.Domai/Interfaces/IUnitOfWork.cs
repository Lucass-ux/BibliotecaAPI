using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ILivroRepository LivroRepository { get; }
        IGeneroRepository GeneroRepository { get; }
        Task Commit();
    }
}
