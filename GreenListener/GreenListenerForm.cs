using System;
using System.Windows.Forms;

namespace GreenListener
{
    public partial class GreenListenerForm : Form
    {
        public GreenListenerForm()
        {
            InitializeComponent();
        }

        private void ClearBtnClick(object sender, EventArgs e)
        {
            numberEventsTB.Text = @"0";
        }
    }
}
