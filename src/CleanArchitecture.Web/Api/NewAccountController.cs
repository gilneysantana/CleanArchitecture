using CleanArchitecture.Core.Entities;
using CleanArchitecture.SharedKernel.Interfaces;
using CleanArchitecture.Web.ApiModels;
using CleanArchitecture.Web.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CleanArchitecture.Web.Api
{
    public class LoginController : BaseApiController
    {
        private readonly IRepository _repository;

        public LoginController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/ToDoItems
        [HttpGet]
        public IActionResult List()
        {
            return Ok("5e985ec2cc79c97ccca4e235");
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

        //[HttpPatch("{id:int}/complete")]
        //public IActionResult Complete(int id)
        //{
        //    var toDoItem = _repository.GetById<ToDoItem>(id);
        //    toDoItem.MarkComplete();
        //    _repository.Update(toDoItem);

        //    return Ok(ToDoItemDTO.FromToDoItem(toDoItem));
        //}
    }
}
