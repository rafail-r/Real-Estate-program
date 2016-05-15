using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class DBBooking
    {
        public String cust_id;
        public String hotel_id;
        public String room_number;
        public DateTime book_date;
        public DateTime first_date;
        public DateTime last_date;

        public DBBooking(String c, String h, DateTime f_d, DateTime l_d)
        {
            cust_id = c;
            hotel_id = h;
            book_date = DateTime.Now;
            first_date = f_d;
            last_date = l_d;
        }

        public String dateTimeToStr(DateTime dt)
        {
            return dt.Date.ToString("yyyy-MM-dd");
        }
    }
}
