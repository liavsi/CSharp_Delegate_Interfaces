using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    internal class LeafMenuItem : MenuItem
    {
        private ILeafMenuListener m_LeafListener;

        public LeafMenuItem(string i_Title) : base(i_Title)
        {

        }

        public void SetLeafMenuListener(ILeafMenuListener i_MyListener)
        {
            m_LeafListener = i_MyListener;
        }

        public override void MainPorpuse()
        {
            if(m_LeafListener != null)
            {
                m_LeafListener.onLeafMenuAsked(Title);
            }
        }

    }
}
