
namespace arduino_data_logger_simple
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
            this.textBox_display = new System.Windows.Forms.TextBox();
            this.comboBox_serialPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_display
            // 
            this.textBox_display.Enabled = false;
            this.textBox_display.Location = new System.Drawing.Point(33, 31);
            this.textBox_display.Multiline = true;
            this.textBox_display.Name = "textBox_display";
            this.textBox_display.Size = new System.Drawing.Size(284, 388);
            this.textBox_display.TabIndex = 0;
            // 
            // comboBox_serialPort
            // 
            this.comboBox_serialPort.FormattingEnabled = true;
            this.comboBox_serialPort.Location = new System.Drawing.Point(19, 37);
            this.comboBox_serialPort.Name = "comboBox_serialPort";
            this.comboBox_serialPort.Size = new System.Drawing.Size(180, 26);
            this.comboBox_serialPort.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.comboBox_serialPort);
            this.groupBox1.Location = new System.Drawing.Point(349, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial port";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(18, 79);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(185, 33);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.clicked_button_connect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_display;
        private System.Windows.Forms.ComboBox comboBox_serialPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_connect;
    }
}

