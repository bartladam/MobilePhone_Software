using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Telephone
    {
        public List<MobilePhone> contacts { get; private set; }
        public string Call(int? telephoneNumber)
        {
            if(telephoneNumber is null)
            {
                return string.Format("We are apologize, the contact doesn't exists");
            }
            else
            {
                foreach (MobilePhone item in contacts)
                {
                    if(telephoneNumber.Equals(item.telephoneNumber))
                    {

                    }
                       
                }
            }
            return "";
        }
        public string RecieveCall(int telephoneNumber)
        {
            return string.Format("Incoming call from number: {0}", telephoneNumber);
        }

    }
}
