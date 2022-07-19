using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Parking_plac
{
    public partial class Form1 : Form
    {
        public SerialPort data { set; get; }

        public Form1()
        {
            InitializeComponent();
            data = new SerialPort();
            data.BaudRate = 9600;
            data.PortName = "COM3";
            timer1.Interval = 8000;
            timer1.Start();
            
            brVozila.Text = "9";
        }

        private void Open_Click(object sender, EventArgs e)
        {
            data.Open();
            data.WriteLine("O");
            data.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            data.Open();
            data.WriteLine("C");
            data.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             //brVozila.Text = data.ReadLine();  
        }
    }
}
