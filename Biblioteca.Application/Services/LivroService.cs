using AutoMapper;
using Biblioteca.Application.DTOs;
using Biblioteca.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Application.Services;

public class LivroService
{
    private readonly IUnitOfWork _uof;
    private readonly IMapper _mapper;

    public LivroService(IUnitOfWork uof, IMapper mapper)
    {
        _uof = uof;
        _mapper = mapper;
    }

    public async Task<IEnumerable<LivroDTO>> GetAllAsync()
    {
        var livros = await _uof.Livro.GetAllAsync();
        var livrosDto = _mapper.Map<IEnumerable<LivroDTO>>(livros);
        return livrosDto;
    } 
    public async Task<LivroDTO> GetLivroAsync(int id)
    {
        var livro = await _uof.Livro.GetAsync(l => l.LivroId == id);
        var livroDto = _mapper.Map<LivroDTO>(livro);
        return livroDto;
    }
}
