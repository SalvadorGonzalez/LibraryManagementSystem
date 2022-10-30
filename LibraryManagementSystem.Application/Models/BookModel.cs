using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PagesNumber { get; set; }
        public string ImageURL { get; set; }
    }
}
