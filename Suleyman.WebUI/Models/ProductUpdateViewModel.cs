using System.Collections.Generic;
using Suleyman.Entities.Concrete;

namespace Suleyman.WebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}