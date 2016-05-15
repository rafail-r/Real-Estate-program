using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class DBAddress
    {
        public String phone;
        public String country;
        public String city;
        public String zipcode;
        public String street;
        public int streetno;

        public DBAddress(String p, String ctr, String ct, String zip, String str, String strno)
        {
            phone = p;
            country = ctr;
            city = ct;
            zipcode = zip;
            street = str;
            streetno = Int32.Parse(strno);
        }
    }
}
