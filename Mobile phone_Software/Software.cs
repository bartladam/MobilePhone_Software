using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone_Software
{
    /// <summary>
    /// Via software we work with device
    /// </summary>
    internal class Software
    {
        /// <summary>
        /// We can update software. Current version we save here
        /// </summary>
        public double versionSoftware { get; set; } = 1.0d;
        /// <summary>
        /// Each software is saved in memory and take some size memory
        /// </summary>
        public int sizeSoftware { get; set; } = 1000;
        /// <summary>
        /// Software must have access to memory.
        /// </summary>
        private Memory memory { get; set; }
        /// <summary>
        /// Interface for user who is owned mobile phone
        /// </summary>
        /// <param name="memory"></param>
        public void ShowInterface(Memory memory)
        {
            this.memory = memory;
            char choice;
            ConsoleColor theme = ConsoleColor.Black;
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Hello...\nv.{0}", Math.Round(versionSoftware, 1));
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
1 - Call
2 - Contacts
3 - Add contact
4 - Remove contact");
                        Console.Write("Your choice: ");
                        char telephoneChoice = Console.ReadKey().KeyChar;
                        string nameContact;
                        switch (telephoneChoice)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("Your contacts:\n");
                                Console.WriteLine(telephone.ListContacts());
                                Console.Write("Call to [name]: ");
                                Console.WriteLine(telephone.Communication(Console.ReadLine(),false, null)); 
                                break;
                            case '2':
                                Console.Clear();
                                Console.WriteLine(telephone.ListContacts());
                                break;
                            case '3':
                                Console.Clear();
                                Console.WriteLine("Write name contact: ");
                                nameContact = Console.ReadLine();
                                Console.WriteLine("Write number your new contact");
                                int number = int.Parse(Console.ReadLine());
                                Console.WriteLine(telephone.AddContact(nameContact, number)); 
                                break;
                            case '4':
                                Console.Clear();
                                Console.WriteLine(telephone.ListContacts());
                                Console.WriteLine("Name contact what do you want remove: ");
                                nameContact = Console.ReadLine();
                                Console.WriteLine(telephone.RemoveContact(nameContact));
                                break;


                        }
                        Console.WriteLine("\nPress any key to back on main page");
                        Console.ReadKey();
                        break;
                    
                    case '2':
                        Console.Clear();
                        Console.WriteLine("SMS:");
                        SMS sms = (SMS)AppsInMemory(2);
                        Console.WriteLine(@"
1 - Send sms
2 - Contacts
3 - Add contact
4 - Remove contact");
                        sms.ImportContact();
                        Console.Write("Your choice: ");
                        choice = Console.ReadKey().KeyChar;
                        switch (choice)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("Your contacts:\n");
                                Console.WriteLine(sms.ListContacts());
                                Console.Write("Send SMS to [name]: ");
                                nameContact = Console.ReadLine();
                                Console.Write("Text to send: ");
                                Console.WriteLine(sms.Communication(nameContact,true,Console.ReadLine()));
                                break;
                            case '2':
                                Console.Clear();
                                Console.WriteLine(sms.ListContacts());
                                break;
                            case '3':
                                Console.Clear();
                                Console.WriteLine("Write name contact: ");
                                nameContact = Console.ReadLine();
                                Console.WriteLine("Write number your new contact");
                                int number = int.Parse(Console.ReadLine());
                                Console.WriteLine(sms.AddContact(nameContact, number));
                                break;
                            case '4':
                                Console.Clear();
                                Console.WriteLine(sms.ListContacts());
                                Console.WriteLine("Name contact what do you want remove: ");
                                nameContact = Console.ReadLine();
                                Console.WriteLine(sms.RemoveContact(nameContact));
                                break;

                        }
                        Console.WriteLine("\nPress any key to back on main page");
                        Console.ReadKey();
                        break;

                    case '3':
                        Console.Clear();
                        Console.WriteLine("Settings:");
                        Settings settings = (Settings)AppsInMemory(3);
                        Console.WriteLine(@"
1 - Change theme (black/white)
2 - StatusMemory
3 - Update software");
                        Console.Write("Your choice: ");
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
                        Console.Clear();
                        string selectedApp;
                        Console.WriteLine("Google play:\n");
                        GooglePlay googlePlay = (GooglePlay)AppsInMemory(4);
                        Console.WriteLine(googlePlay.ShowAppsInStore());
                        Console.WriteLine(@"
1 - Download app
2 - Remove app");
                        Console.Write("Your choice: ");
                        choice = Console.ReadKey().KeyChar;
                        switch (choice)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine(googlePlay.ShowAppsInStore());
                                Console.WriteLine("Which app: ");
                                selectedApp = Console.ReadLine();
                                foreach (Application item in googlePlay.apps)
                                {
                                    if (item.nameApp.Equals(selectedApp))
                                    {
                                        Console.WriteLine(googlePlay.DownloadApp(item)); 
                                    }
                                }
                                break;
                            case '2':
                                Console.Clear();
                                Console.WriteLine(googlePlay.ShowAppsInStore());
                                Console.WriteLine("Which app: ");
                                selectedApp = Console.ReadLine();
                                foreach (object item in memory.AppsInMemory())
                                {
                                    if(item is Application && ((Application)item).nameApp.Equals(selectedApp))
                                    {
                                        Console.WriteLine(googlePlay.UninstallApp(((Application)item))); 

                                        break;
                                    }
                                }
                                break;
                      
                        }
                        Console.WriteLine("\nPress any key to back on main page");
                        Console.ReadKey();
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("Downloaded apps");
                        int count = 0;
                        foreach (object item in memory.AppsInMemory())
                        {
                            if (item is Application)
                            {
                                count++;
                                Console.WriteLine("{0}. {1}",count,((Application)item).nameApp);
                            }
                        }
                     
                        Console.WriteLine("\nPress any key to back on main page");
                        Console.ReadKey();
                        break;


                }
            }
        }
        /// <summary>
        /// It find required application in memory. Needed for start required application
        /// </summary>
        /// <param name="findObject"></param>
        /// <returns></returns>
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
