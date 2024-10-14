using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackSmart
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveSettings();
            Close();
        }

        public void saveSettings()
        {
            //Save settings that were made

            //Confirm settings has been saved
            MessageBox.Show("Your Settings have been saved.");
        }
    }
}
