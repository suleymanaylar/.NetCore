using System;
using System.Linq;
using System.Text;

namespace Suleyman.Entities.Concrete
{
    public partial class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
