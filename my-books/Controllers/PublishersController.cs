using Microsoft.AspNetCore.Mvc;
using my_books.Data.Models.ViewModel;
using my_books.Data.Services;
using my_books.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    public class PublishersController : ControllerBase
    {
        private PublishersService _publishersService;
        public PublishersController(PublishersService publishersService)
        {
            _publishersService = publishersService;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            _publishersService.AddPublisher(publisher);
            return Created(nameof(AddPublisher), publisher);
        }
        [HttpGet("get-publisher-with-books-with-authors-by-id/{id}")]
        public IActionResult GetPublisherWithBooksAndAuthorsById(int id)
        {
            var _response = _publishersService.GetPublisherBooksAndAuthorsById(id);
            return Ok(_response);
        }
        [HttpGet("get-publisher-by-id/{id}")]
        public IActionResult GetPublisherById(int id)
        {
            var username = AccountHelper.GetWinAuthAccount(HttpContext);
            throw new Exception($"To be handled by the middleware for {username}");
            var _publisher = _publishersService.GetPublisherById(id);
            if (_publisher == null)
            {
                return NotFound();
            }
            return Ok(_publisher);
        }
        [HttpDelete("delete-publisher-by-id/{id}")]
        public IActionResult DeletePublisherById(int id)
        {
            _publishersService.DeletePublisherById(id);
            return Ok();
        }

    }
}
