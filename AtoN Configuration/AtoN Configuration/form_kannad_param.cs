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
    public partial class form_kannad_param : Form
    {
        public form_kannad_param()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //Save all parameter before closing
            this.Close();
        }
    }
}
