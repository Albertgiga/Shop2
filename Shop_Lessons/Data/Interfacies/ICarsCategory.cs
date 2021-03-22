using Shop_Lessons.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Lessons.Data.Interfacies
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
