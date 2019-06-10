using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandRegisterDbContext())
            {
                List<Band> allBands = db.Bands.ToList();

                return this.View(allBands);
            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }

            using (var db = new BandRegisterDbContext())
            {

                db.Bands.Add(band);
                db.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandRegisterDbContext())
            {
                Band currentBand = db.Bands.Find(id);

                return this.View(currentBand);

            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }

            using (var db = new BandRegisterDbContext())
            {

                db.Bands.Update(band);
                db.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandRegisterDbContext())
            {
                Band currentBand = db.Bands.Find(id);

                return this.View(currentBand);

            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            
            using (var db = new BandRegisterDbContext())
            {
                
                db.Bands.Remove(band);
                db.SaveChanges();

            }

            return RedirectToAction("Index");
        }
    }
}