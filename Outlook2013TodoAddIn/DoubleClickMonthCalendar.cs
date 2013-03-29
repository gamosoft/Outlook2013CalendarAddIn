using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Outlook2013TodoAddIn
{
    public class DoubleClickMonthCalendar : MonthCalendar
    {
        public event EventHandler DoubleClickEx;

        public DoubleClickMonthCalendar()
        {
            lastClickTick = Environment.TickCount - SystemInformation.DoubleClickTime;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            int tick = Environment.TickCount;
            if (tick - lastClickTick <= SystemInformation.DoubleClickTime)
            {
                EventHandler handler = DoubleClickEx;
                if (handler != null) handler(this, EventArgs.Empty);
            }
            else
            {
                base.OnMouseDown(e);
                lastClickTick = tick;
            }
        }

        private int lastClickTick;
    }
}