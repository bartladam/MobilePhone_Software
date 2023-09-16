using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Telephone
    {
        public string Name { get; private set; } = "Telephone";
        public List<MobilePhone> contacts { get; private set; }
        public Telephone()
        {
            contacts = new List<MobilePhone>();
        }
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
        public string ListContacts()
        {
            string listContacts = "";
            foreach (MobilePhone item in contacts)
            {
                listContacts += string.Format("Name: {0}\nTelephone number: {1}", item.phoneName, item.telephoneNumber);
            }
            return listContacts;
        }


    }
}
