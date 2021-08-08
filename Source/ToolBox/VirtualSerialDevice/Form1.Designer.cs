namespace VirtualSerialDevice
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rTxtBx_COM = new System.Windows.Forms.RichTextBox();
            this.lbl_COM_Terminal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl_Value1 = new System.Windows.Forms.Label();
            this.txtBx_value1 = new System.Windows.Forms.TextBox();
            this.txtBx_Speed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(9, 32);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(75, 21);
            this.cbSerialPort.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnect.Location = new System.Drawing.Point(9, 160);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // rTxtBx_COM
            // 
            this.rTxtBx_COM.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rTxtBx_COM.Location = new System.Drawing.Point(12, 24);
            this.rTxtBx_COM.Name = "rTxtBx_COM";
            this.rTxtBx_COM.Size = new System.Drawing.Size(417, 172);
            this.rTxtBx_COM.TabIndex = 3;
            this.rTxtBx_COM.Text = "";
            this.rTxtBx_COM.WordWrap = false;
            // 
            // lbl_COM_Terminal
            // 
            this.lbl_COM_Terminal.AutoSize = true;
            this.lbl_COM_Terminal.Location = new System.Drawing.Point(9, 8);
            this.lbl_COM_Terminal.Name = "lbl_COM_Terminal";
            this.lbl_COM_Terminal.Size = new System.Drawing.Size(74, 13);
            this.lbl_COM_Terminal.TabIndex = 9;
            this.lbl_COM_Terminal.Text = "COM Terminal";
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(9, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl_Value1
            // 
            this.lbl_Value1.AutoSize = true;
            this.lbl_Value1.Location = new System.Drawing.Point(6, 25);
            this.lbl_Value1.Name = "lbl_Value1";
            this.lbl_Value1.Size = new System.Drawing.Size(54, 13);
            this.lbl_Value1.TabIndex = 12;
            this.lbl_Value1.Text = "LED state";
            // 
            // txtBx_value1
            // 
            this.txtBx_value1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_value1.Location = new System.Drawing.Point(74, 20);
            this.txtBx_value1.Name = "txtBx_value1";
            this.txtBx_value1.Size = new System.Drawing.Size(100, 20);
            this.txtBx_value1.TabIndex = 14;
            this.txtBx_value1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBx_Speed
            // 
            this.txtBx_Speed.Location = new System.Drawing.Point(9, 72);
            this.txtBx_Speed.Name = "txtBx_Speed";
            this.txtBx_Speed.Size = new System.Drawing.Size(75, 20);
            this.txtBx_Speed.TabIndex = 15;
            this.txtBx_Speed.Text = "115200";
            this.txtBx_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Baudrate:";
            // 
            // btnToggle
            // 
            this.btnToggle.Enabled = false;
            this.btnToggle.Location = new System.Drawing.Point(180, 18);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 23);
            this.btnToggle.TabIndex = 17;
            this.btnToggle.Text = "Toggle";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbSerialPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBx_Speed);
            this.groupBox1.Location = new System.Drawing.Point(435, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 247);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOff);
            this.groupBox2.Controls.Add(this.btnOn);
            this.groupBox2.Controls.Add(this.lbl_Value1);
            this.groupBox2.Controls.Add(this.btnToggle);
            this.groupBox2.Controls.Add(this.txtBx_value1);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 67);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Control";
            // 
            // btnOff
            // 
            this.btnOff.Enabled = false;
            this.btnOff.Location = new System.Drawing.Point(336, 18);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOff.TabIndex = 19;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Enabled = false;
            this.btnOn.Location = new System.Drawing.Point(258, 18);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(75, 23);
            this.btnOn.TabIndex = 18;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_COM_Terminal);
            this.Controls.Add(this.rTxtBx_COM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Serial Device";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox rTxtBx_COM;
        private System.Windows.Forms.Label lbl_COM_Terminal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl_Value1;
        private System.Windows.Forms.TextBox txtBx_value1;
        private System.Windows.Forms.TextBox txtBx_Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnClear;
    }
}

