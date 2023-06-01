using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public interface IMenuListener
    {
        void OnNonLeafMenuAsked(MenuItem i_InnerMenu);
    }

    public interface ILeafMenuListener
    {
        void onLeafMenuAsked(string i_LeafTitle);
    }
}
