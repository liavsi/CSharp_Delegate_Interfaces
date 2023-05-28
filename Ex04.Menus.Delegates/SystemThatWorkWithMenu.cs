using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SystemThatWorkWithMenu
    {
        //public event Action ChoseMethod;
        public MenuItem MenuItem;

        public SystemThatWorkWithMenu()
        {
            LeafMenuItem printDateItem = new LeafMenuItem("Show Date");
            printDateItem.ChoseLeaf += PrintTodayDate;

            LeafMenuItem printTimeItem = new LeafMenuItem("Show Time");
            printTimeItem.ChoseLeaf += PrintTime;

            NonLeafMenuItem showDateTime = new NonLeafMenuItem("Show Date/Time");
            showDateTime.AddSubMenu(printDateItem);
            showDateTime.AddSubMenu(printTimeItem);

            NonLeafMenuItem showVerionCapitals = new NonLeafMenuItem("Version and Capitals");
            showVerionCapitals.AddSubMenu(printDateItem);
            showVerionCapitals.AddSubMenu(printTimeItem);

            NonLeafMenuItem DelegatesMenu = new NonLeafMenuItem("Delegates Main Menu");
            DelegatesMenu.AddSubMenu(showDateTime);
            DelegatesMenu.AddSubMenu(showVerionCapitals);
            MenuItem =DelegatesMenu;
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


    }
}
