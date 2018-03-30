namespace AtoN_Configuration
{
    partial class form_general_param
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_no_channel_fre1 = new System.Windows.Forms.TextBox();
            this.txt_no_channel_fre2 = new System.Windows.Forms.TextBox();
            this.grbox_TOR1 = new System.Windows.Forms.GroupBox();
            this.list_allocation1 = new System.Windows.Forms.ListBox();
            this.list_active_level1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cryptage = new System.Windows.Forms.TextBox();
            this.grbox_TOR2 = new System.Windows.Forms.GroupBox();
            this.list_allocation2 = new System.Windows.Forms.ListBox();
            this.list_active_level2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbox_TOR3 = new System.Windows.Forms.GroupBox();
            this.list_allocation3 = new System.Windows.Forms.ListBox();
            this.list_active_level3 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbox_TOR4 = new System.Windows.Forms.GroupBox();
            this.list_allocation4 = new System.Windows.Forms.ListBox();
            this.list_active_level4 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grbox_TOR1.SuspendLayout();
            this.grbox_TOR2.SuspendLayout();
            this.grbox_TOR3.SuspendLayout();
            this.grbox_TOR4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel number for frequency 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Channel number for frequency 2";
            // 
            // txt_no_channel_fre1
            // 
            this.txt_no_channel_fre1.Location = new System.Drawing.Point(261, 25);
            this.txt_no_channel_fre1.Name = "txt_no_channel_fre1";
            this.txt_no_channel_fre1.Size = new System.Drawing.Size(100, 20);
            this.txt_no_channel_fre1.TabIndex = 2;
            this.txt_no_channel_fre1.TextChanged += new System.EventHandler(this.txt_no_channel_fre1_TextChanged);
            this.txt_no_channel_fre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_channel_fre1_KeyPress);
            // 
            // txt_no_channel_fre2
            // 
            this.txt_no_channel_fre2.Location = new System.Drawing.Point(261, 70);
            this.txt_no_channel_fre2.Name = "txt_no_channel_fre2";
            this.txt_no_channel_fre2.Size = new System.Drawing.Size(100, 20);
            this.txt_no_channel_fre2.TabIndex = 3;
            this.txt_no_channel_fre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_channel_fre2_KeyPress);
            // 
            // grbox_TOR1
            // 
            this.grbox_TOR1.Controls.Add(this.list_allocation1);
            this.grbox_TOR1.Controls.Add(this.list_active_level1);
            this.grbox_TOR1.Controls.Add(this.label5);
            this.grbox_TOR1.Controls.Add(this.label4);
            this.grbox_TOR1.Location = new System.Drawing.Point(30, 175);
            this.grbox_TOR1.Name = "grbox_TOR1";
            this.grbox_TOR1.Size = new System.Drawing.Size(209, 129);
            this.grbox_TOR1.TabIndex = 5;
            this.grbox_TOR1.TabStop = false;
            this.grbox_TOR1.Text = "TOR1";
            // 
            // list_allocation1
            // 
            this.list_allocation1.AllowDrop = true;
            this.list_allocation1.FormattingEnabled = true;
            this.list_allocation1.Items.AddRange(new object[] {
            "Light State",
            "Light Fault"});
            this.list_allocation1.Location = new System.Drawing.Point(91, 75);
            this.list_allocation1.Name = "list_allocation1";
            this.list_allocation1.Size = new System.Drawing.Size(98, 17);
            this.list_allocation1.TabIndex = 3;
            // 
            // list_active_level1
            // 
            this.list_active_level1.AllowDrop = true;
            this.list_active_level1.FormattingEnabled = true;
            this.list_active_level1.Items.AddRange(new object[] {
            "0. kw",
            "1. kw",
            "2. kw"});
            this.list_active_level1.Location = new System.Drawing.Point(91, 30);
            this.list_active_level1.Name = "list_active_level1";
            this.list_active_level1.Size = new System.Drawing.Size(98, 17);
            this.list_active_level1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Allocation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Active level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clel de cryptage";
            // 
            // txt_cryptage
            // 
            this.txt_cryptage.Location = new System.Drawing.Point(30, 128);
            this.txt_cryptage.Name = "txt_cryptage";
            this.txt_cryptage.Size = new System.Drawing.Size(331, 20);
            this.txt_cryptage.TabIndex = 7;
            this.txt_cryptage.Text = "00000000000000000000000000000000";
            // 
            // grbox_TOR2
            // 
            this.grbox_TOR2.Controls.Add(this.list_allocation2);
            this.grbox_TOR2.Controls.Add(this.list_active_level2);
            this.grbox_TOR2.Controls.Add(this.label6);
            this.grbox_TOR2.Controls.Add(this.label7);
            this.grbox_TOR2.Location = new System.Drawing.Point(278, 175);
            this.grbox_TOR2.Name = "grbox_TOR2";
            this.grbox_TOR2.Size = new System.Drawing.Size(209, 129);
            this.grbox_TOR2.TabIndex = 6;
            this.grbox_TOR2.TabStop = false;
            this.grbox_TOR2.Text = "TOR2";
            // 
            // list_allocation2
            // 
            this.list_allocation2.AllowDrop = true;
            this.list_allocation2.FormattingEnabled = true;
            this.list_allocation2.Items.AddRange(new object[] {
            "Light State",
            "Light Fault"});
            this.list_allocation2.Location = new System.Drawing.Point(105, 72);
            this.list_allocation2.Name = "list_allocation2";
            this.list_allocation2.Size = new System.Drawing.Size(98, 17);
            this.list_allocation2.TabIndex = 4;
            // 
            // list_active_level2
            // 
            this.list_active_level2.AllowDrop = true;
            this.list_active_level2.FormattingEnabled = true;
            this.list_active_level2.Items.AddRange(new object[] {
            "0. kw",
            "1. kw",
            "2. kw"});
            this.list_active_level2.Location = new System.Drawing.Point(105, 30);
            this.list_active_level2.Name = "list_active_level2";
            this.list_active_level2.Size = new System.Drawing.Size(98, 17);
            this.list_active_level2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Allocation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Active level";
            // 
            // grbox_TOR3
            // 
            this.grbox_TOR3.Controls.Add(this.list_allocation3);
            this.grbox_TOR3.Controls.Add(this.list_active_level3);
            this.grbox_TOR3.Controls.Add(this.label8);
            this.grbox_TOR3.Controls.Add(this.label9);
            this.grbox_TOR3.Location = new System.Drawing.Point(30, 321);
            this.grbox_TOR3.Name = "grbox_TOR3";
            this.grbox_TOR3.Size = new System.Drawing.Size(209, 129);
            this.grbox_TOR3.TabIndex = 6;
            this.grbox_TOR3.TabStop = false;
            this.grbox_TOR3.Text = "TOR3";
            // 
            // list_allocation3
            // 
            this.list_allocation3.AllowDrop = true;
            this.list_allocation3.FormattingEnabled = true;
            this.list_allocation3.Items.AddRange(new object[] {
            "Light State",
            "Light Fault"});
            this.list_allocation3.Location = new System.Drawing.Point(91, 75);
            this.list_allocation3.Name = "list_allocation3";
            this.list_allocation3.Size = new System.Drawing.Size(98, 17);
            this.list_allocation3.TabIndex = 3;
            // 
            // list_active_level3
            // 
            this.list_active_level3.AllowDrop = true;
            this.list_active_level3.FormattingEnabled = true;
            this.list_active_level3.Items.AddRange(new object[] {
            "0. kw",
            "1. kw",
            "2. kw"});
            this.list_active_level3.Location = new System.Drawing.Point(91, 30);
            this.list_active_level3.Name = "list_active_level3";
            this.list_active_level3.Size = new System.Drawing.Size(98, 17);
            this.list_active_level3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Allocation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Active level";
            // 
            // grbox_TOR4
            // 
            this.grbox_TOR4.Controls.Add(this.list_allocation4);
            this.grbox_TOR4.Controls.Add(this.list_active_level4);
            this.grbox_TOR4.Controls.Add(this.label10);
            this.grbox_TOR4.Controls.Add(this.label11);
            this.grbox_TOR4.Location = new System.Drawing.Point(278, 321);
            this.grbox_TOR4.Name = "grbox_TOR4";
            this.grbox_TOR4.Size = new System.Drawing.Size(209, 129);
            this.grbox_TOR4.TabIndex = 6;
            this.grbox_TOR4.TabStop = false;
            this.grbox_TOR4.Text = "TOR4";
            // 
            // list_allocation4
            // 
            this.list_allocation4.AllowDrop = true;
            this.list_allocation4.FormattingEnabled = true;
            this.list_allocation4.Items.AddRange(new object[] {
            "Light State",
            "Light Fault"});
            this.list_allocation4.Location = new System.Drawing.Point(91, 75);
            this.list_allocation4.Name = "list_allocation4";
            this.list_allocation4.Size = new System.Drawing.Size(98, 17);
            this.list_allocation4.TabIndex = 3;
            // 
            // list_active_level4
            // 
            this.list_active_level4.AllowDrop = true;
            this.list_active_level4.FormattingEnabled = true;
            this.list_active_level4.Items.AddRange(new object[] {
            "0. kw",
            "1. kw",
            "2. kw"});
            this.list_active_level4.Location = new System.Drawing.Point(91, 30);
            this.list_active_level4.Name = "list_active_level4";
            this.list_active_level4.Size = new System.Drawing.Size(98, 17);
            this.list_active_level4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Allocation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Active level";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(288, 472);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(392, 472);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // form_general_param
            // 
            this.ClientSize = new System.Drawing.Size(532, 516);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.grbox_TOR4);
            this.Controls.Add(this.grbox_TOR3);
            this.Controls.Add(this.grbox_TOR2);
            this.Controls.Add(this.txt_cryptage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbox_TOR1);
            this.Controls.Add(this.txt_no_channel_fre2);
            this.Controls.Add(this.txt_no_channel_fre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_general_param";
            this.Load += new System.EventHandler(this.form_general_param_Load_1);
            this.grbox_TOR1.ResumeLayout(false);
            this.grbox_TOR1.PerformLayout();
            this.grbox_TOR2.ResumeLayout(false);
            this.grbox_TOR2.PerformLayout();
            this.grbox_TOR3.ResumeLayout(false);
            this.grbox_TOR3.PerformLayout();
            this.grbox_TOR4.ResumeLayout(false);
            this.grbox_TOR4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
      
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_no_channel_fre1;
        private System.Windows.Forms.TextBox txt_no_channel_fre2;
        private System.Windows.Forms.GroupBox grbox_TOR1;
        private System.Windows.Forms.ListBox list_active_level1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cryptage;
        private System.Windows.Forms.GroupBox grbox_TOR2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox list_active_level2;
        private System.Windows.Forms.ListBox list_allocation1;
        private System.Windows.Forms.ListBox list_allocation2;
        private System.Windows.Forms.GroupBox grbox_TOR3;
        private System.Windows.Forms.ListBox list_allocation3;
        private System.Windows.Forms.ListBox list_active_level3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbox_TOR4;
        private System.Windows.Forms.ListBox list_allocation4;
        private System.Windows.Forms.ListBox list_active_level4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}