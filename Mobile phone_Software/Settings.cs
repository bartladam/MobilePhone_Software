using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    /// <summary>
    /// We can change some function mobile phone via settings
    /// </summary>
    internal class Settings
    {
        /// <summary>
        /// Settings have to access to memory, because settings could change memory status
        /// </summary>
        private Memory memory { get; set; }
        public Settings(Memory memory)
        {
            this.memory = memory;
        }
        /// <summary>
        /// User can change theme his mobile phone for better user experience.
        /// </summary>
        /// <param name="colorBackground"></param>
        /// <param name="colorForeground"></param>
        /// <returns></returns>
        public ConsoleColor ChangeTheme(ConsoleColor colorBackground, ConsoleColor colorForeground)
        {
            Console.BackgroundColor = colorBackground;
            Console.ForegroundColor = colorForeground;
            return colorBackground;
        }
        /// <summary>
        /// In settings we can udpate software on higher level. 
        /// </summary>
        /// <param name="software"></param>
        /// <returns></returns>
        public string UpdateSoftware(Software software) 
        {
            if(software.versionSoftware < 2.0d && software.sizeSoftware + 200d < memory.maximumSizeMemory)
            {
                software.versionSoftware += 0.1d;
                software.sizeSoftware += 200;
                memory.memoryStatus += 200;
                return string.Format("Updated on version: {0}",Math.Round(software.versionSoftware,1));
            }
            return string.Format("Not enough space in memory for update");
        }
        /// <summary>
        /// Settings are showing current fullness memory
        /// </summary>
        /// <returns></returns>
        public string StatusMemory() => memory.StatusMemory();


    }
}
