using AutoMapper;
using Biblioteca.Application.DTOs;
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
    
}
