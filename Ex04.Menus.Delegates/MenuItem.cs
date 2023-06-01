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

        public static int askForInput(int i_MaxVal)
        {
            bool validInput = false;
            Console.WriteLine("-------------");
            Console.WriteLine(@"Please Enter your input (1 to {0} or press '0' to Back).", i_MaxVal);
            int resValue = 0;
            while (!validInput)
            {
                if (int.TryParse(Console.ReadLine(), out resValue))
                {
                    validInput = true;
                    if (resValue < 0 || resValue > i_MaxVal)
                    {
                        validInput = false;
                    }
                }
                if (!validInput)
                {
                    Console.WriteLine("Invalid input.. Try Again");
                }
            }

            return resValue;
        }

        public void MenuItem_Chose(MenuItem i_Invoker)
        {
            i_Invoker.MainPorpuse();
        }


    }
}
