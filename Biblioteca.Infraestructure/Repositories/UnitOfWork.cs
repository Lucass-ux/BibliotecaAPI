using Biblioteca.Domain.Interfaces;
using Biblioteca.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Infraestructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private ILivroRepository? _livroRepo;
    private IGeneroRepository? _generoRepo;
    public AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context; 
    }
    public ILivroRepository Livro
    {
        get
        {
            if( _livroRepo == null )
                _livroRepo = new LivroRepository( _context);
            return _livroRepo;
        }
    }
    public IGeneroRepository Genero
    {
        get
        {
            if(_generoRepo == null)
                _generoRepo = new GeneroRepository( _context);
            return _generoRepo;
        }
    }
    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }
}
