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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İyi Günler!!!");
            Application.Exit();
        }

        private void login_form_Load(object sender, EventArgs e)
        {

            try
            {
                user_info_loader();
            }
            catch (Exception ex)
            {
                comm_class.my_err_msg(ex.ToString());

            }
            
        }
        public void user_info_loader()
        {
            this.user_name_label5.Text = GunlukUygulamasi.Properties.Settings.Default.User_name;
            string df;
            df = Application.StartupPath + "\\data\\user_pic\\1.jpg";
            this.user_pictureBox1.Load(df);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //-------------------------------------------------
                if (this.pass_textBox1.Text == "")
                {
                    MessageBox.Show("Şifre Boş!!!");
                    return;

                }
                //-------------------------------------------------



                if (this.pass_textBox1.Text == GunlukUygulamasi.Properties.Settings.Default.User_pass)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Şifreler eşleşmiyor. Lütfen tekrar deneyin!");
                }
            }
            catch (Exception ex)
            {
                comm_class.my_err_msg(ex.ToString());

            }

           
        }
    }
}
