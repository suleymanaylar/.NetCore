using Suleyman.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suleyman.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
