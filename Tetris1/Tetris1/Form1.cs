using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Tetris1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDemarrer_Click(object sender, EventArgs e)
        {
            for(int i=0; i<100; i=i+1)
            {
                Brique.Top = Brique.Top + 1;
                Application.DoEvents();
                Thread.Sleep(12);
            }
        }
    }
}
