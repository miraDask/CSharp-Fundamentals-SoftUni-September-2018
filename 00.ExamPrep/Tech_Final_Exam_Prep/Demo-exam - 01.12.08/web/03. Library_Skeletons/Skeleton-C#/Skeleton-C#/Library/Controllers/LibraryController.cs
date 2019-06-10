using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new Data.BookLibraryDbContext())
            {
                var books = db.Books.ToList();
                return View(books);
            }
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (var db = new Data.BookLibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
  
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new Data.BookLibraryDbContext())
            {
                var bookToEdit = db.Books.Find(id);
                return View(bookToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            using (var db = new Data.BookLibraryDbContext())
            {
                db.Books.Update(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            using (var db = new Data.BookLibraryDbContext())
            {
                var bookToDelete = db.Books.Find(id);
                return View(bookToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new Data.BookLibraryDbContext())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}