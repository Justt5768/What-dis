using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering_System_Trial3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Form  item = new From_Items();
            item.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want t exit the System", "Ordering Sytem", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if ( iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
