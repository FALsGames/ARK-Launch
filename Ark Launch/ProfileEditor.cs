using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ark_Launch_API;

namespace Ark_Launch
{
    public partial class ProfileEditor : Form
    {
        public ProfileEditor()
        {
            InitializeComponent();
        }

        private void AddProfile_Click(object sender, EventArgs e)
        {
            StringDialogBox testDialog = new StringDialogBox();
            string name;
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                name = testDialog.nameInput.Text;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("You need to input a name");
                    return;
                }
                if (profiles.Items.Contains(name))
                {
                    MessageBox.Show("Profile already exist");
                }
                profiles.Items.Add(name);
            }
            else
            {
                name = "Cancelled";
            }
            testDialog.Dispose();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (profiles.Items.Count == 0 || profiles.Items.Count == 1)
                return;
            if (((string)profiles.Items[profiles.SelectedIndex]) == "default")
            {
                MessageBox.Show("You can't delate the default profile");
                return;
            }
            if(MessageBox.Show("Do you really wont to deleat this profile", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                API.DeleteProfile((string)profiles.Items[profiles.SelectedIndex]);
                profiles.Items.RemoveAt(profiles.SelectedIndex);
            }
        }
    }
}
