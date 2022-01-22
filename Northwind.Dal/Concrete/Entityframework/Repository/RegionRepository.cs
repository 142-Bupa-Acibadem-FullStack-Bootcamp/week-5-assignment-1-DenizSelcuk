using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class RegionRepository : EntityRepositoryBase<Region>, IRegionRepository
    {
        public RegionRepository(DbContext context) : base(context)
        {
        }
    }
}