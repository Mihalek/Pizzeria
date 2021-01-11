using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.ViewModels
{
    public class ItemViewModel
    {
        public Pizza Pizza { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
