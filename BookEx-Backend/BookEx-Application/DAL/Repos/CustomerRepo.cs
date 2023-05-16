using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : Repo, IRepo<Customer, int, bool>
    {
        public bool Delete(int id)
        {
            var ext = db.Customer.Find(id);
            db.Customer.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<Customer> Get()
        {
            return db.Customer.ToList();
        }

        public Customer Get(int id)
        {
            return db.Customer.Find(id);
        }

        public bool Insert(Customer obj)
        {
            db.Customer.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Customer obj)
        {
            var ext = Get(obj.CustomerId);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}

