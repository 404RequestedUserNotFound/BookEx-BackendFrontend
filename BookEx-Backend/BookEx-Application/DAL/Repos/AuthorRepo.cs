using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AuthorRepo : Repo, IRepo<Author, int, bool>
    {
        public bool Delete(int id)
        {
            var ext = db.Author.Find(id);
            db.Author.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<Author> Get()
        {
            return db.Author.ToList();
        }

        public Author Get(int id)
        {
            return db.Author.Find(id);
        }

        public bool Insert(Author obj)
        {
            db.Author.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Author obj)
        {
            var ext = Get(obj.AuthorId);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

    }
}
