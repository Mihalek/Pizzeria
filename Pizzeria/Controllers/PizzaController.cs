using Microsoft.AspNetCore.Mvc;
using Pizzeria.Data;
using Pizzeria.Models;
using Pizzeria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaService pizzaService;
        public PizzaController(IPizzaService _pizzaService)
        {
            pizzaService = _pizzaService;
        }
        
        
        public async Task <IActionResult> Index()
        {
            var pizzas = await pizzaService.GetPizzas();
            return View(pizzas);
        }

        public async Task<IActionResult> ShoppingList()
        {
            return View();
        }
    }
}
