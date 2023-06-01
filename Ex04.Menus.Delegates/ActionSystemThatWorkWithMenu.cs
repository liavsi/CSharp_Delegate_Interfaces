using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class ActionSystemThatWorkWithMenu
    {
        //public event Action ChoseMethod;
        public MenuItem FirstMenuItem;

        public ActionSystemThatWorkWithMenu()
        {
            LeafMenuItem printDateItem = new LeafMenuItem("Show Date");
            printDateItem.ChoseLeaf += PrintTodayDate;

            LeafMenuItem printTimeItem = new LeafMenuItem("Show Time");
            printTimeItem.ChoseLeaf += PrintTime;

            LeafMenuItem printVersion = new LeafMenuItem("Version");
            printVersion.ChoseLeaf += PrintVersion;
            
            LeafMenuItem printSpacesInSentence = new LeafMenuItem("Count Spaces");
            printSpacesInSentence.ChoseLeaf += PrintSpacesCounted;
            
            NonLeafMenuItem showDateTime = new NonLeafMenuItem("Show Date/Time");
            showDateTime.AddSubMenu(printDateItem);
            showDateTime.AddSubMenu(printTimeItem);

            NonLeafMenuItem showVerionSpaces = new NonLeafMenuItem("Version and Spaces");
            showVerionSpaces.AddSubMenu(printVersion);
            showVerionSpaces.AddSubMenu(printSpacesInSentence);

            NonLeafMenuItem DelegatesMenu = new NonLeafMenuItem("Delegates Main Menu");
            DelegatesMenu.AddSubMenu(showDateTime);
            DelegatesMenu.AddSubMenu(showVerionSpaces);
            FirstMenuItem = DelegatesMenu;
        }

        public void StartMenu()
        {
            FirstMenuItem.MainPorpuse();
        }

        public void PrintTodayDate()
        {
            DateTime todayDate = DateTime.Today;
            Console.WriteLine("The Date is: {0}", todayDate.ToString());
        }

        public void PrintTime()
        {
            DateTime timeRightNow = DateTime.Now;
            Console.WriteLine("The Hour is: {0}", timeRightNow.ToString());
        }

        public void PrintVersion()
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }

        public void PrintSpacesCounted()
        {
            Console.WriteLine("Please Enter Your Sentence:");
            int count = countSpaces(Console.ReadLine());
            Console.WriteLine("There are {0} Spaces in Your Sentence", count);
        }

        private int countSpaces(string i_Sentence)
        {
            int count = 0;
            foreach (char c in i_Sentence)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            
            return count;
        }


    }
}
