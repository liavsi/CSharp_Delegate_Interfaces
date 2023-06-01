using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem : IMenuListener
    {
        private IMenuListener m_UpperMenu = null;

        protected string m_Title;

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public IMenuListener UpperMenu
        { 
            get { return m_UpperMenu; }
            set { m_UpperMenu = value; }
        }

        public MenuItem(string i_Title)
        {
            Title = i_Title;
        }

        public abstract void MainPorpuse();

        public void OnNonLeafMenuAsked(MenuItem i_InnerMenu)
        {
            i_InnerMenu.MainPorpuse();
        }

        public void SetMenuListener(MenuItem i_Menu)
        {
            this.UpperMenu = i_Menu;
        }
    }
}
