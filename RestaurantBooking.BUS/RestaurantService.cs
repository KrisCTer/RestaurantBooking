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
        public RESTAURANT GetRestaurantReservation(RESERVATION reservation)
        {
            return ListRestaurant().FirstOrDefault(s => s.ID_RES == reservation.ID_RES);
        }
        public RESERVATION GetCancelReservation(CANCELLATION cancellation)
        {
            return ListResservation().FirstOrDefault(r => r.ID_RESERVATION == cancellation.ID_RESERVATION);
        }
        public bool AddToCanceled(RESERVATION reservation)
        {
            try
            {
                // Tạo bản ghi mới cho bảng Canceled
                CANCELLATION canceledReservation = new CANCELLATION
                {
                    ID_CAN = GetNextCanceledId(),
                    ID_RESERVATION = reservation.ID_RESERVATION,
                    ID_RES = reservation.ID_RES,
                    REFUND_AMOUNT = 0,
                    ID_USER = reservation.ID_USER,
                    DATE_CAN = DateTime.Now
                };

                _context.CANCELLATIONs.Add(canceledReservation);
                _context.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteReservation(RESERVATION reservation)
        {
            try
            {
                // Tìm reservation cần xóa
                var reservationToDelete = _context.RESERVATIONs.FirstOrDefault(r =>
                    r.ID_RESERVATION == reservation.ID_RESERVATION &&
                    r.ID_RES == reservation.ID_RES &&
                    r.ID_USER == reservation.ID_USER);

                if (reservationToDelete != null)
                {
                    // Xóa reservation
                    _context.RESERVATIONs.Remove(reservationToDelete);
                    _context.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        // Phương thức phụ trợ để lấy ID tiếp theo cho bảng Canceled
        private int GetNextCanceledId()
        {
            if (!_context.CANCELLATIONs.Any())
                return 1;
            return _context.CANCELLATIONs.Max(c => c.ID_CAN) + 1;

        }
        public bool checkIsReservation(RESERVATION reservation)
        {
            return ListCancellation().Any(c => c.ID_RESERVATION == reservation.ID_RESERVATION && c.ID_USER == reservation.ID_USER);
        }
        public List<MENUITEM> GetMenuItemsByRestaurant(string restaurantId)
        {
            return _context.MENUITEMs.Where(m => m.ID_RES == restaurantId).ToList();
        }
        public List<RESTAURANT> GetAllRestaurantByLocation()
        {
            return ListRestaurant().GroupBy(r => r.LOCATION).Select(r => r.First()).ToList();
        }
        public List<RESTAURANT> GetRestaurantByLocation(string location)
        {
            return ListRestaurant().Where(r => r.LOCATION == location).ToList();
        }
        public List<RESTAURANT> GetAllLocation()
        {
            return ListRestaurant().GroupBy(r => r.LOCATION).Select(r => r.First()).ToList();
        }
        public List<SERVICE> listService()
        {
            return _context.SERVICEs.ToList();
        }
    }
}
