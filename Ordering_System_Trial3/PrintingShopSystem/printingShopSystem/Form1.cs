using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printingShopSystem
{
    public partial class form_homePage : Form
    {
        public form_homePage()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 3)
            {
                pictureBox2.Image = imageList1.Images[count];

                pictureBox3.Image = imageList1.Images[count];
                pictureBox4.Image = imageList1.Images[count];
                pictureBox5.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }

      
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            Form products = new form_productsPage();
            products.Show();
            this.Hide();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
