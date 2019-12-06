using Suleyman.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suleyman.Bussines.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
