using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Software
    {
        public double versionSoftware { get; set; } = 1.0d;
        public int sizeSoftware { get; private set; }
        private Memory memory { get; set; }
        public Software(Memory memory)
        {
            this.memory = memory;
        }
        public async void ShowInterface()
        {
            Console.WriteLine("Hello...\nv.{0}", versionSoftware);
            await Task.Delay(2000);
            Console.Write(@"
1 - Telephone
2 - SMS
3 - SETTINGS
4 - GOOGLE PLAY
5 - DOWNLOADED APPS");
            Console.Write("Select: ");
            char choice = Console.ReadKey().KeyChar;
            switch(choice)
            {
                case '1':
                    Telephone telephone = (Telephone)AppsInMemory("Telephone");
                    break;
                case '2':
                    SMS sms = (SMS)AppsInMemory("Telephone");
                    break;


            }
        }
        public void UpdateSoftware()
        {
            versionSoftware += 0.1d;
        }
        public object AppsInMemory(string findObject)
        {
            object founded = null;
            foreach (var item in memory.application)
            {
                founded = item;
            }
            return founded;

        }
        public override string ToString()
        {
            return string.Format("v.{0}", versionSoftware);
        }
    }
}
