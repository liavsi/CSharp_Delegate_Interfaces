using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class InterfaceSystemThatWorksWithMenu
    {


        public InterfaceSystemThatWorksWithMenu()
        {

            // create leaf menus that interact with the needed functions
            // create menus that interact with the bottom menus and know how to print
            // thats it.
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
