using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using RestaurantBooking.DAL.Entities;


namespace RestaurantBooking.BUS
{
    public class AuthenService
    {
        private RestaurantBookingDB _context = new RestaurantBookingDB();

        public USER RegisterUser(USER uSER)
        {
            var user = _context.USERs.Where(u => u.USERNAME == uSER.USERNAME).ToList();
            if (user.Count > 0)
            {
                throw new Exception("Username already exists");
            }
            _context.USERs.Add(uSER);
            _context.SaveChanges();
            return uSER;
        }
        public string GenerateUserId()
        {
            var lastId = _context.USERs
                .Select(u => u.ID_USER)
                .DefaultIfEmpty("U0001")
                .Max();

            int currentNumber = int.Parse(lastId.Substring(1));
            return $"U{(currentNumber + 1):D4}";
        }
        public USER Login(string username, string password)
        {
            var user = _context.USERs
                .FirstOrDefault(u =>
                    u.USERNAME == username &&
                    u.PASSWORD == password);
            return user;
        }
    }
}
