using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    /// <summary>
    /// Via google play we can download, removed some application
    /// </summary>
    internal class GooglePlay
    {
        /// <summary>
        /// When we download app, we have to save app to memory
        /// </summary>
        private Memory memory { get; set; }
        /// <summary>
        /// Here we saving all apps what google play offer 
        /// </summary>
        public List<Application> apps { get; set; }
        public GooglePlay(Memory memory)
        {
            apps = new List<Application>();
            apps.Add(new Application("Spotify", Application.typeOfApp.music) { sizeApp = 40, downloaded = false });
            apps.Add(new Application("eToro", Application.typeOfApp.investment) { sizeApp = 100, downloaded = false });
            apps.Add(new Application("Clash of Clans", Application.typeOfApp.game) { sizeApp = 150, downloaded = false });
            this.memory = memory;
        }
        /// <summary>
        /// User have to know about offered applications. He can't download app when he doesn't see it
        /// </summary>
        /// <returns></returns>
        public string ShowAppsInStore()
        {
            string nameApps = "";
            var applications = from i in apps
                               orderby i.nameApp
                               select new {Name = "Name: "+i.nameApp, Type = "Type application:" + i.type, Size = "Size: "+i.sizeApp};
            foreach (var item in applications)
            {
                nameApps += string.Format("{0}\n{1}\n{2} MB\n\n", item.Name, item.Type, item.Size);
            }
            return nameApps;
        }
        /// <summary>
        /// When user is decided about app what he want, he has to download it
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public string DownloadApp(Application application)
        {
            if(application.downloaded is false)
            {
                memory.AddApp(application);
                application.downloaded = true;
                return string.Format("Downloaded app: {0}", application.nameApp);
            }
            return string.Format("App can not be downloaded.");

        }
        /// <summary>
        /// User can remove app from memory
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        public string UninstallApp(Application application)
        {
            memory.RemoveApp(application);
            application.downloaded = false;
            return string.Format("Application was removed");
        }

        
    }
}
