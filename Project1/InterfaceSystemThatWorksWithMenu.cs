﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class InterfaceSystemThatWorksWithMenu : ILeafMenuListener
    {
        public MenuItem FirstMenuItem;

        public InterfaceSystemThatWorksWithMenu()
        {
            LeafMenuItem printDateItem = new LeafMenuItem("Show Date");
            printDateItem.SetLeafMenuListener(this);

            LeafMenuItem printTimeItem = new LeafMenuItem("Show Time");
            printTimeItem.SetLeafMenuListener(this);

            LeafMenuItem printVersion = new LeafMenuItem("Version");
            printVersion.SetLeafMenuListener(this);

            LeafMenuItem printSpacesInSentence = new LeafMenuItem("Count Spaces");
            printSpacesInSentence.SetLeafMenuListener(this);

            NonLeafMenuItem showDateTime = new NonLeafMenuItem("Show Date/Time");
            showDateTime.AddSubMenu(printDateItem);
            showDateTime.AddSubMenu(printTimeItem);

            NonLeafMenuItem showVerionSpaces = new NonLeafMenuItem("Version and Spaces");
            showVerionSpaces.AddSubMenu(printVersion);
            showVerionSpaces.AddSubMenu(printSpacesInSentence);


            NonLeafMenuItem DelegatesMenu = new NonLeafMenuItem("Interface Main Menu");
            DelegatesMenu.AddSubMenu(showDateTime);
            DelegatesMenu.AddSubMenu(showVerionSpaces);
            FirstMenuItem = DelegatesMenu;
        }
        public void StartMenu()
        {
            FirstMenuItem.MainPorpuse();
        }

        public static void PrintTodayDate()
        {
            DateTime todayDate = DateTime.Today;
            Console.WriteLine(@"The Date is: {0}", todayDate.ToString("d"));
        }

        public static void PrintTime()
        {
            DateTime timeRightNow = DateTime.Now;
            Console.WriteLine(@"The Hour is: {0}", timeRightNow.ToString("T"));
        }

        public static void PrintVersion()
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }

        public static void PrintSpacesCounted()
        {
            Console.WriteLine("Please Enter Your Sentence:");
            int count = countSpaces(Console.ReadLine());
            Console.WriteLine("There are {0} Spaces in Your Sentence", count);
        }


        private static int countSpaces(string i_Sentence)
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

        public void onLeafMenuAsked(string i_LeafTitle)
        {
            switch (i_LeafTitle)
            {
                case "Version":
                    PrintVersion();
                    break;
                case "Show Time":
                    PrintTime();
                    break ;
                case "Show Date":
                    PrintTodayDate();
                    break;
                case "Count Spaces":
                    PrintSpacesCounted();
                    break;
                default:
                    break;
            }
        }
    }
}
