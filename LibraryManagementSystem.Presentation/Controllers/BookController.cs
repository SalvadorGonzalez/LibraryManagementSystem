using LibraryManagementSystem.Presentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Presentation.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        public ActionResult Index()
        {
            var bookList = new List<BookViewModel>();
            bookList.Add(new BookViewModel() { Title = "Friends, Lovers, and the Big Terrible Thing: A Memoir", ImageURL= "https://images-na.ssl-images-amazon.com/images/I/81ZkvDcuCzL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "It Starts with Us: A Novel (It Ends with Us)", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/71PNGYHykrL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81wgcld4wxL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "Reminders of Him: A Novel", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/617uZq23IPL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "Justice Corrupted: How the Left Weaponized Our Legal System", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/712vvcgyqBL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "The Leaf Thief: (The Perfect Fall Book for Children and Toddlers)", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/A1kuBjgawsL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "Fairy Tale", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81PMOtoT7zL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "Ugly Love: A Novel", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/71E8VNPC1dL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "Demon Copperhead: A Novel", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/91mP0HKLEwL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "Fire & Blood: 300 Years Before A Game of Thrones (The Targaryen Dynasty: The House of the Dragon)", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/91k-kLccE8L._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "Where the Crawdads Sing", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81O1oy0y9eL._AC_UL210_SR195,210_.jpg" });
            bookList.Add(new BookViewModel() { Title = "Goodnight Moon", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81t-IstQ+ZL._AC_UL210_SR195,210_.jpg" });

            return View(bookList);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
