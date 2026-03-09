using Biblioteca.Application.DTOs;
using Biblioteca.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBiblioteca.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LivroController : ControllerBase
{
    private readonly LivroService _livroService;
    public LivroController(LivroService livroService)
    {
        _livroService = livroService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LivroDTO>>> Get()
    {
        var livros = await _livroService.GetAllAsync();
        if(!livros.Any())
            return NotFound("Livros não encontrados!");
        return Ok(livros);
    }
    [HttpGet("{id:int:min(1)}", Name ="ObterLivro")]
    public async Task<ActionResult<LivroDTO>> Get(int id)
    {
        if (id <= 0)
            return BadRequest($"Id de livro inválido!");

        var livro = await _livroService.GetLivroAsync(id);

        if (livro is null)
            return NotFound($"Livro de Id = {id} não encontrado!");

        return Ok(livro);
    }

    [HttpPost]
    public async Task<ActionResult<LivroDTO>> Post(LivroDTO livro)
    {
        if (livro is null)
            return BadRequest();

        var livroCriado = await _livroService.AddAsync(livro);

        if (livroCriado is null)
            return BadRequest();

        return Ok(livroCriado);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<LivroDTO>> Put(int id, LivroDTO livro)
    {
        if(id != livro.LivroId)
            return BadRequest("Dados inválidos!");

        var livroAtualizado = await _livroService.Update(id, livro);

        if(livroAtualizado is null)
            return BadRequest();

        return Ok(livroAtualizado); 
    }

    

}
