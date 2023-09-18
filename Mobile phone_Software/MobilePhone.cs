using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    /// <summary>
    /// Mobile phone represent device user
    /// </summary>
    internal class MobilePhone
    {
        /// <summary>
        /// Mobile phone has serial number for recognize him.
        /// </summary>
        private long serialNumber { get; set; }
        /// <summary>
        /// Phone name is used is next element for recognize him
        /// </summary>
        public string phoneName { get; set; }
        /// <summary>
        /// Phone get random serial number. Someone who buy mobile phone, can't choice serial number
        /// </summary>
        private Random randomSerialNumber { get; set; }
        /// <summary>
        /// Each mobile phone has memory for apps, pictures etc.
        /// </summary>
        public Memory memory { get; set; }
        /// <summary>
        /// telephone number we need for call, SMS someone
        /// </summary>
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
        /// <summary>
        /// From memory is booted software when we telephone turn on
        /// </summary>
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
