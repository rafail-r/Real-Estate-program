using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class DBRoom
    {
        public String hotel_id;
        public String number;
        public String type;
        public String price;
        public String persons;

        public DBRoom(String n, String t, String p, String pe)
        {
            number = n;
            type = t;
            price = p;
            persons = pe;
        }
    }
}
