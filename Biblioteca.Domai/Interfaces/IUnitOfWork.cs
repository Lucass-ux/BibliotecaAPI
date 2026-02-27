using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Interfaces
{
    internal interface IUnitOfWork
    {
        ILivroRepository LivroRepository { get; }
        IGeneroRepository GeneroRepository { get; }
        Task Commit();
    }
}
