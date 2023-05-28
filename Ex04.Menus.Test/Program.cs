using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class Program
    {

        public static void Main()
        {
           SystemThatWorkWithMenu systemMenu = new SystemThatWorkWithMenu();
            systemMenu.MenuItem.MainPorpuse();
        }
    }
}
