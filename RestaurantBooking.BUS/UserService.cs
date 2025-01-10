using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBooking.DAL.Entities;

namespace RestaurantBooking.BUS
{
    public class UserService
    {
        private RestaurantBookingDB _context = new RestaurantBookingDB();

        public USER GetUser(string id)
        {
            return _context.USERs.Find(id);
        }
        public void saveUser(USER user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public int GetNextReservationId()
        {
            if (!_context.RESERVATIONs.Any())
                return 1;
            return _context.RESERVATIONs.Max(r => r.ID_RESERVATION) + 1;
        }
        public void AddReservation(RESERVATION reservation)
        {
            _context.RESERVATIONs.Add(reservation);
            _context.SaveChanges();
        }
        public void UpdateReservation(RESERVATION reservation)
        {
            _context.Entry(reservation).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteReservation(RESERVATION reservation)
        {
            _context.RESERVATIONs.Remove(reservation);
            _context.SaveChanges();
        }
        public List<RESERVATION> GetReservations(string userId)
        {
            return _context.RESERVATIONs.Where(r => r.ID_USER == userId).ToList();
        }

    }
}
