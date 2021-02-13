using System.Collections.Generic;

namespace PieShop.Core
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
    }

}
