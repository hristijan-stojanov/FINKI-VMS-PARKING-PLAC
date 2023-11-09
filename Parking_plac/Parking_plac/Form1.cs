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
        public List<Podatoci> ListCar { set; get; }
        public String st { set; get; }
        public Form1()
        {
            InitializeComponent();
            ListCar = new List<Podatoci>();
            data = new SerialPort();
            data.BaudRate = 9600;
            data.PortName = "COM3";
            data.DataReceived += DataReceivedHandler;
            data.Open();
            timer1.Interval = 100;
            timer1.Start();
            
            
        }

        private void Open_Click(object sender, EventArgs e)
        {
          
            data.WriteLine("O");
           
        }

        private void close_Click(object sender, EventArgs e)
        {
           
            data.WriteLine("C");
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
            string s = data.ReadExisting();
           
          //  Console.WriteLine(s);
            Podatoci p = new Podatoci(s, DateTime.Now);
            ListCar.Add(p);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(p.id);
            Console.WriteLine(p.time);

        }
        public static int GetDifferenceInMinutes(DateTime start, DateTime end)
        {
            TimeSpan diff = end - start;
            return (int)diff.TotalMinutes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = Code.Text;
            foreach(Podatoci p  in ListCar)
            {
                if(p.id.Equals(str))
                {
                    int min = GetDifferenceInMinutes(p.time, DateTime.Now);
                    Console.WriteLine(min);
                    Cena.Text = (((min / 60) * 40) + 40).ToString() + " den.";
                  
                }
               
            }
        }
    }
}
