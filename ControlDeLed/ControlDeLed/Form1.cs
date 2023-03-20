using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeLed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                button_OFF.Enabled = false;
                serialPort1.PortName = "COM6";
                serialPort1.Open();
            } 
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message); 
                }
            }
        }
        private void button_OFF_Click(object sender, EventArgs e)
        {
            try
            {
                //Enviar código al Arduino
                serialPort1.WriteLine("$Off");
                label_Led.BackColor = Color.Red;
                label_Led.Text = "OFF";
                button_OFF.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            try
            {
                //Enviar código al Arduino
                serialPort1.WriteLine("$On");
                label_Led.BackColor = Color.Lime;
                label_Led.Text = "ON";
                button_OFF.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
