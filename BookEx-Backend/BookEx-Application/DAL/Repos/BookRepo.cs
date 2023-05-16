using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BookRepo : Repo, IRepo<Book, int, bool>
    {
        public bool Delete(int id)
        {
            var ext = db.Book.Find(id);
            db.Book.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<Book> Get()
        {
            return db.Book.ToList();
        }

        public Book Get(int id)
        {
            return db.Book.Find(id);
        }

        public bool Insert(Book obj)
        {
            db.Book.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Book obj)
        {
            var ext = Get(obj.BookId);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

    }
}



