using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    /// <summary>
    /// Apps makes user life easier 
    /// </summary>
    internal class Application
    {
        /// <summary>
        /// We offer application in google play store. We have to recognize app from others
        /// </summary>
        public string nameApp{ get; private set; }
        /// <summary>
        /// If application is downloaded in memory, we can't download the same application twice
        /// </summary>
        public bool downloaded { get; set; }
        /// <summary>
        /// Specific end use helps user to decide if he download app or no
        /// </summary>
        public enum typeOfApp { game, social, information, investment, music}
        public typeOfApp type { get; private set; }
        /// <summary>
        /// Each app take some space from memory
        /// </summary>
        public int sizeApp { get; set; }
        public Application(string nameApp, typeOfApp type)
        {
            this.nameApp = nameApp;
            this.type = type;
        }
    }
}
