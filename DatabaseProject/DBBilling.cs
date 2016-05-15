using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class DBBilling
    {
        public String book_id;
        public String amount;
        public String way_pay;

        public DBBilling(String a, String w_p, DateTime d)
        {
            amount = a;
            way_pay = w_p;
        }
    }
}
