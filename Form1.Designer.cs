
namespace ModbusTCP
{
    partial class Form_Modbus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Modbus));
            this.bt_Connect = new System.Windows.Forms.Button();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.bt_Lamp1 = new System.Windows.Forms.Button();
            this.bt_Lamp2 = new System.Windows.Forms.Button();
            this.bt_Lamp3 = new System.Windows.Forms.Button();
            this.bt_Lamp4 = new System.Windows.Forms.Button();
            this.tb_ModbusServerIP = new System.Windows.Forms.TextBox();
            this.lb_Status = new System.Windows.Forms.Label();
            this.lb_ModbusServerIP = new System.Windows.Forms.Label();
            this.lb_ConnectionStatus = new System.Windows.Forms.Label();
            this.lb_Channel1 = new System.Windows.Forms.Label();
            this.lb_Channel2 = new System.Windows.Forms.Label();
            this.lb_Channel3 = new System.Windows.Forms.Label();
            this.lb_Channel4 = new System.Windows.Forms.Label();
            this.tmr_Modbus_Com = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(15, 51);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(92, 43);
            this.bt_Connect.TabIndex = 0;
            this.bt_Connect.Text = "&Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.Location = new System.Drawing.Point(113, 51);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(92, 43);
            this.bt_Disconnect.TabIndex = 1;
            this.bt_Disconnect.Text = "&Disconnect";
            this.bt_Disconnect.UseVisualStyleBackColor = true;
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_Disconnect_Click);
            // 
            // bt_Lamp1
            // 
            this.bt_Lamp1.Location = new System.Drawing.Point(12, 123);
            this.bt_Lamp1.Name = "bt_Lamp1";
            this.bt_Lamp1.Size = new System.Drawing.Size(92, 80);
            this.bt_Lamp1.TabIndex = 2;
            this.bt_Lamp1.Text = "Lamp 1";
            this.bt_Lamp1.UseVisualStyleBackColor = true;
            this.bt_Lamp1.Click += new System.EventHandler(this.bt_Lamp1_Click);
            // 
            // bt_Lamp2
            // 
            this.bt_Lamp2.Location = new System.Drawing.Point(113, 123);
            this.bt_Lamp2.Name = "bt_Lamp2";
            this.bt_Lamp2.Size = new System.Drawing.Size(92, 80);
            this.bt_Lamp2.TabIndex = 3;
            this.bt_Lamp2.Text = "Lamp 2";
            this.bt_Lamp2.UseVisualStyleBackColor = true;
            this.bt_Lamp2.Click += new System.EventHandler(this.bt_Lamp2_Click);
            // 
            // bt_Lamp3
            // 
            this.bt_Lamp3.Location = new System.Drawing.Point(211, 123);
            this.bt_Lamp3.Name = "bt_Lamp3";
            this.bt_Lamp3.Size = new System.Drawing.Size(92, 80);
            this.bt_Lamp3.TabIndex = 4;
            this.bt_Lamp3.Text = "Lamp 3";
            this.bt_Lamp3.UseVisualStyleBackColor = true;
            this.bt_Lamp3.Click += new System.EventHandler(this.bt_Lamp3_Click);
            // 
            // bt_Lamp4
            // 
            this.bt_Lamp4.Location = new System.Drawing.Point(309, 123);
            this.bt_Lamp4.Name = "bt_Lamp4";
            this.bt_Lamp4.Size = new System.Drawing.Size(92, 80);
            this.bt_Lamp4.TabIndex = 5;
            this.bt_Lamp4.Text = "Lamp 4";
            this.bt_Lamp4.UseVisualStyleBackColor = true;
            this.bt_Lamp4.Click += new System.EventHandler(this.bt_Lamp4_Click);
            // 
            // tb_ModbusServerIP
            // 
            this.tb_ModbusServerIP.Location = new System.Drawing.Point(15, 25);
            this.tb_ModbusServerIP.Name = "tb_ModbusServerIP";
            this.tb_ModbusServerIP.Size = new System.Drawing.Size(92, 20);
            this.tb_ModbusServerIP.TabIndex = 6;
            this.tb_ModbusServerIP.Text = "192.168.2.102";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(112, 28);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(37, 13);
            this.lb_Status.TabIndex = 7;
            this.lb_Status.Text = "Status";
            // 
            // lb_ModbusServerIP
            // 
            this.lb_ModbusServerIP.AutoSize = true;
            this.lb_ModbusServerIP.Location = new System.Drawing.Point(14, 9);
            this.lb_ModbusServerIP.Name = "lb_ModbusServerIP";
            this.lb_ModbusServerIP.Size = new System.Drawing.Size(92, 13);
            this.lb_ModbusServerIP.TabIndex = 8;
            this.lb_ModbusServerIP.Text = "Modbus Server IP";
            // 
            // lb_ConnectionStatus
            // 
            this.lb_ConnectionStatus.AutoSize = true;
            this.lb_ConnectionStatus.Location = new System.Drawing.Point(112, 9);
            this.lb_ConnectionStatus.Name = "lb_ConnectionStatus";
            this.lb_ConnectionStatus.Size = new System.Drawing.Size(94, 13);
            this.lb_ConnectionStatus.TabIndex = 9;
            this.lb_ConnectionStatus.Text = "Connection Status";
            // 
            // lb_Channel1
            // 
            this.lb_Channel1.AutoSize = true;
            this.lb_Channel1.Location = new System.Drawing.Point(14, 107);
            this.lb_Channel1.Name = "lb_Channel1";
            this.lb_Channel1.Size = new System.Drawing.Size(55, 13);
            this.lb_Channel1.TabIndex = 10;
            this.lb_Channel1.Text = "Channel 1";
            // 
            // lb_Channel2
            // 
            this.lb_Channel2.AutoSize = true;
            this.lb_Channel2.Location = new System.Drawing.Point(112, 107);
            this.lb_Channel2.Name = "lb_Channel2";
            this.lb_Channel2.Size = new System.Drawing.Size(55, 13);
            this.lb_Channel2.TabIndex = 11;
            this.lb_Channel2.Text = "Channel 2";
            // 
            // lb_Channel3
            // 
            this.lb_Channel3.AutoSize = true;
            this.lb_Channel3.Location = new System.Drawing.Point(210, 107);
            this.lb_Channel3.Name = "lb_Channel3";
            this.lb_Channel3.Size = new System.Drawing.Size(55, 13);
            this.lb_Channel3.TabIndex = 12;
            this.lb_Channel3.Text = "Channel 3";
            // 
            // lb_Channel4
            // 
            this.lb_Channel4.AutoSize = true;
            this.lb_Channel4.Location = new System.Drawing.Point(308, 107);
            this.lb_Channel4.Name = "lb_Channel4";
            this.lb_Channel4.Size = new System.Drawing.Size(55, 13);
            this.lb_Channel4.TabIndex = 13;
            this.lb_Channel4.Text = "Channel 4";
            // 
            // tmr_Modbus_Com
            // 
            this.tmr_Modbus_Com.Tick += new System.EventHandler(this.tmr_Modbus_Com_Tick);
            // 
            // Form_Modbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 218);
            this.Controls.Add(this.lb_Channel4);
            this.Controls.Add(this.lb_Channel3);
            this.Controls.Add(this.lb_Channel2);
            this.Controls.Add(this.lb_Channel1);
            this.Controls.Add(this.lb_ConnectionStatus);
            this.Controls.Add(this.lb_ModbusServerIP);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.tb_ModbusServerIP);
            this.Controls.Add(this.bt_Lamp4);
            this.Controls.Add(this.bt_Lamp3);
            this.Controls.Add(this.bt_Lamp2);
            this.Controls.Add(this.bt_Lamp1);
            this.Controls.Add(this.bt_Disconnect);
            this.Controls.Add(this.bt_Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Modbus";
            this.Text = "Modbus TCP by Mangnimit MCU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button bt_Disconnect;
        private System.Windows.Forms.Button bt_Lamp1;
        private System.Windows.Forms.Button bt_Lamp2;
        private System.Windows.Forms.Button bt_Lamp3;
        private System.Windows.Forms.Button bt_Lamp4;
        private System.Windows.Forms.TextBox tb_ModbusServerIP;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_ModbusServerIP;
        private System.Windows.Forms.Label lb_ConnectionStatus;
        private System.Windows.Forms.Label lb_Channel1;
        private System.Windows.Forms.Label lb_Channel2;
        private System.Windows.Forms.Label lb_Channel3;
        private System.Windows.Forms.Label lb_Channel4;
        private System.Windows.Forms.Timer tmr_Modbus_Com;
    }
}

