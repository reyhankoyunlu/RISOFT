using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RISOFT
{
    public partial class urunbilgisi : Form
    {

        SqlConnection urun;
        SqlCommand uruncom;
        SqlDataAdapter urundata;
        

        public urunbilgisi()
        {
            InitializeComponent();
        }

        void urungetir()
        {
            urun = new SqlConnection("server=.;Initial Catalog=RISOFT; Integrated Security=SSPI");
            urun.Open();
            urundata = new SqlDataAdapter("select * from Urunler", urun);
            DataTable tablo = new DataTable();
            urundata.Fill(tablo);
            dataGridView1.DataSource = tablo;
            urun.Close();
        }

        private void urunbilgisi_Load(object sender, EventArgs e)
        {
            urungetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu="insert into Urunler(UrunAdi,Fiyat,StokAdet) VALUES (@UrunAdi,@Fiyat,@StokAdet)";
            uruncom = new SqlCommand(sorgu, urun);
            uruncom.Parameters.AddWithValue("@UrunAdi", txturunad.Text);
            uruncom.Parameters.AddWithValue("@Fiyat", txturunfiyat.Text);
            uruncom.Parameters.AddWithValue("@StokAdet", txturunstok.Text);
            urun.Open();
            uruncom.ExecuteNonQuery();
            urun.Close();
            urungetir();
        }

        private void txturunstok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar>=47&&(int)e.KeyChar<=58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz.","RISOFT",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txturunfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar>=47&&(int)e.KeyChar<=58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz.","RISOFT",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Urunler SET UrunAdi=@UrunAdi,StokAdet=@StokAdet,Fiyat=@Fiyat WHERE UrunID=@UrunID";
            uruncom = new SqlCommand(sorgu, urun);
            uruncom.Parameters.AddWithValue("@UrunID", Convert.ToInt32(txturunıd.Text));
            uruncom.Parameters.AddWithValue("@UrunAdi", txturunad.Text);
            uruncom.Parameters.AddWithValue("@StokAdet", txturunstok.Text);
            uruncom.Parameters.AddWithValue("@Fiyat", txturunfiyat.Text);
            urun.Open();
            uruncom.ExecuteNonQuery();
            urun.Close();
            urungetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txturunıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txturunad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txturunstok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txturunfiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }


        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?","RISOFT",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (sonuc==DialogResult.Yes)
            {
                string sorgu = "delete from Urunler where UrunID=@UrunID";
                uruncom = new SqlCommand(sorgu, urun);
                uruncom.Parameters.AddWithValue("UrunID", Convert.ToInt32(txturunıd.Text));
                urun.Open();
                uruncom.ExecuteNonQuery();
                urun.Close();
                urungetir();
                MessageBox.Show("Kayıt silme işlemi başarılı","RISOFT",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt silme işlemi iptal edildi","RISOFT",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txturunstok_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
