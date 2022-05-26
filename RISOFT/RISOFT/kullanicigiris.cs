using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RISOFT
{
    public partial class kullanicigiris : Form
    {
        public kullanicigiris()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text=="reyhan"&&txtsifre.Text=="123")
            {
                RISOFT RISOFT = new RISOFT();
                RISOFT.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.Lütfen geçerli bir değer giriniz.","RISOFT",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtsifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtsifre.UseSystemPasswordChar = true;
            }
        }
    }
}
