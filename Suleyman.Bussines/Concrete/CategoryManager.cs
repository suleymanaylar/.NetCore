using Suleyman.Bussines.Abstract;
using Suleyman.DataAccess.Abstract;
using Suleyman.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suleyman.Bussines.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
