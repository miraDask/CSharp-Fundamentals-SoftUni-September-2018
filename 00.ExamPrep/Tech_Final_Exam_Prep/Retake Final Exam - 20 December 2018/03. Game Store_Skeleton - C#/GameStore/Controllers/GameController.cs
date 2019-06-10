using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            //TODO: Implement me ...
        }

        [HttpGet]
        public IActionResult Create()
        {
            //TODO: Implement me ...
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            //TODO: Implement me ...
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //TODO: Implement me ...
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            //TODO: Implement me ...
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //TODO: Implement me ...
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            //TODO: Implement me ...
        }
    }
}