using Biblioteca.Application.DTOs;
using Biblioteca.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBiblioteca.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GeneroController : ControllerBase
{
    private readonly GeneroService _generoService;  
    public GeneroController(GeneroService generoService)    
    {
        _generoService = generoService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<GeneroDTO>>> Get()
    {
        var generos = await _generoService.GetAllAsync();
        if (!generos.Any())
            return NotFound("Gêneros não encontrados!");
        return Ok(generos);
    }
    [HttpGet("{id:int:min(1)}", Name = "ObterGenero")]
    public async Task<ActionResult<GeneroDTO>> Get(int id)
    {
        if (id <= 0)
            return BadRequest("Id de gênero inválido!");

        var genero = await _generoService.GetGeneroAsync(id);

        if (genero is null)
            return NotFound($"Gênero de id = {id} não encontrado!");

        return Ok(genero);
    }
    [HttpPost]
    public async Task<ActionResult<GeneroDTO>> Post(GeneroDTO genero)
    {
        if (genero is null)
            return BadRequest();

        var generoCriado = await _generoService.AddAsync(genero);

        if (genero is null)
            return BadRequest();

        return Ok(generoCriado);

    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<GeneroDTO>> Put(int id, GeneroDTO genero)
    {
        if(id != genero.GeneroId)
            return BadRequest("Dados inválidos!");

        var generoAtualizado = await _generoService.Update(id, genero);

        if(generoAtualizado is null)
            return BadRequest();    

        return Ok(generoAtualizado);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<GeneroDTO>> Delete(int id)
    {
        var genero = await _generoService.GetGeneroAsync(id);

        if(genero is null)
            return BadRequest($"Gênero com id = {id} não encontrado!");

        var generoDeletado = await _generoService.Delete(id);

        return Ok(generoDeletado);
    }
}
