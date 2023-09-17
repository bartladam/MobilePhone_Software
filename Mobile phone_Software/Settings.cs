using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Settings
    {
        private Memory memory { get; set; }
        public int sizeSettings { get; set; } = 150;
        public Settings(Memory memory)
        {
            this.memory = memory;
        }
        public ConsoleColor ChangeTheme(ConsoleColor colorBackground, ConsoleColor colorForeground)
        {
            Console.BackgroundColor = colorBackground;
            Console.ForegroundColor = colorForeground;
            return colorBackground;
        }
        public string UpdateSoftware(Software software) 
        {
            if(software.versionSoftware < 2.0d && software.sizeSoftware + 200d < memory.maximumSizeMemory)
            {
                software.versionSoftware += 0.1d;
                software.sizeSoftware += 200;
                memory.memoryStatus += 200;
                return string.Format("Updated on version: {0}",software.versionSoftware);
            }
            return string.Format("Not enough space in memory for update");
        }
        public string StatusMemory() => memory.StatusMemory();


    }
}
