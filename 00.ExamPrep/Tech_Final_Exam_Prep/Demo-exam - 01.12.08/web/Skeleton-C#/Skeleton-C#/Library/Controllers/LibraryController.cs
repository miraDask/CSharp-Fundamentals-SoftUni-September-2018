using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
       
        public IActionResult Index()
        {
            using (var db = new BookLibraryDbContext())
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

            using (var db = new BookLibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BookLibraryDbContext())
            {
                Book currentBook = db.Books.Find(id);

                return View(currentBook);
            }
            
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new BookLibraryDbContext())
            {
                db.Books.Update(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BookLibraryDbContext())
            {
                Book currentBook = db.Books.Find(id);

                return View(currentBook);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            
            using (var db = new BookLibraryDbContext())
            {
                
                db.Books.Remove(book);
                db.SaveChanges();

            }

            return RedirectToAction("Index");

        }
    }
}