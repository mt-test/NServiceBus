using System;
using System.Windows.Forms;

namespace RGBListener
{
    public partial class RGBListenerForm : Form
    {
        public RGBListenerForm()
        {
            InitializeComponent();
        }

        private void ClearBtnClick(object sender, EventArgs e)
        {
            numberRedsTB.Text = @"0";
            numberGreensTB.Text = @"0";
            numberBluesTB.Text = @"0";
        }
    }
}
