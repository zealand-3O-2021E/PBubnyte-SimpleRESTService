using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simple_REST_Service.Managers;
using Library;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Simple_REST_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksManager _manager = new BooksManager();
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{ISPN13}")]
        public Book Get(string ISPN13)
        {
            return _manager.GetByISBN13(ISPN13);
        }

        // POST api/<BooksController>
        [HttpPost]
        public Book Post([FromBody] Book value)
        {
            return _manager.Add(value);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{ISPN13}")]
        public Book Put(string ISPN13, [FromBody] Book value)
        {
            return _manager.Update(ISPN13, value);
        }


        // DELETE api/<BooksController>/5
        [HttpDelete("{ISPN13}")]
        public Book Delete(string ISPN13)
        {
            return _manager.Delete(ISPN13);
        }
    }
}
