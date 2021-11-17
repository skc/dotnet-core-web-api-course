using Microsoft.AspNetCore.Mvc;
using my_books.Data.Models.ViewModel;
using my_books.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    public class AuthorsController : ControllerBase
    {
        private AuthorsService _authorsService;
        public AuthorsController(AuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody]AuthorVM author)
        {
            _authorsService.AddAuthor(author);
            return Ok();
        }
    }
}
