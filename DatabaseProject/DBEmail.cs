using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class DBEmail
    {
        public List<String> emails;
        public String customerId;

        public DBEmail(String em)
        {
            em.Replace(" ", String.Empty);
            String[] ems = em.Split(',');
            emails = new List<String>();
            foreach(String e in ems)
            {
                emails.Add(e);
            }
        }
    }
}
