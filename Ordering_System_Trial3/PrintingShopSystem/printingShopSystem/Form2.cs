using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace printingShopSystem
{
    public partial class form_productsPage : Form
    {
        public form_productsPage()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form homepage = new form_homePage();
            homepage.Show();
            this.Hide();
        }
    }
}
