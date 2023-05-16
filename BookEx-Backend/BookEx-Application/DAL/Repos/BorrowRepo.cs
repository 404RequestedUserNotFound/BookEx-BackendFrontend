using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BorrowRepo : Repo, IRepo<Borrow, int, bool>
    {

        public bool Delete(int id)
        {
            var dlt = db.Borrow.Find(id);
            db.Borrow.Remove(dlt);
            return db.SaveChanges() > 0;
        }

        public List<Borrow> Get()
        {
            return db.Borrow.ToList();
        }

        public Borrow Get(int id)
        {
            return db.Borrow.Find(id);
        }

        public bool Insert(Borrow obj)
        {
            db.Borrow.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Borrow obj)
        {
            var ext = Get(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
