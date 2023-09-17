using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class MobilePhone
    {
        private long serialNumber { get; set; }
        public string phoneName { get; set; }
        private Random randomSerialNumber { get; set; }
        public Memory memory { get; set; }
        public int telephoneNumber { get; private set; }

        public MobilePhone(string phoneName, Memory memory, int telephoneNumber)
        {
            this.phoneName = phoneName;
            randomSerialNumber = new Random();
            serialNumber = randomSerialNumber.Next();
            this.memory = memory;
            this.telephoneNumber = telephoneNumber;
            //OpenSoftware();
        }
        public void OpenSoftware()
        {
            memory.software.ShowInterface(memory);
        }
        public override string ToString()
        {
            return serialNumber.ToString();
        }
    }
}
