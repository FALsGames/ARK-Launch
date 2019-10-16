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
    public partial class Ark_Launch : Form
    {
        ProfileEditor editor;
        System.Windows.Forms.ListBox.ObjectCollection profiles;
        public Ark_Launch()
        {
            InitializeComponent();
            profiles = dummyBox.Items;
            int tmp = 0;
            profiles.AddRange(API.LoadProfile( ref tmp));
            foreach (string item in profiles)
            {
                profileSelector.Items.Add(item);
            }
            profileSelector.SelectedIndex = tmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (profileSelector.SelectedIndex < 0)
            {
                MessageBox.Show("Please, select a profile");
                return;
            }
            API.LoadARKProfile((string)profileSelector.Items[profileSelector.SelectedIndex]);
            API.LaunchARK();          
            this.Visible = false;
            ProgramRunning();
            
        }
        bool update = true, close = true, l1, l2;
        void ProgramRunning()
        {
            update = true;
            close = true;
            l1 = false;
            l2 = false;
            while (update)
            {
                l1 = API.ProgrammIsRunning();
                if (l1)
                {
                    update = false;
                }
            }
            while (close)
            {
                l2 = !API.ProgrammIsRunning();
                if (l2)
                {
                    close = false;
                }
            }
            API.BackupSaveGame((string)profileSelector.Items[profileSelector.SelectedIndex]);
            this.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void editProfiles_Click(object sender, EventArgs e)
        {
            editor = new ProfileEditor();
            if (this.profiles != null)
            editor.profiles.Items.AddRange(this.profiles);
            editor.ShowDialog();
            this.profiles = editor.profiles.Items;
            profileSelector.Items.Clear();
            List<string> l = new List<string>();
            foreach (string item in profiles)
            {
                profileSelector.Items.Add(item);
                l.Add(item);
            }
            API.SaveData(l.ToArray(), 0);
        }

        private void Ark_Launch_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> ls = new List<string>();
            foreach (string item in profiles)
            {
                ls.Add(item);
            }
               
            API.SaveData(ls.ToArray(), profileSelector.SelectedIndex);
        }
    }
}
