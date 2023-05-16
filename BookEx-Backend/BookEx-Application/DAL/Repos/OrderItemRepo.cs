using DAL.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderItemRepo : Repo, IRepo<OrderItem, int, bool>
    {
        public bool Delete(int id)
        {
            var ext = db.OrderItem.Find(id);
            db.OrderItem.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<OrderItem> Get()
        {
            return db.OrderItem.ToList();
        }

        public OrderItem Get(int id)
        {
            return db.OrderItem.Find(id);
        }

        public bool Insert(OrderItem obj)
        {
            db.OrderItem.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(OrderItem obj)
        {
            var ext = Get(obj.OrderItemId);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}