using LibraryManagementSystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Infrastructure.Clients
{
    internal class BookApiClient : IBookApi
    {
        ApiCaller<object> api = new ApiCaller<object>();

        public async Task<List<BookDTO>> GetBooksAsync()
        {
            var response = await api.SendRequest("users/2");
            return new List<BookDTO>();
        }
    }
}
