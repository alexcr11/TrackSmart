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
    public partial class ExpenseViewer : Form
    {
        public ExpenseViewer()
        {
            InitializeComponent();
        }

        private void closeButon_Click(object sender, EventArgs e)
        {
            // Check if the owner is the main form and refresh data
            if (Owner is TrackSmart mainForm)
            {
                mainForm.RefreshData();
            }
            Close();
        }
    }
}
