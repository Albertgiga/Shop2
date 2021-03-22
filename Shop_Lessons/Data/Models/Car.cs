using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Lessons.Data.Models
{
    public class Car
    {
        public int id { get; set; }

        public string name { get; set; }

        public string shortDesc { get; set; }

        public string longDesc { get; set; }

        public string img { get; set; }

        public uint price { get; set; }

        public bool isFavourite { get; set; }

        public bool available { get; set; }

        public int categoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
