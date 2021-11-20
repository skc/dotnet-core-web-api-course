using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models.ViewModel
{
    public class PublisherVM
    {
        public string Name { get; set; }
    }

    public class PublisherWithBooksAndAuthorsVM
    {
        public string Name { get; set; }
        public List<BookAthorsVM> BookAthors { get; set; }
    }

    public class BookAthorsVM
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }
    }
}
