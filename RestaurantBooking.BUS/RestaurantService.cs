using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantBooking.DAL.Entities;

namespace RestaurantBooking.BUS
{
    public class RestaurantService
    {
        private RestaurantBookingDB _context = new RestaurantBookingDB();
        public List<RESTAURANT> ListRestaurant()
        {
            return _context.RESTAURANTs.ToList();
        }
        public List<RESERVATION> ListResservation()
        {
            return _context.RESERVATIONs.ToList();
        }
        public List<CANCELLATION> ListCancellation()
        {
            return _context.CANCELLATIONs.ToList();
        }
        public List<SERVICE> ListService()
        {
            return _context.SERVICEs.ToList();
        }
        public List<MENUITEM> listItem(RESTAURANT mainRes)
        {
            return mainRes.MENUITEMs.ToList();
        }
        public double GetAveratePrice(RESTAURANT mainRes)
        {
            return mainRes.MENUITEMs.Average(m => m.PRICE);
        }
        public List<RESERVATION> getListReservedCurrentUser(USER mainUser)
        {
            return ListResservation()
                    .Where(r =>
                    r.ID_USER == mainUser.ID_USER &&
                    r.DATE_RESERVATION.HasValue &&
                    r.DATE_RESERVATION.Value.Date > DateTime.Now)
                    .OrderBy(r => r.DATE_RESERVATION)
                    .ToList();
        }
        public List<RESERVATION> getListCompletedCurrentUser(USER mainUser)
        {
            return ListResservation()
                    .Where(r =>
                    r.ID_USER == mainUser.ID_USER &&
                    r.DATE_RESERVATION.HasValue &&
                    r.DATE_RESERVATION.Value.Date < DateTime.Now)
                    .OrderBy(r => r.DATE_RESERVATION)
                    .ToList();
        }
        public List<CANCELLATION> getListCanceledCurrentUser(USER mainUser)
        {
            return ListCancellation()
                    .Where(c => c.ID_USER == mainUser.ID_USER)
                    .OrderBy(c => c.DATE_CAN)
                    .ToList();
        }
        //public SERVICE GetServiceReservation(RESERVATION reservation)
        //{
        //    return ListService().FirstOrDefault(s => s.ID_SER == reservation.ID_SER);
        //}
        public RESTAURANT GetRestaurantReservation(RESERVATION reservation)
        {
            return ListRestaurant().FirstOrDefault(s => s.ID_RES == GetRestaurantReservation(reservation).ID_RES);
        }
        public RESERVATION GetCancelReservation(CANCELLATION cancellation)
        {
            return ListResservation().FirstOrDefault(r => r.ID_RESERVATION == cancellation.ID_RESERVATION);
        }

        public bool checkIsCancelled(RESERVATION reservation)
        {
            return ListCancellation().Any(c => c.ID_RESERVATION == reservation.ID_RESERVATION && c.ID_USER == reservation.ID_USER);
        }
        public List<MENUITEM> GetMenuItemsByRestaurant(string restaurantId)
        {
            return _context.MENUITEMs.Where(m => m.ID_RES == restaurantId).ToList();
        }
    }
}
