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

        // GET: api/user
        [HttpGet]
        public IActionResult List()
        {
            var items = _repository.List<User>();
            return Ok(items);
        }

        // GET: api/user
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var items = _repository.GetById<User>(id);
            return Ok(items);
        }

        // POST: api/user
        [HttpPost]
        public IActionResult Post([FromBody] UserDTO item)
        {
            var user = new User()
            {
                Name = item.Name,
                Email = new Email(item.Email)
            };
            _repository.Add(user);
            return Ok(UserDTO.FromUser(user));
        }
    }
}
