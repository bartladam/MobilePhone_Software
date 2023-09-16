using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Settings
    {
        public string Name { get; private set; } = "Settings";
        private Memory memory { get; set; }
        public int sizeSettings { get; set; } = 150;
        public Settings(Memory memory)
        {
            this.memory = memory;
        }
        public void ChangeVisualizatiion(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
        public string StatusMemory() => memory.StatusMemory();


    }
}
