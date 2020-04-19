using CleanArchitecture.Core.Entities;
using CleanArchitecture.SharedKernel.Interfaces;
using CleanArchitecture.Web.ApiModels;
using CleanArchitecture.Web.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CleanArchitecture.Web.Api
{
    public class UserController : BaseApiController
    {
        private readonly IRepository _repository;

        public UserController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/ToDoItems
        [HttpGet]
        public IActionResult List()
        {
            var items = _repository.List<User>();
            return Ok(items);
        }

        // GET: api/ToDoItems
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok("essa veio de Login Controller com id: " + id);
        }

        // POST: api/Login
        [HttpPost]
        public IActionResult Post([FromBody] LoginDTO credentials)
        {
            credentials._id = "5e985ec2cc79c97ccca4e235";
            return Ok(credentials);
        }
    }
}
