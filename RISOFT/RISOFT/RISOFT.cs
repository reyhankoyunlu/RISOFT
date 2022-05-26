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
    public partial class RISOFT : Form
    {
        public RISOFT()
        {
            InitializeComponent();
        }

        private void btn_calisan_Click(object sender, EventArgs e)
        {
            calisanbilgisi calisanbilgisi = new calisanbilgisi();
            calisanbilgisi.ShowDialog();
        }

        private void btn_urun_Click(object sender, EventArgs e)
        {
            urunbilgisi urunbilgisi = new urunbilgisi();
            urunbilgisi.ShowDialog();
        }

        private void btn_siparis_Click(object sender, EventArgs e)
        {
            siparisbilgi satisbilgi = new siparisbilgi();
            satisbilgi.ShowDialog();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            musteribilgisi musteribilgisi = new musteribilgisi();
            musteribilgisi.ShowDialog();
        }

        private void RISOFT_Load(object sender, EventArgs e)
        {
            
        }
    }
}
