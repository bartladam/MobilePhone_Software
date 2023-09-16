using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class GooglePlay
    {
        public string Name { get; private set; } = "Google Play";
        private Memory memory { get; set; }
        public int sizeGooglePlay { get; set; } = 250;
        public List<Application> apps { get; set; }
        public GooglePlay(Memory memory)
        {
            apps = new List<Application>();
            this.memory = memory;
        }
        public string ShowAppsInStore()
        {
            string nameApps = "";
            foreach (Application item in apps)
            {
                nameApps += string.Format("NAME: {0}\n Type application: {1}", item.nameApp, item.type);
            }
            return nameApps;
        }
        public void DownloadApp(Application application)
        {
            memory.AddApp(application);
        }
        public void UninstallApp(Application application)
        {
            memory.RemoveApp(application);
        }

        
    }
}
