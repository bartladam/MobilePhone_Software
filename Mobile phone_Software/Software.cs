﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    internal class Software
    {
        public double versionSoftware { get; set; } = 1.0d;
        public int sizeSoftware { get; set; } = 1000;
        private Memory memory { get; set; }

        public void ShowInterface(Memory memory)
        {
            this.memory = memory;
            char choice;
            ConsoleColor theme = ConsoleColor.Black;
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Hello...\nv.{0}", versionSoftware);
                Console.Write(@"
1 - Telephone
2 - SMS
3 - SETTINGS
4 - GOOGLE PLAY
5 - DOWNLOADED APPS");
                Console.Write("\nSelect: ");
                choice = Console.ReadKey().KeyChar;
                switch(choice)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Telephone:");
                        Telephone telephone = (Telephone)AppsInMemory(1);
                        Console.WriteLine(@"
1 - call
2 - contacts
3 - add contact
4 - remove contact");
                        char telephoneChoice = Console.ReadKey().KeyChar;
                        switch(telephoneChoice)
                        {
                            case '1':
                                Console.Write("Write telephone number: ");
                                telephone.Call(int.Parse(Console.ReadLine()));
                                break;
                            case '2':
                                Console.WriteLine(telephone.ListContacts());              
                                break;
                            case '3':

                                break;
                            case '4':
                                break;


                        }
                        break;
                    
                    case '2':
                        Console.Clear();
                        Console.WriteLine("SMS:");
                        SMS sms = (SMS)AppsInMemory(2);
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Settings:");
                        Settings settings = (Settings)AppsInMemory(3);
                        Console.WriteLine(@"
1 - Change theme (black/white)
2 - StatusMemory
3 - Update software");
                        choice = Console.ReadKey().KeyChar;
                        switch(choice)
                        {
                            case '1':
                                if(theme.Equals(ConsoleColor.Black))
                                    theme = settings.ChangeTheme(ConsoleColor.White, ConsoleColor.Black);
                                else
                                    theme = settings.ChangeTheme(ConsoleColor.Black,ConsoleColor.White);
                                break;

                            case '2':
                                Console.Clear();
                                Console.WriteLine(settings.StatusMemory());
                                Console.WriteLine("\nPress any key to back on main page");
                                Console.ReadKey();
                                break;
                            case '3':
                                Console.Clear();
                                Console.WriteLine(settings.UpdateSoftware(this));
                                Console.WriteLine("\nPress any key to back on main page");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case '4':
                        GooglePlay googlePlay = (GooglePlay)AppsInMemory(4);
                        break;


                }
            }
        }

        public object AppsInMemory(int findObject)
        {
            object founded = null;
            foreach (object item in memory.AppsInMemory())
            {
                if (item is Telephone && findObject.Equals(1))
                    return item;
                if (item is SMS && findObject.Equals(2))
                    return item;
                if (item is Settings && findObject.Equals(3))
                    return item;
                if (item is GooglePlay && findObject.Equals(4))
                    return item;

            }
            return founded;
        }
        public override string ToString()
        {
            return string.Format("v.{0}", versionSoftware);
        }
    }
}
