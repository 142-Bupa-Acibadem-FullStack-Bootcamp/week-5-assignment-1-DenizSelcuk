using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class OrderRepository : EntityRepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }

        public IQueryable OrderReport(int orderId)
        {
            var t = dbset.Where(x => x.OrderId == 10262).SingleOrDefault();
            var y = t.OrderDetails;
            return null;
        }
    }
}