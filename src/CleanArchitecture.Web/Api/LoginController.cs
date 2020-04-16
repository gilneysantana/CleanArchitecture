using CleanArchitecture.Core.Entities;
using CleanArchitecture.SharedKernel.Interfaces;
using CleanArchitecture.Web.ApiModels;
using CleanArchitecture.Web.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CleanArchitecture.Web.Api
{
    public class NewAccountController : BaseApiController
    {
        private readonly IRepository _repository;

        public NewAccountController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewAccountDTO credentials)
        {
            return Ok(credentials);
        }
    }
}
