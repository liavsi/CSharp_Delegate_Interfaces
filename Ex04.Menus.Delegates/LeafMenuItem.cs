using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    internal class LeafMenuItem : MenuItem
    {
        public event Action ChoseLeaf;

        public LeafMenuItem(string i_Title)
            :base(i_Title)
        {

        }

        public override void MainPorpuse()
        {
            if (ChoseLeaf != null)
            {
                ChoseLeaf.Invoke();
            }
        }

    }
}
