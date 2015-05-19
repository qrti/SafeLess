// rich text box that can't be edited and keeps the background color of loaded text
// editable = false changes the background color

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SafeLess
{
    public class MyRichTextBox : RichTextBox
    {
        protected override void WndProc(ref Message m)
        {
            const int WM_SETFOCUS = 0x0007;

            if (m.Msg == WM_SETFOCUS)
                m.Result = IntPtr.Zero;
            else
                base.WndProc(ref m);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            base.OnKeyUp(e);
        }
    }
}
