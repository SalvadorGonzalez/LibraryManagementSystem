using LibraryManagementSystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Infrastructure
{
    public interface IBookApi
    {
        Task<List<BookDTO>> GetBooksAsync();
    }
}
