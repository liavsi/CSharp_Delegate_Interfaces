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
            ActionSystemThatWorkWithMenu systemMenu = new ActionSystemThatWorkWithMenu();
            systemMenu.MenuItem.MainPorpuse();
        }
    }
}
