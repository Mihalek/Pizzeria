using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly DataContext dataContext;
        public PizzaService(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }
        public async Task <IEnumerable<Pizza>> GetPizzas()
        {
            var pizzas = await dataContext.Pizzas.ToListAsync();

            return pizzas;
        }
    }
}
