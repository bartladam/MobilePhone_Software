using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    /// <summary>
    /// Basic function each telephone
    /// </summary>
    internal class SMS:Telephone
    {
        /// <summary>
        /// We are saving all SMS text. User can want to show history of his SMS
        /// </summary>
        private List<string> textSMS { get; set; }
        /// <summary>
        /// Both, telephone and SMS has the same contacts
        /// </summary>
        private Telephone telephone { get; set; }
        public SMS(Telephone telephone)
        {
            textSMS = new List<string>();
            this.telephone = telephone;
        }
        /// <summary>
        /// SMS has the same contacts as Telephone
        /// </summary>
        public void ImportContact()
        {
            contacts = telephone.contacts;
        }
        /// <summary>
        /// Software user can add someone to contact
        /// </summary>
        /// <param name="nameContact"></param>
        /// <param name="telephoneNumber"></param>
        /// <returns></returns>
        public override string AddContact(string nameContact, int telephoneNumber)
        {
            return telephone.AddContact(nameContact, telephoneNumber);
        }
        /// <summary>
        /// Software user can removed someone from contact
        /// </summary>
        /// <param name="nameContact"></param>
        /// <returns></returns>
        public override string RemoveContact(string nameContact)
        {
            return telephone.RemoveContact(nameContact);
        }
        /// <summary>
        /// We received SMS from another device
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string RecieveSMS(string text)
        {
            textSMS.Add(text);
            return string.Format("You have got message: \n{0}", text);
        }

            


    }
}
