using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GettingStartedApi.Controllers;

// CRUD - CREATE, READ, UPDATE, and DELETE
// GET, POST, PUT, PATCH, DELETE

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    // GET: api/<UsersController> i.e. api/Users in our Case
    [HttpGet]
    public IEnumerable<string> Get()
    {
        List<string> output = new List<string>();

        for (int i = 0; i < Random.Shared.Next(2, 10); i++)
        {
            output.Add($"Value # {i + 1}");
        }

        return output;
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $" Value # {id+1}";
    }

    // POST creates a new record
    // POST api/<UsersController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT updates a whole record (or possibly creates)
    // PUT api/<UsersController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // PATCH updates part of a record
    // PATCH api/<UsersController>/5
    [HttpPatch("{id}")]
    public void Patch(int id, [FromBody] string emailAddress)
    {

    }

    // DELETE deletes a record
    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
