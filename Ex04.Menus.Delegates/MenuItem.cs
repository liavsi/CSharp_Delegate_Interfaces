using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {

        private string m_Title; 

        private bool m_IsLeaf = false;

        private List<MenuItem> m_SubMenu;

        public event Action<MenuItem> Chose;

        public void MainPorpuse()
        {
            ShowMenu();
            //todo int choise = AskForInput();
            int choise = 1;
            if (choise != 0)
            {
                m_SubMenu[choise].OnChose();
            }
        }

        private void OnChose()
        {
            if(Chose != null)
            {
                Chose.Invoke(this);
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("**{0}**", Title);
            Console.WriteLine("-------------");
            int count = 1;
            foreach(MenuItem item in m_SubMenu)
            {
                Console.WriteLine("{0} -> {1}", count, item.Title);
                count++;
            }
        }

        public void MenuItem_Chose(MenuItem i_Invoker)
        {
            i_Invoker.MainPorpuse();
        }

        public string Title
        {
            get { return m_Title; } set { m_Title = value; } 
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
            i_MenuItem.Chose += new Action<MenuItem> (MenuItem_Chose);
        }
    }
}
