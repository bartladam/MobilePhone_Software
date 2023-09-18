using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    /// <summary>
    /// Mobile phone has memory where is saved software
    /// </summary>
    internal class Memory
    {
        /// <summary>
        /// Mobile phone has from manufacturing company define size internal memory
        /// </summary>
        private const float sizeMemory = 2500;
        /// <summary>
        /// maximum size is same as const size memory
        /// </summary>
        public float maximumSizeMemory { get; private set; }
        /// <summary>
        ///  How full is memory at this time
        /// </summary>
        public float memoryStatus { get; set; }
        /// <summary>
        /// In memory is saved software who is booting when we turn on mobile
        /// </summary>
        public Software software { get; set; }
        /// <summary>
        /// In memory is saved all downloaded and internal application
        /// </summary>
        private List<object> application { get; set; }
        public Memory(Software software)
        {
            application = new List<object>();
            application.Add(new Settings(this));
            application.Add(new GooglePlay(this));
            application.Add(new Telephone());
            application.Add(new SMS((Telephone)application[2])); // repair
            this.software = software;
            this.maximumSizeMemory = sizeMemory;
            memoryStatus += software.sizeSoftware; 
        }
        /// <summary>
        /// Download app is added to aplication memory
        /// </summary>
        /// <param name="application"></param>
        public void AddApp(Application application)
        {
            if(application.sizeApp + memoryStatus < sizeMemory)
            {
                this.application.Add(application);
                memoryStatus += application.sizeApp;
            }
        }
        /// <summary>
        /// Removed app is removed from memory with his size
        /// </summary>
        /// <param name="application"></param>
        public void RemoveApp(Application application)
        {
            this.application.Remove(application);
            memoryStatus -= application.sizeApp;
        }
        /// <summary>
        /// Current application in memory
        /// </summary>
        /// <returns></returns>
        public List<object> AppsInMemory() => application;
        /// <summary>
        /// Software shows how memory is full
        /// </summary>
        /// <returns></returns>
        public string StatusMemory() => string.Format("\nMemory is filled up:\n{0}/{1} ({2}%)", memoryStatus, sizeMemory, Math.Round((memoryStatus / sizeMemory) *100));
      
        

    }
}
