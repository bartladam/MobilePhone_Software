using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Telephone
    {
        public List<MobilePhone> contacts { get; set; }
        public Telephone()
        {
            contacts = new List<MobilePhone>();
        }
        public string Call(string? nameContact, bool SMS, string? text)
        {
            if(nameContact is null)
            {
                return string.Format("Cant finish process");
            }
            else
            {
                foreach (MobilePhone item in contacts)
                {
                    if(nameContact.Equals(item.phoneName))
                    {
                        foreach (object apps in item.memory.AppsInMemory())
                        {
                            if(apps is Telephone && SMS is false)
                            {
                                return ((Telephone)apps).RecieveCall(55844); // repair number telephone
                            }
                            else if(apps is SMS && SMS)
                            {
                                return ((SMS)apps).RecieveSMS(text);
                            }
                                
                        }
                    }
                       
                }
            }
            return string.Format("We are apologize, the contact doesn't exists");
        }
        public string RecieveCall(int telephoneNumber)
        {
            return string.Format("Incoming call from number: {0}", telephoneNumber);
        }
        public virtual string AddContact(string nameContact, int telephoneNumber)
        {
            if(nameContact is not null && telephoneNumber.ToString().Length >= 9)
            {
                contacts.Add(new MobilePhone(nameContact, new Memory(new Software()), telephoneNumber));
                return string.Format("Contact sucesfully added your contacts");
            }
            return string.Format("Contact name has zero chars or telephone number is less than 6 numbers");
        }
        public virtual string RemoveContact(string nameContact)
        {
            foreach (MobilePhone item in contacts)
            {
                if (item.phoneName.Equals(nameContact))
                {
                    contacts.Remove(item);
                    return string.Format("Contact removed successfully.");

                }
            }
            return string.Format("Contanct not found.");
        }
        public string ListContacts()
        {
            string listContacts = "";
            foreach (MobilePhone item in contacts)
            {
                listContacts += string.Format("\nName: {0}\nTelephone number: {1}\n-----------------", item.phoneName, item.telephoneNumber);
            }
            if (listContacts is "")
                return string.Format("You don't have any contacts yet");
            return listContacts;
        }


    }
}
