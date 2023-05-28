using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {

        protected string m_Title;

        public event Action<MenuItem> Chose;

        public MenuItem(string i_Title)
        {
            Title = i_Title;
        }
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public abstract void MainPorpuse();


        public void OnChose()
        {
            if (Chose != null)
            {
                Chose.Invoke(this);
            }
        }



        public void MenuItem_Chose(MenuItem i_Invoker)
        {
            i_Invoker.MainPorpuse();
        }


    }
}
