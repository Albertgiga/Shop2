using Shop_Lessons.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Lessons.ViewModels
{
    public class CarsListViewModel
    {// koment 3
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }
    }
}
