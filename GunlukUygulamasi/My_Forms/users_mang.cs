using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunlukUygulamasi.My_Forms
{
    public partial class users_mang : Form
    {
        public users_mang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //-------------------------------------------------
            if(this.user_name_textBox1.Text=="")
            {
                MessageBox.Show("Kullanıcı Adı Boş!!!");
                return;
                   
            }
            //-------------------------------------------------
            if (this.pass_textBox1.Text != this.pass_confirm_textBox2.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor!!!");
                return;
            }

            //-------------------------------------------------
            GunlukUygulamasi.Properties.Settings.Default.User_name = this.user_name_textBox1.Text;
            GunlukUygulamasi.Properties.Settings.Default.User_pass = this.pass_textBox1.Text;
            GunlukUygulamasi.Properties.Settings.Default.Save();
            //---------------Kullanıcı resmini kaydetme----------
            if (this.openFileDialog1.FileName!="openFileDialog1")
            {
                string fn;
                fn = this.openFileDialog1.FileName;

                //-----
                string df;
                df = Application.StartupPath + "\\data\\user_pic\\1.jpg";
                System.IO.File.Copy(fn, df, true);
            }
           
            //---------------------------------------------------
            MessageBox.Show("Bitti!");
        }

        private void users_mang_Load(object sender, EventArgs e)
        {


            //------------Kullanıcı resmini yükle------------
            user_info_loader();
            //-----------------------------------------------
        }
        public void user_info_loader()
        {
            this.user_name_textBox1.Text = GunlukUygulamasi.Properties.Settings.Default.User_name;
            this.pass_textBox1.Text = GunlukUygulamasi.Properties.Settings.Default.User_pass;
            string df;
            df = Application.StartupPath + "\\data\\user_pic\\1.jpg";
            this.pictureBox1.Load(df);
        }

        private void user_name_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            this.pictureBox1.Load(fn);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
