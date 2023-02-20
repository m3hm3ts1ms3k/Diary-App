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
    public partial class about_us : Form
    {
        public about_us()
        {
            InitializeComponent();
        }

        private void about_us_Load(object sender, EventArgs e)
        {
            this.co_name_label1.Text= Application.CompanyName;
            this.product_name_label2.Text = "Yapım Adı: " + Application.ProductName;
            this.version_label3.Text = "Versiyon: " + Application.ProductVersion;
        }
    }
}
