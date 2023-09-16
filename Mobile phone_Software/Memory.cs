using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Memory
    {
        private const int sizeMemory = 1500; // MB
        public int memoryStatus { get; set; }
        public Software software { get; set; }
        public List<object> application { get; set; }
        public Memory(Software software)
        {
            application = new List<object>();
            application.Add(new Settings());
            application.Add(new GooglePlay());
            application.Add(new Telephone());
            application.Add(new SMS());
            this.software = software;
            memoryStatus = software.sizeSoftware; // add new settings size, google play etc
        }
        public void AddApp(Application application)
        {
            this.application.Add(application);  
            ///memoryStatus += application.size
        }
        public string StatusMemory() => string.Format("Memory is filled up:\n{0}/{1} ({2})", memoryStatus, sizeMemory, (memoryStatus/sizeMemory)*100);

    }
}
