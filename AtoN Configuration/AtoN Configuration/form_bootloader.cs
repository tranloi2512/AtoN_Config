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
    public partial class form_bootloader : Form
    {
        public form_bootloader()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Show POP-UP -> cancel message
            this.Close();
        }
    }
}
