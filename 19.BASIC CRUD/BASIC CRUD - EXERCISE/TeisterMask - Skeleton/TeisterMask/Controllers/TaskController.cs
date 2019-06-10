using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TeisterMask.Data;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new TeisterMaskDbContext())
            {
                var allTasks = db.Tasks.ToList();
                return View(allTasks);
            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (var db = new TeisterMaskDbContext())
            {
                var currentTask = new Task();
                currentTask.Title = task.Title;
                currentTask.Status = task.Status;
                db.Tasks.Add(currentTask);
                db.SaveChanges();


            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToEdit = db.Tasks.FirstOrDefault(t => t.Id == id);

                return View(taskToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task editedTask)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (var db = new TeisterMaskDbContext())
            {
                var oldTask = db.Tasks.FirstOrDefault(t => t.Id == editedTask.Id);

                oldTask.Title = editedTask.Title;
                oldTask.Status = editedTask.Status;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToDelete = db.Tasks.FirstOrDefault(t => t.Id == id);

                return View(taskToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskToDelete = db.Tasks.FirstOrDefault(t => t.Id == task.Id);

                db.Tasks.Remove(taskToDelete);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}