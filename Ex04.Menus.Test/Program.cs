using System;
using Ex04.Menus.Delegates;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class Program
    {

        public static void Main()
        {
            ActionSystemThatWorkWithMenu systemMenuDelegate = new ActionSystemThatWorkWithMenu();
            systemMenuDelegate.StartMenu();
            Console.WriteLine("\n");
            InterfaceSystemThatWorksWithMenu systemMenuInterface = new InterfaceSystemThatWorksWithMenu();
            systemMenuInterface.StartMenu();
        }
    }
}
