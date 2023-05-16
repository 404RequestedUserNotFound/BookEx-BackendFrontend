using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ReservationRepo : Repo, IRepo<Reservation, int, bool>
    {
        public bool Delete(int id)
        {
            var dlt = db.Reservation.Find(id);
            db.Reservation.Remove(dlt);
            return db.SaveChanges() > 0;
        }

        public List<Reservation> Get()
        {
            return db.Reservation.ToList();
        }

        public Reservation Get(int id)
        {
            return db.Reservation.Find(id);
        }

        public bool Insert(Reservation obj)
        {
            db.Reservation.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Reservation obj)
        {
            var ext = Get(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
