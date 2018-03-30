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
    public partial class AtoN_config : Form
    {
        public AtoN_config()
        {
            InitializeComponent();
        }

        private void AtoN_config_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mmsi_station_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mmsi_station_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_dist_OFF_Position_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_dimA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_dimB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_dimC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_dimD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            ///-----------------------------------------------
            /// Update All AtoN Command class member
            ///===============================================

            // ACE Class:
            /*
        public static string MMSI = "";
        public static string AtoN_STATUS = "";
        public static string OFFPOSITION_BEHAVIOUR = "";
        public static string ACK = "";
        public static string OFFPOSITION_THRESH = "";
        public static string SYNCHLOST_BEHAVIOUR = "";
        public static string AtoN_Name = "";
        public static string DIMENTION = "";
        public static string STAT_FLAG = "";
             */
            ACE_Command.MMSI = txt_MMSI.Text;
            // ACE_Command.AtoN_STATUS=
            ACE_Command.OFFPOSITION_THRESH = txt_dist_OFF_Position.Text;
            ACE_Command.AtoN_Name = txt_name.Text;
            ACE_Command.DIMENTION = txt_dimA.Text + txt_dimB.Text + txt_dimC.Text + txt_dimD.Text;
            label_ace_command.Text = ACE_Command.COMMAND;


        }

        private void txt_lattitude1_MouseDown(object sender, MouseEventArgs e)
        {
            txt_lattitude1.Clear();
        }

        private void txt_lattitude1_KeyPress(object sender, KeyPressEventArgs e)
        {   /// Check input 
             //Only Acccept Numneric Input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


        }

        private void txt_lattitude1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_lattitude1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_lattitude1.Text))
            {
                if (int.Parse(txt_lattitude1.Text) > 89)
                {
                    MessageBox.Show("Lattitude from 00°00.0000 to 89°99.9999");
                    txt_lattitude1.Clear();
                    txt_lattitude1.Select();
                }
            }
        }

        private void txt_lattitude2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_lattitude3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_longtitude1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_longtitude2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_longtitude3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_lattitude2_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_lattitude2.Text))
            {
                if (int.Parse(txt_lattitude2.Text) > 59)
                {
                    MessageBox.Show("Lattitude from 00°00.0000 to 89°59.9999");
                    txt_lattitude2.Clear();
                    txt_lattitude2.Select();
                }
            }
        }

        private void txt_lattitude2_MouseClick(object sender, MouseEventArgs e)
        {
            txt_lattitude2.Clear();
        }

        private void txt_lattitude3_MouseClick(object sender, MouseEventArgs e)
        {
            txt_lattitude3.Clear();
        }

        private void txt_longtitude1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_longtitude1.Clear();
        }

        private void txt_longtitude2_MouseClick(object sender, MouseEventArgs e)
        {
            txt_longtitude2.Clear();
        }

        private void txt_lattitude1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_lattitude1.Clear();
        }

        private void txt_lattitude2_MouseClick_1(object sender, MouseEventArgs e)
        {
            txt_lattitude2.Clear();
        }

        private void txt_lattitude3_MouseClick_1(object sender, MouseEventArgs e)
        {
            txt_lattitude3.Clear();
        }

        private void txt_longtitude1_MouseClick_1(object sender, MouseEventArgs e)
        {
            txt_longtitude1.Clear();
        }

        private void txt_longtitude2_MouseClick_1(object sender, MouseEventArgs e)
        {
            txt_longtitude2.Clear();
        }

        private void txt_longtitude3_MouseClick(object sender, MouseEventArgs e)
        {
            txt_longtitude3.Clear();
        }

        private void txt_MMSI_MouseClick(object sender, MouseEventArgs e)
        {
            txt_MMSI.Clear();
        }

        private void txt_name_MouseClick(object sender, MouseEventArgs e)
        {
            txt_name.Clear();
        }

        private void txt_longtitude1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_longtitude1.Text))
            {
                if (int.Parse(txt_longtitude1.Text) > 179)
                {
                    MessageBox.Show("Longtitude from 00°00.0000 to 179°59.9999");
                    txt_longtitude1.Clear();
                    txt_longtitude1.Select();
                }
            }
        }

        private void txt_longtitude2_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_longtitude2.Text))
            {
                if (int.Parse(txt_longtitude2.Text) > 59)
                {
                    MessageBox.Show("Longtitude from 00°00.0000 to 179°59.9999");
                    txt_longtitude2.Clear();
                    txt_longtitude2.Select();
                }
            }
        }

        private void txt_dist_OFF_Position_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_dist_OFF_Position.Text))
            {
                if (int.Parse(txt_dist_OFF_Position.Text) > 1500)
                {
                    MessageBox.Show("In meters, authorized values from 0 to 1500");
                    txt_dist_OFF_Position.Clear();
                    txt_dist_OFF_Position.Select();
                }
            }
        }

        private void txt_MMSI_dest6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only Acccept Numneric Input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbox_slot_mess6_AIS1_Click(object sender, EventArgs e)
        {
            if (cbox_slot_mess6_AIS1.Checked)
            {

            }
        }

        private void txt_dimA_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_dimA.Text))
            {
                if (int.Parse(txt_dimA.Text) > 511)
                {
                    MessageBox.Show("Maximum of A is 511 meters");
                    txt_dimA.Clear();
                    txt_dimA.Select();
                }
            }
        }

        private void txt_dimB_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_dimB.Text))
            {
                if (int.Parse(txt_dimB.Text) > 511)
                {
                    MessageBox.Show("Maximum of B is 511 meters");
                    txt_dimB.Clear();
                    txt_dimB.Select();
                }
            }
        }

        private void txt_dimC_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_dimC.Text))
            {
                if (int.Parse(txt_dimC.Text) > 63)
                {
                    MessageBox.Show("Maximum of C is 63 meters");
                    txt_dimC.Clear();
                    txt_dimC.Select();
                }
            }
        }

        private void txt_dimD_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_dimD.Text))
            {
                if (int.Parse(txt_dimD.Text) > 63)
                {
                    MessageBox.Show("Maximum of D is 63 meters");
                    txt_dimD.Clear();
                    txt_dimD.Select();
                }
            }
        }

        private void cbox_mes6_ext_Click(object sender, EventArgs e)
        {
            if (cbox_mes6_ext.Checked)
            {
                txt_interval6.Enabled = true;
                rbtn_FATDMA6.Enabled = true;
                rbtn_RATDMA6.Enabled = true;
                groupBox6.Enabled = true;
                groupBox9.Enabled = true;
                groupBox12.Enabled = true;
            }
            else
            {
                txt_interval6.Enabled = false;
                rbtn_FATDMA6.Enabled = false;
                rbtn_RATDMA6.Enabled = false;
                groupBox6.Enabled = false;
                groupBox9.Enabled = false;
                groupBox12.Enabled = false;
            }
        }

        private void cbox_msg8_EXT_Click(object sender, EventArgs e)
        {
            if (cbox_msg8_ext.Checked)
            {
                txt_interval8.Enabled = true;
                rbtn_FATDMA8.Enabled = true;
                rbtn_RATDMA8.Enabled = true;
                groupBox7.Enabled = true;
                groupBox10.Enabled = true;
                groupBox13.Enabled = true;
            }
            else
            {
                txt_interval8.Enabled = false;
                rbtn_FATDMA8.Enabled = false;
                rbtn_RATDMA8.Enabled = false;
                groupBox7.Enabled = false;
                groupBox10.Enabled = false;
                groupBox13.Enabled = false;
            }
        }

        private void rbtn_RATDMA6_Click(object sender, EventArgs e)
        {
            if (rbtn_RATDMA6.Checked)
            {
                groupBox6.Enabled = false;
                groupBox9.Enabled = false;
                groupBox12.Enabled = false;
            }

        }

        private void rbtn_FATDMA6_Click(object sender, EventArgs e)
        {
            if (rbtn_FATDMA6.Checked)
            {
                groupBox6.Enabled = true;
                groupBox9.Enabled = true;
                groupBox12.Enabled = true;
            }
        }

        private void rbtn_FATDMA8_Click(object sender, EventArgs e)
        {
            if (rbtn_FATDMA8.Checked)
            {
                groupBox7.Enabled = true;
                groupBox10.Enabled = true;
                groupBox13.Enabled = true;
            }
        }

        private void rbtn_RATDMA8_Click(object sender, EventArgs e)
        {
            if(rbtn_RATDMA8.Checked)
            {
                groupBox7.Enabled = false;
                groupBox10.Enabled = false;
                groupBox13.Enabled = false;
            }
        }

        private void rbtn_FATDMA_mess21_Click(object sender, EventArgs e)
        {
            if (rbtn_FATDMA8.Checked)
            {
                groupBox8.Enabled = true;
                groupBox11.Enabled = true;
            }
        }

        private void rbtn_RATDMA_mess21_Click(object sender, EventArgs e)
        {
            groupBox8.Enabled = false;
            groupBox11.Enabled = false;
        }
    }
}
