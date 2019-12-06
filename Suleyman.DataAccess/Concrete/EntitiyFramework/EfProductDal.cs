using System;
using System.Collections.Generic;
using System.Text;
using Suleyman.Core.DataAccess.EntityFramework;
using Suleyman.DataAccess.Abstract;
using Suleyman.DataAccess.Concrete.EntitiyFramework;
using Suleyman.Entities.Concrete;

namespace Suleyman.DataAccess.Concrete
{
    public class EfProductDal: EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
