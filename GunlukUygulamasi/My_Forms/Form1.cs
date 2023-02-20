using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunlukUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Projenin daha stabil çalışması için Try Structure

            try
            {
                //-----------------------------------------------
                GunlukUygulamasi.My_Forms.login_form lg_form = new My_Forms.login_form();
                lg_form.ShowDialog();
                //-----------------------------------------------

                get_time();
                this.version_label2.Text = Application.ProductVersion;

                //arkaplan resmini yükle
                Int32 si;
                si = GunlukUygulamasi.Properties.Settings.Default.selected_back_image_index;

                back_image_loader(si);

                background_combo_loader();
                this.back_comboBox1.SelectedIndex = si;

                //müzik yükle
                music_combo_loader();
                Int32 sm;
                sm = GunlukUygulamasi.Properties.Settings.Default.selected_music_index;
                this.music_comboBox1.SelectedIndex = sm;


                //-------------Kullanıcı Bilgilerini Yükleme---------------
                user_info_loader();
                //---------------------------------------------------------
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







        public void background_combo_loader()
        {

            Int32 i;

            for (i = 1; i <= 8; i++)
            {
                this.back_comboBox1.Items.Add("Resim " +i.ToString());
            }
        }


        public void music_combo_loader()
        {

            Int32 i;

            for (i = 1; i <= 2; i++)
            {
                this.music_comboBox1.Items.Add("Müzik " + i.ToString());
            }
        }








        public void back_image_loader(Int32 combo_index)
        {
            string fn;
            //combo index 0dan başladığı için 1 eklemeliyim. Resimler 1 den başlıyor.
            combo_index = combo_index + 1;
            fn = Application.StartupPath + "\\data\\pics\\"+ combo_index.ToString() + ".jpg";
            this.BackgroundImage = Image.FromFile(fn);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak ister misin?", "Çık", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            get_time();
        }

        public void get_time()
        {
            this.timer_label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void back_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si = selected index. seçilen index
            Int32 si;
            si = this.back_comboBox1.SelectedIndex;

            back_image_loader(si);
            //seçilmiş resim indexini kaydetme
            GunlukUygulamasi.Properties.Settings.Default.selected_back_image_index = this.back_comboBox1.SelectedIndex;
            GunlukUygulamasi.Properties.Settings.Default.Save();
            //seçilmiş resim indexini kaydetme
        }

        private void music_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void music_loader(Int32 combo_index)
        {
            string fn;
            //combo index 0dan başladığı için 1 eklemeliyim. müzikler 1 den başlıyor.
            combo_index = combo_index + 1;
            fn = Application.StartupPath + "\\data\\music\\" + combo_index.ToString() + ".mp3";
            this.axWindowsMediaPlayer1.URL = fn;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            music_loader(this.music_comboBox1.SelectedIndex);
            GunlukUygulamasi.Properties.Settings.Default.selected_music_index= this.music_comboBox1.SelectedIndex;
            GunlukUygulamasi.Properties.Settings.Default.Save();

        }

        private void hakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunlukUygulamasi.My_Forms.about_us ab_form = new GunlukUygulamasi.My_Forms.about_us();
            ab_form.MdiParent = this;
            ab_form.Show();

        }

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunlukUygulamasi.My_Forms.users_mang us_form =new My_Forms.users_mang();
            us_form.MdiParent = this;
            us_form.Show();
        }

        private void lockApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------
            GunlukUygulamasi.My_Forms.login_form lg_form = new My_Forms.login_form();
            lg_form.ShowDialog();
            //-----------------------------------------------
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GunlukUygulamasi.My_Forms.memo_form mf;
            mf= new My_Forms.memo_form();
            mf.MdiParent = this;
            mf.Show();



        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GunlukUygulamasi.My_Forms.search_memo sf = new My_Forms.search_memo();
            sf.MdiParent = this;
            sf.Show();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Kısayol Tuşları
            //------------------------------
            if (e.KeyCode == Keys.F2)
            {
                toolStripButton1_Click(sender, e);
            }
            //------------------------------

            //------------------------------
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton2_Click(sender, e);
            }
            //------------------------------
            //------------------------------
            if (e.KeyCode == Keys.F4)
            {
                this.sett_toolStripButton3.ShowDropDown();
            }
            //------------------------------
            //------------------------------
            if (e.KeyCode == Keys.F5)
            {
                this.tools_toolStripButton4.ShowDropDown();
            }
            //------------------------------
            //------------------------------
            if (e.KeyCode == Keys.F6)
            {
                this.about_toolStripButton5.ShowDropDown();
            }
            //------------------------------

            if(e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }



        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            GunlukUygulamasi.My_Forms.timer t;
            t = new My_Forms.timer();
            t.MdiParent = this;
            t.Show();

        }
    }
}
