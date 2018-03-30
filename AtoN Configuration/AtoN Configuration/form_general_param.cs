using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtoN_Configuration
{
    public partial class form_general_param : Form
    {
        public form_general_param()
        {
            InitializeComponent();
        }

        private void form_general_param_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void form_general_param_Load(object sender, EventArgs e)
        {

        }

        private void form_general_param_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //TODO: Save ALL configuration
            this.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //Just close WINDOW FORM, dont save anythings
            this.Close();
        }

        private void txt_no_channel_fre1_KeyPress(object sender, KeyPressEventArgs e)
        { //Only Acccept Numneric Input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //End of Numeric Check
        }

        private void txt_no_channel_fre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only Acccept Numneric Input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //End of Numeric Check
        }

        private void txt_no_channel_fre1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
