using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Application
    {
        public string nameApp{ get; private set; }
        public enum typeOfApp { game, social, information, investment, music}
        public typeOfApp type { get; private set; }
        public int sizeApp { get; set; }
        public Application(string nameApp, typeOfApp type)
        {
            this.nameApp = nameApp;
            this.type = type;
        }
    }
}
