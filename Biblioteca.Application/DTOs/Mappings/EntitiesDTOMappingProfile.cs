using AutoMapper;
using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Application.DTOs.Mappings;

public class EntitiesDTOMappingProfile : Profile
{
    public EntitiesDTOMappingProfile()
    {
        CreateMap<Livro, LivroDTO>().ReverseMap();
        CreateMap<Genero, GeneroDTO>().ReverseMap();
    }
}
