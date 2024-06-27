using Microsoft.AspNetCore.Mvc;

using Project002.BasicCRUD.Models;
using Project002.BasicCRUD.Repositories.IRepositories;

namespace Project002.BasicCRUD.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ToDosController : ControllerBase
{
    private readonly IGenericRepository<ToDo> _repository;

    public ToDosController(IGenericRepository<ToDo> repository)
    {
        _repository = repository;
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        if (!_repository.Exists(id))
            return NotFound();
        _repository.Delete(id);
        return NoContent();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repository.Get());
    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        if (!_repository.Exists(id))
            return NotFound();
        return Ok(_repository.Get(id));
    }

    [HttpPost]
    public IActionResult Post(ToDo obj)
    {
        obj = _repository.Add(obj);
        return CreatedAtAction(nameof(Get), new { id = obj.Id }, obj);
    }

    [HttpPut("{id:int}")]
    public IActionResult Put(int id, ToDo obj)
    {
        if (id != obj.Id)
            return BadRequest();
        if (!_repository.Exists(id))
            return NotFound();
        _repository.Update(id, obj);
        return NoContent();
    }
}
