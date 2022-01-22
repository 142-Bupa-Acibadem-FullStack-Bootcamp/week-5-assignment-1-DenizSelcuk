using Microsoft.EntityFrameworkCore;

using Northwind.Entity.Models;


namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class CategoryRepository : EntityRepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
