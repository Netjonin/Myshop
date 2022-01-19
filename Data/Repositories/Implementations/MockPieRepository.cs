using MyShop.Data.Repositories.Interfaces;
using MyShop.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data.Repositories.Implementations
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepo = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie> 
        { 
            
            new Pie{PieId = 1, Name = "Strawberry pie", Price = 15.9M, ShortDescription = "Nice and tasty"},
            new Pie{PieId = 1, Name = "Cheese cake", Price = 12.1M, ShortDescription = "Yummy"},
            new Pie{PieId = 1, Name = "Rhubarb pie", Price = 6.4M, ShortDescription = "Yummy and smooth"},
            new Pie{PieId = 1, Name = "Pumpkin pie", Price = 8.4M, ShortDescription = "Tasty and yummy"}
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
