using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class ShipperRepository : EntityRepositoryBase<Shipper>, IShipperRepository
    {
        public ShipperRepository(DbContext context) : base(context)
        {
        }
    }
}