using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class SMS:Telephone
    {
        private List<string> textSMS { get; set; }
        private Telephone telephone { get; set; }
        public SMS(Telephone telephone)
        {
            textSMS = new List<string>();
            this.telephone = telephone;
        }

        public void ImportContact()
        {
            contacts = telephone.contacts;
        }
        public string RecieveSMS(string text)
        {
            textSMS.Add(text);
            return string.Format("You have got message: \n{0}", text);
        }

            


    }
}
