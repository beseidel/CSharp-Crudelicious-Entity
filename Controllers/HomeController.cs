using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }


        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.DishTable.OrderBy(d => d.CreatedAt).Take(5).ToList();
            return View(AllDishes);
        }


        [Route("AddNew")]
        [HttpGet]
        public IActionResult AddNew()
        {
            return View("AddNew");
        }


        [Route("new")]
        [HttpPost]
        public IActionResult Add(Dish submitted_dish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(submitted_dish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("AddNew");
            }
        }



        [HttpGet("view/{id}")]
        public IActionResult ViewOne(int id)
        {
            Dish selectedDish = dbContext.DishTable.FirstOrDefault(dish => dish.Id == id);
            return View("ViewOne", selectedDish);
        }




        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            Dish selectedDish = dbContext.DishTable.FirstOrDefault(dish => dish.Id == id);
            return View("Edit", selectedDish);
        }



        [HttpPost("{id}")]
        public IActionResult Update(int id, Dish dish)
        {
            Dish RetrievedDish = dbContext.DishTable.FirstOrDefault(d => d.Id == id);


            if (ModelState.IsValid)
            {
                RetrievedDish.ChefName = dish.ChefName;
                RetrievedDish.DishName = dish.DishName;
                RetrievedDish.Calories = dish.Calories;
                RetrievedDish.Tastiness = dish.Tastiness;
                RetrievedDish.Descriptions = dish.Descriptions;
                RetrievedDish.UpdatedAt = DateTime.Now;

                dbContext.SaveChanges();

                return RedirectToAction("ViewOne", id);
            }
            else
            {
                return View("Edit", RetrievedDish);
            }
        }


        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Dish RetrievedDish = dbContext.DishTable.SingleOrDefault(dish => dish.Id == id);
            dbContext.DishTable.Remove(RetrievedDish);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
