using PieShop.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Data
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies();
        Pie PieById(int id);
    }
}
