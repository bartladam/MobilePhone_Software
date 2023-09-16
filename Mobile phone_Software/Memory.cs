using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Memory
    {
        private const int sizeMemory = 500; // MB
        public int memoryStatus { get; set; }
        public Software software { get; set; }
        public Memory(Software software)
        {
            //memoryStatus = software.size
            this.software = software;
        }
        public string StatusMemory() => string.Format("Memory is filled up:\n{0}/{1} ({2})", memoryStatus, sizeMemory, (memoryStatus/sizeMemory)*100);

    }
}
