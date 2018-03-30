namespace AtoN_Configuration
{
    partial class form_port
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_openPort = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_baudrate = new System.Windows.Forms.ComboBox();
            this.cbox_size = new System.Windows.Forms.ComboBox();
            this.cbox_parity = new System.Windows.Forms.ComboBox();
            this.mySerial = new System.IO.Ports.SerialPort(this.components);
            this.cbox_portName = new System.Windows.Forms.ComboBox();
            this.txt_tx = new System.Windows.Forms.TextBox();
            this.txt_rx = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate:";
            // 
            // btn_openPort
            // 
            this.btn_openPort.Location = new System.Drawing.Point(15, 201);
            this.btn_openPort.Name = "btn_openPort";
            this.btn_openPort.Size = new System.Drawing.Size(84, 26);
            this.btn_openPort.TabIndex = 4;
            this.btn_openPort.Text = "Open Port";
            this.btn_openPort.UseVisualStyleBackColor = true;
            this.btn_openPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(140, 201);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 26);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parity";
            // 
            // cbox_baudrate
            // 
            this.cbox_baudrate.FormattingEnabled = true;
            this.cbox_baudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "56000",
            "115200",
            "128000",
            "256000"});
            this.cbox_baudrate.Location = new System.Drawing.Point(95, 60);
            this.cbox_baudrate.Name = "cbox_baudrate";
            this.cbox_baudrate.Size = new System.Drawing.Size(121, 21);
            this.cbox_baudrate.TabIndex = 10;
            // 
            // cbox_size
            // 
            this.cbox_size.FormattingEnabled = true;
            this.cbox_size.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbox_size.Location = new System.Drawing.Point(95, 100);
            this.cbox_size.Name = "cbox_size";
            this.cbox_size.Size = new System.Drawing.Size(121, 21);
            this.cbox_size.TabIndex = 11;
            // 
            // cbox_parity
            // 
            this.cbox_parity.FormattingEnabled = true;
            this.cbox_parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cbox_parity.Location = new System.Drawing.Point(94, 140);
            this.cbox_parity.Name = "cbox_parity";
            this.cbox_parity.Size = new System.Drawing.Size(121, 21);
            this.cbox_parity.TabIndex = 12;
            // 
            // mySerial
            // 
            this.mySerial.BaudRate = 115200;
            this.mySerial.PortName = "COM4";
            // 
            // cbox_portName
            // 
            this.cbox_portName.FormattingEnabled = true;
            this.cbox_portName.Location = new System.Drawing.Point(95, 21);
            this.cbox_portName.Name = "cbox_portName";
            this.cbox_portName.Size = new System.Drawing.Size(121, 21);
            this.cbox_portName.TabIndex = 13;
            // 
            // txt_tx
            // 
            this.txt_tx.Location = new System.Drawing.Point(264, 18);
            this.txt_tx.Multiline = true;
            this.txt_tx.Name = "txt_tx";
            this.txt_tx.Size = new System.Drawing.Size(201, 172);
            this.txt_tx.TabIndex = 14;
            // 
            // txt_rx
            // 
            this.txt_rx.Location = new System.Drawing.Point(509, 18);
            this.txt_rx.Multiline = true;
            this.txt_rx.Name = "txt_rx";
            this.txt_rx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_rx.Size = new System.Drawing.Size(625, 172);
            this.txt_rx.TabIndex = 15;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(264, 201);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(84, 26);
            this.btn_send.TabIndex = 16;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 26);
            this.button2.TabIndex = 17;
            this.button2.Text = "Get data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_port
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(1334, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_rx);
            this.Controls.Add(this.txt_tx);
            this.Controls.Add(this.cbox_portName);
            this.Controls.Add(this.cbox_parity);
            this.Controls.Add(this.cbox_size);
            this.Controls.Add(this.cbox_baudrate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_openPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_port";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Serial Port";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.form_port_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_openPort;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_baudrate;
        private System.Windows.Forms.ComboBox cbox_size;
        private System.Windows.Forms.ComboBox cbox_parity;
        private System.IO.Ports.SerialPort mySerial;
        private System.Windows.Forms.ComboBox cbox_portName;
        private System.Windows.Forms.TextBox txt_tx;
        private System.Windows.Forms.TextBox txt_rx;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button button2;
    }
}