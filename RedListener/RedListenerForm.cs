using System;
using System.Windows.Forms;

namespace RedListener
{
    public partial class RedListenerForm : Form
    {
        public RedListenerForm()
        {
            InitializeComponent();
        }

        private void ClearBtnClick(object sender, EventArgs e)
        {
            numberEventsTB.Text = @"0";
        }
    }
}
