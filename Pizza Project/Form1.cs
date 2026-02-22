using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        float getSizePrice()
        {

            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            else
            {
                return Convert.ToSingle(rbLarg.Tag);
            }
        }
        float getToppingsPrice()
        {
            float priceToppings = 0;
            if (chkExtraChees.Checked)
            {
                priceToppings += Convert.ToSingle(chkExtraChees.Tag);
            }
            if (chkMushrooms.Checked)
            {
                priceToppings += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkTomatos.Checked)
            {
                priceToppings += Convert.ToSingle(chkTomatos.Tag);
            }
            if (chkOnion.Checked)
            {
                priceToppings += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkOlives.Checked)
            {
                priceToppings += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkGreenPeppers.Checked)
            {
                priceToppings += Convert.ToSingle(chkGreenPeppers.Tag);
            }
            return priceToppings;
        }
        float getCrustTypePrice()
        {
            if (rbThinkCrust.Checked)
            {
                return Convert.ToSingle(rbThinkCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
        }
        float getPriceFromSizeAndToppingsAndCrustType()
        {
            return getSizePrice() + getToppingsPrice() + getCrustTypePrice();
        }
        void PriceTotal()
        {
            lblPrice.Text = "$" + getPriceFromSizeAndToppingsAndCrustType();
        }

        void updateSize()
        {
            PriceTotal();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }
            if (rbLarg.Checked)
            {
                lblSize.Text = "Larg";
                return;
            }
        }
        void updateCurstType()
        {
            PriceTotal();
            if (rbThinCrust.Checked)
            {
                lblThinkCrust.Text = "Thin Crust";
                return;
            }
            if (rbThinkCrust.Checked)
            {
                lblThinkCrust.Text = "Think Crust";
                return;
            }
        }
        void updateWhereYouEat()
        {
            PriceTotal();
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }
            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
                return;
            }
        }
        void updateToppings()
        {
            PriceTotal();
            string sToppings = "";
            if (chkExtraChees.Checked)
            {
                sToppings += "ExtraChees";
            }
            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if (chkTomatos.Checked)
            {
                sToppings += ", Tomatos";
            }
            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }
            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }
            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }
            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }
            if (sToppings == "")
            {
                lblToppings.Text = "No Toppings";
            }
            else
            {
                lblToppings.Text = sToppings;
            }
        }

        void ConfirmOrder()
        {
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
            gbCrustType.Enabled = false;
            gbWhereToEat.Enabled = false;
            btnOrderPizza.Enabled = false;
        }
        void ResetForm()
        {
            //group box
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;
            //btn
            btnOrderPizza.Enabled = true;
            //size
            rbSmall.Checked = true;
            rbMedium.Checked = false;
            rbLarg.Checked = false;
            //toppings
            chkExtraChees.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatos.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;
            //crust type
            rbThinCrust.Checked = false;
            rbThinkCrust.Checked = false;
            //where to eat
            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();


        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();

        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCurstType();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCurstType();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereYouEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereYouEat();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Shure To Take This Command ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ConfirmOrder();
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
