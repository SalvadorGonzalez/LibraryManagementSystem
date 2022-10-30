using AutoMapper;
using LibraryManagementSystem.Application.Interfaces;
using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Services
{
    public class BookService : IBookService
    {
        IMapper _mapper;
        IBookApi _bookApi;

        public BookService(IMapper mapper, IBookApi bookApi)
        {
            _mapper = mapper;
            _bookApi = bookApi;
        }

        public async Task<List<BookModel>> GetBooksAsync()
        {
            //goes to data layer
            //mocking data
            //var bookList = new List<BookModel>();
            //bookList.Add(new BookModel() { Title = "Friends, Lovers, and the Big Terrible Thing: A Memoir", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81ZkvDcuCzL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "It Starts with Us: A Novel (It Ends with Us)", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/71PNGYHykrL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81wgcld4wxL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "Reminders of Him: A Novel", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/617uZq23IPL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "Justice Corrupted: How the Left Weaponized Our Legal System", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/712vvcgyqBL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "The Leaf Thief: (The Perfect Fall Book for Children and Toddlers)", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/A1kuBjgawsL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "Fairy Tale", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81PMOtoT7zL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "Ugly Love: A Novel", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/71E8VNPC1dL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "Demon Copperhead: A Novel", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/91mP0HKLEwL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "Fire & Blood: 300 Years Before A Game of Thrones (The Targaryen Dynasty: The House of the Dragon)", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/91k-kLccE8L._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "Where the Crawdads Sing", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81O1oy0y9eL._AC_UL210_SR195,210_.jpg" });
            //bookList.Add(new BookModel() { Title = "Goodnight Moon", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81t-IstQ+ZL._AC_UL210_SR195,210_.jpg" });

            //return bookList;
            var books = await _bookApi.GetBooksAsync();
            var result = _mapper.Map<List<BookModel>>(books);
            return result;
        }
    }
}
