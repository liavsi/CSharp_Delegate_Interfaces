using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    internal class NonLeafMenuItem : MenuItem
    {

        protected List<MenuItem> m_SubMenu;

        public NonLeafMenuItem(string i_Title) :base(i_Title)
        {

        }

        public override void MainPorpuse()
        {
            bool quit = false;
            while (!quit)
            {
                showMenu();
                int choise = askForInput(m_SubMenu.Count);
                if (choise != 0)
                {
                    m_SubMenu[choise - 1].OnChose();
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
            i_MenuItem.Chose += MenuItem_Chose;
        }
    }
}
