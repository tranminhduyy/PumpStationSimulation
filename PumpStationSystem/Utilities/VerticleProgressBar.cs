using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

public class VerticalProgressBar : ProgressBar
{
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.Style |= 0x04;
            return cp;
        }
    }
}
