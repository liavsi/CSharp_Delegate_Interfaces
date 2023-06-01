
using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    internal class NonLeafMenuItem : MenuItem
    {
        protected List<MenuItem> m_SubMenu;

        public NonLeafMenuItem(string i_Title) : base(i_Title)
        {

        }

        public override void MainPorpuse()
        {
            bool quit = false;
            while (!quit)
            {
                showMenu();
                //todo int choise = AskForInput();
                int choise = int.Parse(Console.ReadLine());
                if (choise != 0)
                {
                    m_SubMenu[choise - 1].OnNonLeafMenuAsked(m_SubMenu[choise - 1]);
                }
                else
                {
                    quit = true;
                }
            }
        }

        private void showMenu()
        {
            Console.WriteLine("**{0}**", Title);
            Console.WriteLine("-------------");
            int count = 1;
            foreach (MenuItem item in m_SubMenu)
            {
                Console.WriteLine("{0} -> {1}", count, item.Title);
                count++;
            }
        }

        public void AddSubMenu(MenuItem i_MenuItem)
        {
            if (m_SubMenu != null)
            {
                m_SubMenu.Add(i_MenuItem);
            }
            else
            {
                m_SubMenu = new List<MenuItem>();
                m_SubMenu.Add(i_MenuItem);
            }
            i_MenuItem.SetMenuListener(this);
        }


    }
}