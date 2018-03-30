using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AtoN_Configuration
{

    public partial class form_port : Form
    {


        public form_port()
        {
            InitializeComponent();
            TopMost = true;
            getAvaiablePort();
           
            // cbox_portName.SelectedIndex = 0;
            cbox_baudrate.SelectedIndex = 4;
            cbox_size.SelectedIndex = 1;
            cbox_parity.SelectedIndex = 0;
          
        }


       

        void getAvaiablePort() {
            string[] ports = SerialPort.GetPortNames();
            cbox_portName.Items.AddRange(ports);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen) //if port is open, close it and reinitial
            {
                mySerial.Close();
            }
                try
                {
                    if (cbox_portName.Text == "")
                    {
                        MessageBox.Show("Please Select Port", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }//end of if
                    else
                    {
                        mySerial.PortName = cbox_portName.Text;
                        mySerial.BaudRate = Convert.ToInt32(cbox_baudrate.Text);
                        mySerial.Parity = (Parity)Enum.Parse(typeof(Parity), cbox_parity.Text);
                        mySerial.DataBits = Convert.ToInt32(cbox_size.Text);
                        mySerial.Handshake = Handshake.None;

                        mySerial.Open();
                        MessageBox.Show("Open Successfully");
                        
                    }//end of else
                }//end of try

                catch (UnauthorizedAccessException ex)
                {
                MessageBox.Show(Convert.ToString(ex));

                }//end of catch
            

        }

        private void form_port_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            txt_tx.Text = ACE_Command.COMMAND;

            string tx = txt_tx.Text;
          
            try
            {
                mySerial.Write(tx);




            }

            catch (TimeoutException)
            {
                txt_rx.AppendText("TIME OUT\r\n");
            }

            txt_tx.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string rx = mySerial.ReadExisting();           

                if (rx != null)
                    txt_rx.AppendText(rx);
            }
            catch (TimeoutException) {

            }
        }


      

        
    }
}
