using Suleyman.Core.DataAccess;
using Suleyman.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suleyman.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
