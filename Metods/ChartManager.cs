using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    internal class ChartManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("{0} sepete eklendi.\n", product.Name);
        }
    }
}
