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
    internal class ReceiptRepo : Repo, IRepo<Receipt, int, bool>
    {



        public bool Delete(int id)
        {
            var ext = db.Receipt.Find(id);
            db.Receipt.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<Receipt> Get()
        {
            return db.Receipt.ToList();
        }

        public Receipt Get(int id)
        {
            return db.Receipt.Find(id);
        }

        public bool Insert(Receipt obj)
        {
            db.Receipt.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Receipt obj)
        {
            var ext = Get(obj.ReceiptId);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}