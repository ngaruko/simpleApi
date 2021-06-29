using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
public class PeopleController : ControllerBase
{
    [HttpGet("people")]
    public ActionResult<IEnumerable<Person>> GetAll()
    {
        return new []
        {
            new Person { Id = 01, Name = "Ana" , Age = 23},
            new Person { Id = 02, Name = "Moses" , Age = 132 },
            new Person { Id = 03, Name = "Cathy" , Age = 90 }
        };
    }

    [HttpGet("people/{id}")]
    public ActionResult<string> Get(int id)
    {
        return "error message";
    }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}