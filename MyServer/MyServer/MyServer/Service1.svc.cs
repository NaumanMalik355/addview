using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public void  Register(string usernm, string paswrd)
        {
            {
                UserClass u = new UserClass();
                u.Username = usernm;
                u.Password = paswrd;
                UserDL.user_list.Add(u);
            }
        }
        public bool is_valid(string usernm, string paswrd)
        {
           bool  is_found = false;
            foreach (UserClass s in UserDL.user_list)
            {
                if (s.Username == usernm && s.Password==paswrd)
                {
                    is_found = true;
                }
            }
            return is_found;
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
