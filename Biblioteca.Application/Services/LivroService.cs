using AutoMapper;
using Biblioteca.Application.DTOs;
using Biblioteca.Domain.Entities;
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
        var livros = await _uof.LivroRepository.GetAllAsync();
        var livrosDto = _mapper.Map<IEnumerable<LivroDTO>>(livros);
        return livrosDto;
    } 
    public async Task<LivroDTO> GetLivroAsync(int id)
    {
        var livro = await _uof.LivroRepository.GetByIdAsync(l => l.LivroId == id);
        var livroDto = _mapper.Map<LivroDTO>(livro);
        return livroDto;
    }
    public async Task<LivroDTO> AddAsync(LivroDTO livroDto)
    {
        var livro = _mapper.Map<Livro>(livroDto);
        await _uof.LivroRepository.AddAsync(livro);
        await _uof.Commit();
        return livroDto;
    }
    public async Task<LivroDTO?> Update(int id, LivroDTO livroDto)
    {
        if (id != livroDto.LivroId)
            return null;

        var livro = await _uof.LivroRepository.GetByIdAsync(l => l.LivroId == id);

        if(livro is null) 
            return null;

        _mapper.Map(livroDto, livro);
        await _uof.Commit();

        var livroAtualizadoDto = _mapper.Map<LivroDTO>(livro);
        return livroAtualizadoDto ;
    }
    public async Task<LivroDTO?> Delete(int id)
    {
        var livro = await _uof.LivroRepository.GetByIdAsync(l => l.LivroId == id);

        if (livro is null)
            return null;

        var livroDeletado = _uof.LivroRepository.Delete(livro);
        await _uof.Commit();

        var livroDeletadoDto = _mapper.Map<LivroDTO>(livroDeletado);
        return livroDeletadoDto;
    }
}
