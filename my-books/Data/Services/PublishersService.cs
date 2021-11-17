using my_books.Data.Models;
using my_books.Data.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPublisher(PublisherVM publisherVM)
        {
            var _publisher = new Publisher()
            {
                Name = publisherVM.Name
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
