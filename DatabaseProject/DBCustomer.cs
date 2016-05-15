using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class DBCustomer
    {
        public String addressId;
        public String name;
        public String lastname;
        public DateTime birthdate;

        public DBCustomer(String n, String l, DateTime b)
        {
            name = n;
            lastname = l;
            birthdate = b;
        }

        public String dateTimeToStr(DateTime dt)
        {
            return dt.Date.ToString("yyyy-MM-dd");
        }
    }
}
