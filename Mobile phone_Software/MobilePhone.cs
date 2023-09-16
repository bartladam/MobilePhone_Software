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
        private string phoneName { get; set; }
        private Random randomSerialNumber { get; set; }
        private Memory memory { get; set; }

        public MobilePhone(string phoneName, Memory memory)
        {
            this.phoneName = phoneName;
            randomSerialNumber = new Random();
            serialNumber = randomSerialNumber.Next();
            this.memory = memory;
            OpenSoftware();
        }
        public void OpenSoftware()
        {
            // memory select software 
        }
        public override string ToString()
        {
            return serialNumber.ToString();
        }
    }
}
