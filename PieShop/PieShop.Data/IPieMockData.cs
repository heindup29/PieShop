using PieShop.Core;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.Data
{
    public class IPieMockData : IPieRepository
    {
        public IEnumerable<Pie> Pies { get; set; }
        public IPieMockData()
        {
            this.Pies = new Pie[]
            {
                new Pie()
                {
                    Name = "Pepper Steak",
                    Category = Category.Meat,
                    Description = "Meat and Pepper",
                    Price = 20M,
                    Id = 0,
                    Ingredients = new string[]{ "Meat","Pepper","Dough" }
                    
                },
                new Pie()
                {
                    Name = "Sassage Roll",
                    Category = Category.Meat,
                    Description = "Meat and bread",
                    Price = 20M,
                    Id = 1,
                    Ingredients = new string[]{ "Meat","Pepper","Dough" }
                },
                new Pie()
                {
                    Name = "Cornish",
                    Category = Category.Meat,
                    Description = "Meat and Vegies",
                    Price = 21M,
                    Id = 2,
                    Ingredients = new string[]{ "Meat","Patato","Dough" }
                },
                new Pie()
                {
                    Name = "Corn and Spinage",
                    Category = Category.Vegaterian,
                    Description = "corn and spinage",
                    Price = 25M,
                    Id = 3,
                    Ingredients = new string[]{ "Corn","Spinage","Dough" }
                }
            };
        }
        public IEnumerable<Pie> AllPies()
        {
            return Pies;
        }

        public Pie PieById(int id)
        {
            return AllPies().FirstOrDefault( x => x.Id == id);
        }
    }
}
