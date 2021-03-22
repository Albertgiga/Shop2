using Shop_Lessons.Data.Interfacies;
using Shop_Lessons.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Lessons.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Современний вид транспорта"},
                    new Category {categoryName = "Классические автомобили", desc = "Машини с двигателем внутреннего згорания"}
                };
            }
        }
    }
}
