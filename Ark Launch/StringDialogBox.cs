using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ark_Launch
{
    public partial class StringDialogBox : Form
    {
        public StringDialogBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
