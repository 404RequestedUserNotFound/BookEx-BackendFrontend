using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderRepo : Repo, IRepo<Order, int, bool>
    {
        public bool Delete(int id)
        {
            var ext = db.Order.Find(id);
            db.Order.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<Order> Get()
        {
            return db.Order.ToList();
        }

        public Order Get(int id)
        {
            return db.Order.Find(id);
        }

        public bool Insert(Order obj)
        {
            db.Order.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Order obj)
        {
            var ext = Get(obj.OrderId);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

    }
}


