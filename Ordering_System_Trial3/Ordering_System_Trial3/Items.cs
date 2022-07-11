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
    public partial class From_Items : Form
    {
        const double price_burger = 30;
        const double price_carbonara = 80;
        const double price_hotdog = 50;
        const double price_mikiguisado = 60;
        const double price_siomai = 33;
        const double price_cola = 15;
        const double price_royal = 15;
        const double price_sprite = 15;
        const double price_hotchocolate = 10;
        const double price_nestea = 25;
        public From_Items()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want t exit the System", "Ordering Sytem", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void From_Items_Load(object sender, EventArgs e)
        {
            cmb_payment.Items.Add(" ");
            cmb_payment.Items.Add(" Cash");
            cmb_payment.Items.Add(" Cash on Delivery");
            cmb_payment.Items.Add("");
            cmb_payment.Items.Add("");

            EnableTextBoxes();

        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = ( controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls); 
            };
            func(Controls);
        }

        private void Chk_Burger_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Burger.Checked == true)
            {
                txt_burger.Enabled = true;
                txt_burger.Text = "1";
                txt_burger.Focus();
            }
            else
            {
                txt_burger.Enabled = false;
                txt_burger.Text = "0";
            }
        }

        private void Chk_Carbonara_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Carbonara.Checked == true)
            {
                txt_carbonara.Enabled = true;
                txt_carbonara.Text = "1";
                txt_carbonara.Focus();
            }
            else
            {
                txt_carbonara.Enabled = false;
                txt_carbonara.Text = "0";
            }
        }

        private void Chk_HotdogSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_HotdogSandwich.Checked == true)
            {
                txt_hotdog.Enabled = true;
                txt_hotdog.Text = "1";
                txt_hotdog.Focus();
            }
            else
            {
                txt_hotdog.Enabled = false;
                txt_hotdog.Text = "0";
            }
        }

        private void Chk_MikiGuisado_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_MikiGuisado.Checked == true)
            {
                txt_mikiguisado.Enabled = true;
                txt_mikiguisado.Text = "1";
                txt_mikiguisado.Focus();
            }
            else
            {
                txt_mikiguisado.Enabled = false;
                txt_mikiguisado.Text = "0";
            }
        }

        private void Chk_Siomai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Siomai.Checked == true)
            {
                txt_siomai.Enabled = true;
                txt_siomai.Text = "1";
                txt_siomai.Focus();
            }
            else
            {
                txt_siomai.Enabled = false;
                txt_siomai.Text = "0";
            }
        }

        private void Chk_Cola_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Cola.Checked == true)
            {
                txt_cola.Enabled = true;
                txt_cola.Text = "1";
                txt_cola.Focus();
            }
            else
            {
                txt_cola.Enabled = false;
                txt_cola.Text = "0";
            }
        }

        private void Chk_Royal_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Royal.Checked == true)
            {
                txt_royal.Enabled = true;
                txt_royal.Text = "1";
                txt_royal.Focus();
            }
            else
            {
                txt_royal.Enabled = false;
                txt_royal .Text = "0";
            }
        }

        private void Chk_Sprite_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Sprite.Checked == true)
            {
                txt_sprite.Enabled = true;
                txt_sprite.Text = "1";
                txt_sprite.Focus();
            }
            else
            {
                txt_sprite.Enabled = false;
                txt_sprite.Text = "0";
            }
        }

        private void Chk_HotChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_HotChocolate.Checked == true)
            {
                txt_hotchocolate.Enabled = true;
                txt_hotchocolate.Text = "1";
                txt_hotchocolate.Focus();
            }
            else
            {
                txt_hotchocolate.Enabled = false;
                txt_hotchocolate.Text = "0";
            }
        }

        private void Chk_Nestea_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Nestea.Checked == true)
            {
                txt_nestea.Enabled = true;
                txt_nestea.Text = "1";
                txt_nestea.Focus();
            }
            else
            {
                txt_nestea.Enabled = false;
                txt_nestea.Text = "0";
            }
        }

        private void cmb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment.Text == "Cash")
            {
                txt_payment.Enabled = true;
                txt_payment.Text = "";
                txt_payment.Focus();
            }
            else if (cmb_payment.Text == "Cash on Delivery")
            {
                Txt_Name.Enabled = true;
                Txt_Address.Enabled = true;
                Txt_Number.Enabled = true;
                Txt_Name.Text = "";
                Txt_Address.Text = "";
                Txt_Number.Text = "";
                Txt_Name.Focus();
                Txt_Address.Focus();
                Txt_Number.Focus();
            }
            else
                txt_payment.Enabled = false;
            txt_payment.Text = "0";

        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[100];
            itemcost[0] = Convert.ToDouble(txt_burger.Text) * price_burger;
            itemcost[2] = Convert.ToDouble(txt_carbonara.Text) * price_carbonara;
            itemcost[3] = Convert.ToDouble(txt_hotdog.Text) * price_hotdog;
            itemcost[4] = Convert.ToDouble(txt_mikiguisado.Text) * price_mikiguisado;
            itemcost[5] = Convert.ToDouble(txt_siomai.Text) * price_siomai;
            itemcost[6] = Convert.ToDouble(txt_cola.Text) * price_cola;
            itemcost[7] = Convert.ToDouble(txt_royal.Text) * price_royal;
            itemcost[8] = Convert.ToDouble(txt_sprite.Text) * price_sprite;
            itemcost[9] = Convert.ToDouble(txt_hotchocolate.Text) * price_hotchocolate;
            itemcost[10] = Convert.ToDouble(txt_nestea.Text) * price_nestea;

            double total, payment, cost;
            if (cmb_payment.Text == "Cash")
            {
                total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];
                
                lbl_result.Text = Convert.ToString(total);
                payment = Convert.ToInt32(txt_payment.Text);
                cost = payment - total;
                lbl_changeresult.Text = Convert.ToString(cost);
            }
            else
            {
                total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];

                lbl_result.Text = Convert.ToString(total);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestTextbox();
        }
        private void RestTextbox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(Controls);

            };
            func(Controls);
        }
        private void RestCheckbox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Text = "0";
                    else
                        func(Controls);

            };
            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for choosing this shit" + Txt_Name + "We will deliver yor shit at" + Txt_Address + " We will inform you at" + Txt_Number);
        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
