using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GunlukUygulamasi.My_Forms
{
    public partial class timer : Form
    {
        public timer()
        {
            InitializeComponent();
        }
        string zaman;
        string tarih;
        private void timer_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH.mm.ss";
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("dd.MM.yyyy");
            label4.Text = DateTime.Now.ToString("HH.mm.ss");
            System.Media.SoundPlayer ses= new System.Media.SoundPlayer();
            ses.SoundLocation = "Alarm.wav";


            if(tarih== label3.Text && zaman ==label4.Text)
            {
                timer1.Stop();
                ses.Play();
                MessageBox.Show(textBox1.Text);
                timer1.Start();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarih = dateTimePicker1.Text;
            zaman= dateTimePicker2.Text;
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses= new System.Media.SoundPlayer();
            ses.SoundLocation = "Alarm.wav";
            ses.Stop();

        }
    }
}
