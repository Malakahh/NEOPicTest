namespace NEOPicTest
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
            this.richTextBoxUSB = new System.Windows.Forms.RichTextBox();
            this.richTextBoxBluetooth = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUSB = new System.Windows.Forms.TextBox();
            this.textBoxBluetooth = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxClearBluetooth = new System.Windows.Forms.CheckBox();
            this.chkBoxClearUSB = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxWriteTimeout = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxReadTimeout = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.btnUSBConnect = new System.Windows.Forms.Button();
            this.txtBoxDataBits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxBaudRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPortName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUSBBytesRead = new System.Windows.Forms.Label();
            this.lblBluetoothBytesRead = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBoxUSBBytes = new System.Windows.Forms.RichTextBox();
            this.richTextBoxBluetoothBytes = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxUSB
            // 
            this.richTextBoxUSB.Location = new System.Drawing.Point(247, 178);
            this.richTextBoxUSB.Name = "richTextBoxUSB";
            this.richTextBoxUSB.ReadOnly = true;
            this.richTextBoxUSB.Size = new System.Drawing.Size(349, 391);
            this.richTextBoxUSB.TabIndex = 0;
            this.richTextBoxUSB.Text = "";
            // 
            // richTextBoxBluetooth
            // 
            this.richTextBoxBluetooth.Location = new System.Drawing.Point(602, 178);
            this.richTextBoxBluetooth.Name = "richTextBoxBluetooth";
            this.richTextBoxBluetooth.ReadOnly = true;
            this.richTextBoxBluetooth.Size = new System.Drawing.Size(349, 391);
            this.richTextBoxBluetooth.TabIndex = 1;
            this.richTextBoxBluetooth.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "USB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bluetooth";
            // 
            // textBoxUSB
            // 
            this.textBoxUSB.Location = new System.Drawing.Point(247, 575);
            this.textBoxUSB.Name = "textBoxUSB";
            this.textBoxUSB.Size = new System.Drawing.Size(349, 20);
            this.textBoxUSB.TabIndex = 4;
            // 
            // textBoxBluetooth
            // 
            this.textBoxBluetooth.Location = new System.Drawing.Point(603, 575);
            this.textBoxBluetooth.Name = "textBoxBluetooth";
            this.textBoxBluetooth.Size = new System.Drawing.Size(348, 20);
            this.textBoxBluetooth.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxClearBluetooth);
            this.groupBox1.Controls.Add(this.chkBoxClearUSB);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(12, 521);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clear";
            // 
            // chkBoxClearBluetooth
            // 
            this.chkBoxClearBluetooth.AutoSize = true;
            this.chkBoxClearBluetooth.Checked = true;
            this.chkBoxClearBluetooth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxClearBluetooth.Location = new System.Drawing.Point(114, 43);
            this.chkBoxClearBluetooth.Name = "chkBoxClearBluetooth";
            this.chkBoxClearBluetooth.Size = new System.Drawing.Size(71, 17);
            this.chkBoxClearBluetooth.TabIndex = 2;
            this.chkBoxClearBluetooth.Text = "Bluetooth";
            this.chkBoxClearBluetooth.UseVisualStyleBackColor = true;
            // 
            // chkBoxClearUSB
            // 
            this.chkBoxClearUSB.AutoSize = true;
            this.chkBoxClearUSB.Checked = true;
            this.chkBoxClearUSB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxClearUSB.Location = new System.Drawing.Point(114, 20);
            this.chkBoxClearUSB.Name = "chkBoxClearUSB";
            this.chkBoxClearUSB.Size = new System.Drawing.Size(48, 17);
            this.chkBoxClearUSB.TabIndex = 1;
            this.chkBoxClearUSB.Text = "USB";
            this.chkBoxClearUSB.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 40);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear console";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBoxWriteTimeout);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBoxReadTimeout);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxStopBits);
            this.groupBox2.Controls.Add(this.btnUSBConnect);
            this.groupBox2.Controls.Add(this.txtBoxDataBits);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxParity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxBaudRate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxPortName);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 285);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USB Connect";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Write Timeout:";
            // 
            // txtBoxWriteTimeout
            // 
            this.txtBoxWriteTimeout.Location = new System.Drawing.Point(90, 202);
            this.txtBoxWriteTimeout.Name = "txtBoxWriteTimeout";
            this.txtBoxWriteTimeout.Size = new System.Drawing.Size(95, 20);
            this.txtBoxWriteTimeout.TabIndex = 12;
            this.txtBoxWriteTimeout.Text = "500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Read Timeout:";
            // 
            // txtBoxReadTimeout
            // 
            this.txtBoxReadTimeout.Location = new System.Drawing.Point(90, 175);
            this.txtBoxReadTimeout.Name = "txtBoxReadTimeout";
            this.txtBoxReadTimeout.Size = new System.Drawing.Size(95, 20);
            this.txtBoxReadTimeout.TabIndex = 10;
            this.txtBoxReadTimeout.Text = "500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stop Bits:";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(72, 126);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(113, 21);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // btnUSBConnect
            // 
            this.btnUSBConnect.Location = new System.Drawing.Point(6, 234);
            this.btnUSBConnect.Name = "btnUSBConnect";
            this.btnUSBConnect.Size = new System.Drawing.Size(188, 45);
            this.btnUSBConnect.TabIndex = 8;
            this.btnUSBConnect.Text = "Connect";
            this.btnUSBConnect.UseVisualStyleBackColor = true;
            this.btnUSBConnect.Click += new System.EventHandler(this.btnUSBConnect_Click);
            // 
            // txtBoxDataBits
            // 
            this.txtBoxDataBits.Location = new System.Drawing.Point(72, 99);
            this.txtBoxDataBits.Name = "txtBoxDataBits";
            this.txtBoxDataBits.Size = new System.Drawing.Size(113, 20);
            this.txtBoxDataBits.TabIndex = 7;
            this.txtBoxDataBits.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data Bits:";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(72, 72);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(113, 21);
            this.comboBoxParity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity:";
            // 
            // txtBoxBaudRate
            // 
            this.txtBoxBaudRate.Location = new System.Drawing.Point(72, 46);
            this.txtBoxBaudRate.Name = "txtBoxBaudRate";
            this.txtBoxBaudRate.Size = new System.Drawing.Size(113, 20);
            this.txtBoxBaudRate.TabIndex = 3;
            this.txtBoxBaudRate.Text = "2400";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Baud Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port Name:";
            // 
            // txtBoxPortName
            // 
            this.txtBoxPortName.Location = new System.Drawing.Point(72, 19);
            this.txtBoxPortName.Name = "txtBoxPortName";
            this.txtBoxPortName.Size = new System.Drawing.Size(113, 20);
            this.txtBoxPortName.TabIndex = 0;
            this.txtBoxPortName.Text = "COM4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bytes Read:";
            // 
            // lblUSBBytesRead
            // 
            this.lblUSBBytesRead.AutoSize = true;
            this.lblUSBBytesRead.Location = new System.Drawing.Point(375, 21);
            this.lblUSBBytesRead.Name = "lblUSBBytesRead";
            this.lblUSBBytesRead.Size = new System.Drawing.Size(13, 13);
            this.lblUSBBytesRead.TabIndex = 9;
            this.lblUSBBytesRead.Text = "0";
            // 
            // lblBluetoothBytesRead
            // 
            this.lblBluetoothBytesRead.AutoSize = true;
            this.lblBluetoothBytesRead.Location = new System.Drawing.Point(778, 21);
            this.lblBluetoothBytesRead.Name = "lblBluetoothBytesRead";
            this.lblBluetoothBytesRead.Size = new System.Drawing.Size(13, 13);
            this.lblBluetoothBytesRead.TabIndex = 11;
            this.lblBluetoothBytesRead.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(707, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Bytes Read:";
            // 
            // richTextBoxUSBBytes
            // 
            this.richTextBoxUSBBytes.Location = new System.Drawing.Point(247, 41);
            this.richTextBoxUSBBytes.Name = "richTextBoxUSBBytes";
            this.richTextBoxUSBBytes.ReadOnly = true;
            this.richTextBoxUSBBytes.Size = new System.Drawing.Size(349, 131);
            this.richTextBoxUSBBytes.TabIndex = 12;
            this.richTextBoxUSBBytes.Text = "";
            // 
            // richTextBoxBluetoothBytes
            // 
            this.richTextBoxBluetoothBytes.Location = new System.Drawing.Point(603, 41);
            this.richTextBoxBluetoothBytes.Name = "richTextBoxBluetoothBytes";
            this.richTextBoxBluetoothBytes.ReadOnly = true;
            this.richTextBoxBluetoothBytes.Size = new System.Drawing.Size(349, 131);
            this.richTextBoxBluetoothBytes.TabIndex = 13;
            this.richTextBoxBluetoothBytes.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 212);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bluetooth Connect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBoxBluetoothBytes);
            this.Controls.Add(this.richTextBoxUSBBytes);
            this.Controls.Add(this.lblBluetoothBytesRead);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblUSBBytesRead);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxBluetooth);
            this.Controls.Add(this.textBoxUSB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxBluetooth);
            this.Controls.Add(this.richTextBoxUSB);
            this.Name = "Form1";
            this.Text = "NEO PIC Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxUSB;
        private System.Windows.Forms.RichTextBox richTextBoxBluetooth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUSB;
        private System.Windows.Forms.TextBox textBoxBluetooth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBoxClearBluetooth;
        private System.Windows.Forms.CheckBox chkBoxClearUSB;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPortName;
        private System.Windows.Forms.TextBox txtBoxBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.TextBox txtBoxDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUSBConnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxWriteTimeout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxReadTimeout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUSBBytesRead;
        private System.Windows.Forms.Label lblBluetoothBytesRead;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBoxUSBBytes;
        private System.Windows.Forms.RichTextBox richTextBoxBluetoothBytes;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

