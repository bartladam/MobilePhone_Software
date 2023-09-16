using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Memory
    {
        private const float sizeMemory = 1500; // MB
        public float maximumSizeMemory { get; private set; }
        public float memoryStatus { get; set; }
        public Software software { get; set; }
        private List<object> application { get; set; }
        public Memory(Software software)
        {
            application = new List<object>();
            application.Add(new Settings(this));
            application.Add(new GooglePlay(this));
            application.Add(new Telephone());
            application.Add(new SMS());
            this.software = software;
            this.maximumSizeMemory = sizeMemory;
            memoryStatus += software.sizeSoftware; // add new settings size, google play etc
        }
        public void AddApp(Application application)
        {
            if(application.sizeApp + memoryStatus < sizeMemory)
            {
                this.application.Add(application);
                memoryStatus += application.sizeApp;
            }
        }
        public void RemoveApp(Application application)
        {
            this.application.Remove(application);
        }
        public List<object> AppsInMemory() => application;
        public string StatusMemory()
        {

            return string.Format("\nMemory is filled up:\n{0}/{1} ({2}%)", memoryStatus, sizeMemory,Math.Round((memoryStatus / sizeMemory) *100));
        }

    }
}
