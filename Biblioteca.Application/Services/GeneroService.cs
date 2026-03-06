using AutoMapper;
using Biblioteca.Application.DTOs;
using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Application.Services;

public class GeneroService
{
    private readonly IUnitOfWork _uof;
    private readonly IMapper _mapper;

    public GeneroService(IUnitOfWork uof, IMapper mapper)
    {
        _uof = uof;
        _mapper = mapper; 
    }
    public async Task<IEnumerable<GeneroDTO?>> GetAllAsync()
    {
        var generos = await _uof.GeneroRepository.GetAllAsync();
        var generosDto = _mapper.Map<IEnumerable<GeneroDTO>>(generos);  
        return generosDto;
    }
    public async Task<GeneroDTO?> GetGeneroAsync(int id)
    {
        var genero = await _uof.GeneroRepository.GetByIdAsync(g => g.GeneroId ==id);

        if (genero == null)
            return null;

        var generoDto = _mapper.Map<GeneroDTO>(genero); 
        return generoDto;   
    }
    public async Task<GeneroDTO> AddAsync(GeneroDTO generoDto)
    {
        var genero = _mapper.Map<Genero>(generoDto);
        await _uof.GeneroRepository.AddAsync(genero);
        await _uof.Commit();

        return _mapper.Map<GeneroDTO>(genero);
    }
    public async Task<GeneroDTO?> Update(int id, GeneroDTO generoDto)
    {
        if (id != generoDto.GeneroId)
            return null;

        var genero = await _uof.GeneroRepository.GetByIdAsync(g => g.GeneroId==id);

        if(genero == null)
            return null;    

        _mapper.Map(generoDto, genero);
        await _uof.Commit();

        var generoAtualizado = _mapper.Map<GeneroDTO>(genero);
        return generoAtualizado;
    }
}
