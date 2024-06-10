using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Management_System
{
    public partial class Form_Items : Form
    {
        const double priceVege = 1000;
        const double priceEgg = 1200;
        const double priceChick = 1400;
        const double priceFish = 1400;
        const double pricePork = 1600;
        const double priceBeef = 1600;
        const double priceMix = 1800;
        const double priceSeafood = 1800;
        const double priceCoke = 350;
        const double priceSprite = 350;
        const double priceEGB = 350;
        const double pricePepsi = 400;
        const double priceSevenUp = 400;
        const double priceIce = 250;
        const double priceWatalappan = 350;
        const double pricePudin = 300;
        const double priceYoghurt = 100;
        const double priceJelly = 250;


        public Form_Items()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm that You want to EXIT the system",
                "Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form_Items_Load(object sender, EventArgs e)
        {
            cmb_payment.Items.Add(" ");
            cmb_payment.Items.Add("CASH");
            cmb_payment.Items.Add("CASH ON DELIVERY");
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else func(control.Controls);
            };
            func(Controls);
        }

        private void VegeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VegeCheckBox.Checked == true)
            {
                text_Vege.Enabled = true;
                text_Vege.Text = "1";
                text_Vege.Focus();
            }
            else
            {
                text_Vege.Enabled = false;
                text_Vege.Text = "1";
            }
        }

        private void EggCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EggCheckBox.Checked == true)
            {
                text_Egg.Enabled = true;
                text_Egg.Text = "";
                text_Egg.Focus();
            }
            else
            {
                text_Egg.Enabled = false;
                text_Egg.Text = "0";
            }
        }

        private void ChickenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCheckBox.Checked == true)
            {
                text_Chi.Enabled = true;
                text_Chi.Text = "";
                text_Chi.Focus();
            }
            else
            {
                text_Chi.Enabled = false;
                text_Chi.Text = "0";
            }
        }

        private void FishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FishCheckBox.Checked == true)
            {
                text_Fish.Enabled = true;
                text_Fish.Text = "";
                text_Fish.Focus();
            }
            else
            {
                text_Fish.Enabled = false;
                text_Fish.Text = "0";
            }
        }

        private void PorkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PorkCheckBox.Checked == true)
            {
                text_Pork.Enabled = true;
                text_Pork.Text = "";
                text_Pork.Focus();
            }
            else
            {
                text_Pork.Enabled = false;
                text_Pork.Text = "0";
            }
        }

        private void BeefCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BeefCheckBox.Checked == true)
            {
                text_Beef.Enabled = true;
                text_Beef.Text = "";
                text_Beef.Focus();
            }
            else
            {
                text_Beef.Enabled = false;
                text_Beef.Text = "0";
            }
        }

        private void MixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MixCheckBox.Checked == true)
            {
                text_Mix.Enabled = true;
                text_Mix.Text = "";
                text_Mix.Focus();
            }
            else
            {
                text_Mix.Enabled = false;
                text_Mix.Text = "0";
            }
        }

        private void SeafoodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MixCheckBox.Checked == true)
            {
                text_Seafood.Enabled = true;
                text_Seafood.Text = "";
                text_Seafood.Focus();
            }
            else
            {
                text_Seafood.Enabled = false;
                text_Seafood.Text = "0";
            }
        }

        private void CokeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CokeCheckBox.Checked == true)
            {
                text_coke.Enabled = true;
                text_coke.Text = "";
                text_coke.Focus();
            }
            else
            {
                text_coke.Enabled = false;
                text_coke.Text = "0";
            }
        }

        private void SpriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SpriteCheckBox.Checked == true)
            {
                text_Sprite.Enabled = true;
                text_Sprite.Text = "";
                text_Sprite.Focus();
            }
            else
            {
                text_Sprite.Enabled = false;
                text_Sprite.Text = "0";
            }
        }

        private void EGBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EGBCheckBox.Checked == true)
            {
                text_EGB.Enabled = true;
                text_EGB.Text = "";
                text_EGB.Focus();
            }
            else
            {
                text_EGB.Enabled = false;
                text_EGB.Text = "0";
            }
        }

        private void PepsiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EGBCheckBox.Checked == true)
            {
                text_pepsi.Enabled = true;
                text_pepsi.Text = "";
                text_pepsi.Focus();
            }
            else
            {
                text_pepsi.Enabled = false;
                text_pepsi.Text = "0";
            }
        }

        private void sevenUpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sevenUpCheckBox.Checked == true)
            {
                text_sevenUp.Enabled = true;
                text_sevenUp.Text = "";
                text_sevenUp.Focus();
            }
            else
            {
                text_sevenUp.Enabled = false;
                text_sevenUp.Text = "0";
            }
        }

        private void IceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sevenUpCheckBox.Checked == true)
            {
                text_Ice.Enabled = true;
                text_Ice.Text = "";
                text_Ice.Focus();
            }
            else
            {
                text_Ice.Enabled = false;
                text_Ice.Text = "0";
            }
        }

        private void WatalappanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WatalappanCheckBox.Checked == true)
            {
                text_Watalappan.Enabled = true;
                text_Watalappan.Text = "";
                text_Watalappan.Focus();
            }
            else
            {
                text_Watalappan.Enabled = false;
                text_Watalappan.Text = "0";
            }
        }

        private void PudinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PudinCheckBox.Checked == true)
            {
                text_Pudin.Enabled = true;
                text_Pudin.Text = "";
                text_Pudin.Focus();
            }
            else
            {
                text_Pudin.Enabled = false;
                text_Pudin.Text = "0";
            }
        }

        private void YoghurtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (YoghurtCheckBox.Checked == true)
            {
                text_Yoghurt.Enabled = true;
                text_Yoghurt.Text = "";
                text_Yoghurt.Focus();
            }
            else
            {
                text_Yoghurt.Enabled = false;
                text_Yoghurt.Text = "0";
            }
        }

        private void JellyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (JellyCheckBox.Checked == true)
            {
                text_Jelly.Enabled = true;
                text_Jelly.Text = "";
                text_Jelly.Focus();
            }
            else
            {
                text_Jelly.Enabled = false;
                text_Jelly.Text = "0";
            }
        }

        private void cmb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment.Text == "CASH")
            {
                text_payment.Enabled = true;
                text_payment.Text = " ";
                text_payment.Focus();
            }
            else if (cmb_payment.Text == "CASH ON DELIVERY")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;

                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";

                textBox1.Focus();
                textBox2.Focus();
                textBox3.Focus();
            }
            else
            {
                text_payment.Enabled = false;
                text_payment.Text = "0";

            }
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            double[] itemCost = new double[100];
            itemCost[0] = Convert.ToDouble(text_Vege.Text) * priceVege;
            itemCost[1] = Convert.ToDouble(text_Egg.Text) * priceEgg;
            itemCost[2] = Convert.ToDouble(text_Chi.Text) * priceChick;
            itemCost[3] = Convert.ToDouble(text_Fish.Text) * priceFish;
            itemCost[4] = Convert.ToDouble(text_Pork.Text) * pricePork;
            itemCost[5] = Convert.ToDouble(text_Beef.Text) * priceBeef;
            itemCost[6] = Convert.ToDouble(text_Mix.Text) * priceMix;
            itemCost[7] = Convert.ToDouble(text_Seafood.Text) * priceSeafood;
            itemCost[8] = Convert.ToDouble(text_coke.Text) * priceCoke;
            itemCost[9] = Convert.ToDouble(text_Sprite.Text) * priceSprite;
            itemCost[10] = Convert.ToDouble(text_EGB.Text) * priceEGB;
            itemCost[11] = Convert.ToDouble(text_pepsi.Text) * pricePepsi;
            itemCost[12] = Convert.ToDouble(text_sevenUp.Text) * priceSevenUp;
            itemCost[13] = Convert.ToDouble(text_Ice.Text) * priceIce;
            itemCost[14] = Convert.ToDouble(text_Watalappan.Text) * priceWatalappan;
            itemCost[15] = Convert.ToDouble(text_Pudin.Text) * pricePudin;
            itemCost[16] = Convert.ToDouble(text_Yoghurt.Text) * priceYoghurt;
            itemCost[17] = Convert.ToDouble(text_Jelly.Text) * priceJelly;

            double total, payment, cost;
            if (cmb_payment.Text == "CASH")
            {
                total = itemCost[0] + itemCost[1] + itemCost[2] + itemCost[3] + itemCost[4] + itemCost[5]
                    + itemCost[6] + itemCost[7] + itemCost[8] + itemCost[9] + itemCost[10] + itemCost[11]
                    + itemCost[12] + itemCost[13] + itemCost[14] + itemCost[15] + itemCost[16] + itemCost[17];

                label_result1.Text = Convert.ToString(total);

                payment = Convert.ToInt32(text_payment.Text);

                cost = payment - total;

                label_result2.Text = Convert.ToString(cost);
            }
            else
            {
                total = itemCost[0] + itemCost[1] + itemCost[2] + itemCost[3] + itemCost[4] + itemCost[5]
                    + itemCost[6] + itemCost[7] + itemCost[8] + itemCost[9] + itemCost[10] + itemCost[11]
                    + itemCost[12] + itemCost[13] + itemCost[14] + itemCost[15] + itemCost[16] + itemCost[17];

                label_result1.Text = Convert.ToString(total);
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            ResetCheckBox();
        }

        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (Control) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Text = " ";
                    else func(Controls);

            };
            func(Controls);
        }
        private void ResetCheckBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (Control) =>
            {
                foreach (Control control in Controls)
                    if (control is CheckBox)
                        (control as CheckBox).Text = " ";
                    else func(Controls);

            };
            func(Controls);
        }

        private void btn_Okay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Choosing Our Restaurant" + textBox1 + " We Will Delivery Your Order At " + textBox2 + "Have A Nice Day");
        }
    }
}

