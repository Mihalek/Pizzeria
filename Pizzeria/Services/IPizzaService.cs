using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Services
{
    public interface IPizzaService
    {
        Task <IEnumerable<Pizza>> GetPizzas();
    }
}
