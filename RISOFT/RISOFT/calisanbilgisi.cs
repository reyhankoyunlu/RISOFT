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
    public partial class calisanbilgisi : Form
    {

        SqlConnection personel;
        SqlDataAdapter personeldata;
        SqlCommand personelcom;

        public calisanbilgisi()
        {
            InitializeComponent();
        }

        void personelgetir()
        {
            personel = new SqlConnection("server=.;Initial Catalog=RISOFT; Integrated Security=SSPI");
            personel.Open();
            personeldata = new SqlDataAdapter("select * from Personeller", personel);
            DataTable tablo = new DataTable();
            personeldata.Fill(tablo);
            dataGridView1.DataSource = tablo;
            personel.Close();
        }

        private void calisanbilgisi_Load(object sender, EventArgs e)
        {
            personelgetir();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnpersonekle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Personeller(PersonelAdi,PersonelSoyadi,TCNo,CalistigiBolum,TelNo,DogumTarihi,Maas,Cinsiyet,Adres)values(@PersonelAdi,@PersonelSoyadi,@TCNo,@CalistigiBolum,@TelNo,@DogumTarihi,@Maas,@Cinsiyet,@Adres)";
            personelcom = new SqlCommand(sorgu, personel);
            personelcom.Parameters.AddWithValue("@PersonelAdi", txtpersoneladi.Text);
            personelcom.Parameters.AddWithValue("@PersonelSoyadi", txtpersonelsoyadi.Text);
            personelcom.Parameters.AddWithValue("@TCNo", txtpersoneltc.Text);
            personelcom.Parameters.AddWithValue("@CalistigiBolum", txtdepartman.Text);
            personelcom.Parameters.AddWithValue("@TelNo", mtxttel.Text);
            personelcom.Parameters.AddWithValue("@DogumTarihi", mtxtdogum.Text);
            personelcom.Parameters.AddWithValue("@Maas", txtmaas.Text);
            personelcom.Parameters.AddWithValue("@Adres", txtadres.Text);

            string cinsiyet="";
                if (rdbtnerkek.Checked)
            {
                cinsiyet = rdbtnerkek.Text;
            }
            else
            {
                cinsiyet = rdbtnkadin.Text;    
            }
            personelcom.Parameters.AddWithValue("@Cinsiyet", cinsiyet);

            personel.Open();
            personelcom.ExecuteNonQuery();
            personel.Close();
            personelgetir();
        }

        private void txtpersoneltc_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Lütfen bir rakam giriniz","RISOFT",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Handled = true;

            }
        }

        private void btnpersonguncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE  Personeller SET PersonelAdi=@PersonelAdi,PersonelSoyadi=@PersonelSoyadi,TCNo=@TCNo,CalistigiBolum=@CalistigiBolum,TelNo=@TelNo,DogumTarihi=@DogumTarihi,Maas=@Maas where PersonelID=@PersonelID";
            personelcom = new SqlCommand(sorgu, personel);
            personelcom.Parameters.AddWithValue("@PersonelID", Convert.ToInt32(txtpersonelıd.Text));
            personelcom.Parameters.AddWithValue("@PersonelAdi", txtpersoneladi.Text);
            personelcom.Parameters.AddWithValue("@PersonelSoyadi", txtpersonelsoyadi.Text);
            personelcom.Parameters.AddWithValue("@TCNo", txtpersoneltc.Text);
            personelcom.Parameters.AddWithValue("@CalistigiBolum", txtdepartman.Text);
            personelcom.Parameters.AddWithValue("@TelNo", mtxttel.Text);
            personelcom.Parameters.AddWithValue("@DogumTarihi", mtxtdogum.Text);
            personelcom.Parameters.AddWithValue("@Maas", txtmaas.Text);
            personelcom.Parameters.AddWithValue("@Adres", txtadres.Text);
            personel.Open();
            personelcom.ExecuteNonQuery();
            personel.Close();
            personelgetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtpersonelıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtpersoneladi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtpersonelsoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtpersoneltc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtdepartman.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            mtxttel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mtxtdogum.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmaas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnpersonsil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?","RISOFT",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (sonuc==DialogResult.Yes)
            {
                string sorgu = "delete from Personeller where PersonelID=@PersonelID";
                personelcom = new SqlCommand(sorgu, personel);
                personelcom.Parameters.AddWithValue("PersonelID", Convert.ToInt32(txtpersonelıd.Text));
                personel.Open();
                personelcom.ExecuteNonQuery();
                personel.Close();
                personelgetir();
                MessageBox.Show("Kayıt silme işlemi başarılı","RISOFT",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt silme işlemi iptal edildi","RISOFT",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
