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

  

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
         
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.Hide();
            form_general_param gp = new form_general_param();
            gp.Show();
        }

        private void kannadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_kannad_param kp = new form_kannad_param();
            kp.Show();
        }

        private void realAtoNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtoN_config aton_cf = new AtoN_config();
            aton_cf.Show();
        }

        private void atonVOrSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_AtoN_VorS av = new form_AtoN_VorS();
            av.Show();
        }

        private void repeaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_repeater rptr = new form_repeater();
            rptr.Show();
        }

        private void turnonTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_turn_on_time turn_on_time = new form_turn_on_time();
            turn_on_time.Show();
        }

        private void onGoingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_ongGoing on_going = new form_ongGoing();
            on_going.Show();
        }

        private void bootloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_bootloader fboot_loader = new form_bootloader();
            fboot_loader.Show();
        }

        private void portComToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_port fport = new form_port();
            fport.Show();
        }


        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }


    /// <summary>
    /// Define AAR Command 
    /// </summary>
    public  class AAR_Command
    {
        public static string MMSI = "";
        public static string MESSAGE_ID = "";
        public static string ID_INDEX = "";
        public static string UTC_HOUR_C1 = "";
        public static string UTC_MIN_C1 = "";
        public static string START_SLOT_C1 = "";
        public static string SLOT_INTR_C1 = "";
        public static string DMA_SET = "";
        public static string UTC_HOUR_C2 = "";
        public static string UTC_MIN_C2 = "";
        public static string START_SLOT_C2 = "";
        public static string SLOT_INTR_C2 = "";
        public static string STAT_FLAG = "";
        private static string cOMMAND = "$--AAR," + MMSI+","+MESSAGE_ID+
                                        ","+ID_INDEX+","+UTC_HOUR_C1+","+UTC_MIN_C1+","+START_SLOT_C1+","
                                         +SLOT_INTR_C1+","+DMA_SET+","+UTC_HOUR_C2+","+UTC_MIN_C2+","
                                         +START_SLOT_C2+","+START_SLOT_C2+","+SLOT_INTR_C2+","+STAT_FLAG; //concat all field for uart transmit


    }


    /// <summary>
    /// Define ACE Command
    /// </summary>
    public static class ACE_Command
    {
        public static string MMSI = "";
        public static string AtoN_STATUS = "";
        public static string OFFPOSITION_BEHAVIOUR = "";
        public static string ACK = "";
        public static string OFFPOSITION_THRESH = "";
        public static string SYNCHLOST_BEHAVIOUR = "";
        public static string AtoN_Name = "";
        public static string DIMENTION = "";
        public static string STAT_FLAG = "";
        public static string COMMAND = "$--ACE,"+MMSI+","+AtoN_STATUS+","
                                    +OFFPOSITION_THRESH+","+ACK+","+OFFPOSITION_BEHAVIOUR
                                    +","+SYNCHLOST_BEHAVIOUR+","+AtoN_Name+","+DIMENTION;
    }

    /// <summary>
    /// Define ACF Command
    /// </summary>
    public static class ACF_Command
    {
        public static string MMSI = "";
        public static string EPFS_TYPE = "";
        public static string LATTITUDE = "";
        public static string NS = "";
        public static string LONGTITUDE = "";
        public static string EW= "";
        public static string POSITION_ACC = "";
        public static string RX_C1= "";
        public static string RX_C2 = "";
        public static string TX_C1 = "";
        public static string TX_C2 = "";
        public static string POWER_LEVEL= "";
        public static string AtoN_TYPE = "";
        public static string VIRTUAL_FLAG = "";
        public static string STAT_FLAG= "";
        public static string COMMAND = "$--ACF,"+MMSI+","+EPFS_TYPE+","
                                        +LATTITUDE+","+NS+","+LONGTITUDE+","+EW+","+POSITION_ACC+","
                                        +RX_C1+","+RX_C2+","+TX_C1+","+TX_C2+","+POWER_LEVEL+","
                                        +AtoN_TYPE+","+VIRTUAL_FLAG+","+STAT_FLAG;


    }

    /// <summary>
    /// Define AFB Command
    /// </summary>
    public static class AFB_Command
    {
        public static string MMSI = "";
        public static string MESSAGE_ID= "";
        public static string ID_INDEX= "";
        public static string UTC_HOUR_START_SLOT= "";
        public static string UTC_MIN_START_SLOT = "";
        public static string START_SLOT = "";
        public static string CHANNEL = "";
        public static string STAT_FLAG = "";
        public static string COMMAND = "$--AFB,"+MMSI+","+MESSAGE_ID+","+ID_INDEX+","
                                    +UTC_HOUR_START_SLOT+","+UTC_MIN_START_SLOT+"," 
                                    +START_SLOT+","+CHANNEL+","+STAT_FLAG;

    }

}
