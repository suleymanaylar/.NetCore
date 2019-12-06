using Suleyman.Core.DataAccess.EntityFramework;
using Suleyman.DataAccess.Abstract;
using Suleyman.DataAccess.Concrete.EntitiyFramework;
using Suleyman.Entities.Concrete;

namespace Suleyman.DataAccess.Concrete
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
