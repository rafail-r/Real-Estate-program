using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class DBHotels
    {
        public String address_id;
        public String name;
        public String type;
        public String stars;

        public DBHotels(String n, String t, String s)
        {
            name = n;
            type = t;
            stars = s;
        }

    }
}
