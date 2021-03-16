using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace ModbusTCP
{
    public partial class Form_Modbus : Form
    {
        ModbusClient modbusClient;
        bool[] readCoils;
        bool connection_status = false;

        public Form_Modbus()
        {
            InitializeComponent();
            lb_Status.Text = "Offline";
            lb_Status.ForeColor = Color.Red;

            bt_Lamp1.BackColor = Color.Red;
            bt_Lamp1.Text = "OFF";
            bt_Lamp2.BackColor = Color.Red;
            bt_Lamp2.Text = "OFF";
            bt_Lamp3.BackColor = Color.Red;
            bt_Lamp3.Text = "OFF";
            bt_Lamp4.BackColor = Color.Red;
            bt_Lamp4.Text = "OFF";

            bt_Lamp1.ForeColor = Color.White;
            bt_Lamp2.ForeColor = Color.White;
            bt_Lamp3.ForeColor = Color.White;
            bt_Lamp4.ForeColor = Color.White;
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            if (connection_status == false)
            {
                try
                {
                    modbusClient = new ModbusClient(tb_ModbusServerIP.Text, 502);    //Ip-Address and Port of Modbus-TCP-Server
                    modbusClient.Connect();
                    lb_Status.Text = "Connected!";
                    lb_Status.ForeColor = Color.Green;
                    tmr_Modbus_Com.Enabled = true;
                    connection_status = true;

                    bt_Connect.Enabled = false;
                    bt_Disconnect.Enabled = true;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            if (connection_status == true)
            {
                modbusClient.Disconnect();
                lb_Status.Text = "Offline";
                lb_Status.ForeColor = Color.Red;
                tmr_Modbus_Com.Enabled = false;
                connection_status = false;

                bt_Connect.Enabled = true;
                bt_Disconnect.Enabled = false;
            }
        }


        private void bt_Lamp1_Click(object sender, EventArgs e)
        {
            if (connection_status == true)
            {
                if (readCoils[0] == true)
                {
                    modbusClient.WriteSingleCoil(0, false);
                }
                else
                {
                    modbusClient.WriteSingleCoil(0, true);
                }
            }
        }

        private void bt_Lamp2_Click(object sender, EventArgs e)
        {
            if (connection_status == true)
            {
                if (readCoils[1] == true)
                {
                    modbusClient.WriteSingleCoil(1, false);
                }
                else
                {
                    modbusClient.WriteSingleCoil(1, true);
                }
            }
        }

        private void bt_Lamp3_Click(object sender, EventArgs e)
        {
            if (connection_status == true)
            {
                if (readCoils[2] == true)
                {
                    modbusClient.WriteSingleCoil(2, false);
                }
                else
                {
                    modbusClient.WriteSingleCoil(2, true);
                }
            }
        }

        private void bt_Lamp4_Click(object sender, EventArgs e)
        {
            if (connection_status == true)
            {
                if (readCoils[3] == true)
                {
                    modbusClient.WriteSingleCoil(3, false);
                }
                else
                {
                    modbusClient.WriteSingleCoil(3, true);
                }
            }
        }

        private void tmr_Modbus_Com_Tick(object sender, EventArgs e)
        {
            tmr_Modbus_Com.Enabled = false;
            readCoils = modbusClient.ReadCoils(0, 4);           //Read 4 Coils from Server, starting with address 1
            tmr_Modbus_Com.Enabled = true;

            if (readCoils[0] == true)
            {
                bt_Lamp1.BackColor = Color.Green;
                bt_Lamp1.Text = "ON";
            }
            else
            {
                bt_Lamp1.BackColor = Color.Red;
                bt_Lamp1.Text = "OFF";
            }

            if (readCoils[1] == true)
            {
                bt_Lamp2.BackColor = Color.Green;
                bt_Lamp2.Text = "ON";
            }
            else
            {
                bt_Lamp2.BackColor = Color.Red;
                bt_Lamp2.Text = "OFF";
            }

            if (readCoils[2] == true)
            {
                bt_Lamp3.BackColor = Color.Green;
                bt_Lamp3.Text = "ON";
            }
            else
            {
                bt_Lamp3.BackColor = Color.Red;
                bt_Lamp3.Text = "OFF";
            }

            if (readCoils[3] == true)
            {
                bt_Lamp4.BackColor = Color.Green;
                bt_Lamp4.Text = "ON";
            }
            else
            {
                bt_Lamp4.BackColor = Color.Red;
                bt_Lamp4.Text = "OFF";
            }
        }
    }
}
