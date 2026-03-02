using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Infraestructure.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Livro>? Livros { get; set; }
        public DbSet<Genero>? Generos { get; set; }

        
    }
}
