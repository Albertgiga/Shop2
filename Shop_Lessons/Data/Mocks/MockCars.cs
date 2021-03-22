using Shop_Lessons.Data.Interfacies;
using Shop_Lessons.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Lessons.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Model S", 
                        shortDesc = "Быстрий автомобиль",
                        longDesc = "Красивий, быстрий и очень тихий автомобиль компании  Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000, 
                        isFavourite = true, 
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойний",                        
                        longDesc = "Удобний автомобиль для городской жизни",
                        img = "/img/fiesta.jpg",
                        price = 11000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "BMW X6",
                        shortDesc = "Дерзкий и стильний",                        
                        longDesc = "Очень быстрий и комфортний автомобиль",
                        img = "/img/bmw_x6.jpg",
                        price = 100000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Lexus UX 300e",
                        shortDesc = "Тихий и спокойний",
                        longDesc = "The first all-electric offering from hybrid champion Lexus is what you might call a water-testing exercise. Already low fleet CO2 emissions mean Lexus can afford to take its time with EVs, finding out what works before committing all of its resources. ",
                        img = "/img/lexus.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "BMW iX3",
                        shortDesc = "Тихий и спокойний",
                        longDesc = "BMW has changed tack on its strategy for electrification. Having conceived the i brand to contain its very first EV and plug-in hybrid, it is now spreading electric cars among its wider model range, and the iX3 is the first of its new-wave EVs to hit the streets. It's also the first car that BMW has produced in China for export markets.",
                        img = "/img/bmw_ix3.jpg",
                        price = 86000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Ford Mustang Mach-E",
                        shortDesc = "Тихий и спокойний",
                        longDesc = "The Blue Oval is late to the full-sized electric car market, but has made something of a splash in any case by appropriating its much-loved Mustang sub-brand for its first battery-electric production model. The Mustang Mach-E isn't a square-jawed muscle coupé, though, but a proper five-seater with an appealing-looking crossover bodystyle, as well as equally appealing real-world range potential and a more affordable price than some of the cars listed here.",
                        img = "/img/mustang.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Audi A8",
                        shortDesc = "Тихий и спокойний",
                        longDesc = "The Blue Oval is late to the full-sized electric car market, but has made something of a splash in any case by appropriating its much-loved Mustang sub-brand for its first battery-electric production model. The Mustang Mach-E isn't a square-jawed muscle coupé, though, but a proper five-seater with an appealing-looking crossover bodystyle, as well as equally appealing real-world range potential and a more affordable price than some of the cars listed here.",
                        img = "/img/audi.jpg",
                        price = 80000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },                    
                    new Car {
                        name = "Range Rover",
                        shortDesc = "Тихий и спокойний",
                        longDesc = "The Blue Oval is late to the full-sized electric car market, but has made something of a splash in any case by appropriating its much-loved Mustang sub-brand for its first battery-electric production model. The Mustang Mach-E isn't a square-jawed muscle coupé, though, but a proper five-seater with an appealing-looking crossover bodystyle, as well as equally appealing real-world range potential and a more affordable price than some of the cars listed here.",
                        img = "/img/range-rover.jpg",
                        price = 270000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Mercedes C class",
                        shortDesc = "Уютний и большой",                      
                        longDesc = "Удобний автомобиль для городской жизни",
                        img = "/img/mercedes_benz_c.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
