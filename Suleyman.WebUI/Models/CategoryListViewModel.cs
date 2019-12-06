using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Suleyman.Entities.Concrete;

namespace Suleyman.WebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
