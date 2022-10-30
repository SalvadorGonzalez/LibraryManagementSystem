using LibraryManagementSystem.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Interfaces
{
    public interface IBookService
    {
        Task<List<BookModel>> GetBooksAsync();
    }
}
