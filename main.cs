using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NoName
{
    public partial class Form1 : Form
    {
        private void Main()
        {
            Thread.Sleep(NM(1));
            //it will be Sleep 1 second bcuz im coded it
        }
        static int NM(int millisecond)
        {
            //int NoMilliSecondValuqee = 0;
            int NoMilliSecondValue = millisecond * 1000;
            //string str = "" + NoMilliSecondValue.ToString;

            return NoMilliSecondValue;
        }
    }
}
