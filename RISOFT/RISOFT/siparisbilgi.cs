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
    public partial class siparisbilgi : Form
    {

        SqlConnection baglanti;
        SqlDataAdapter veri;



        public siparisbilgi()
        {
            InitializeComponent();
        }

        void bilgigetir()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog=RISOFT; Integrated Security=SSPI;");
            baglanti.Open();
            veri = new SqlDataAdapter("SELECT *FROM SiparisDetay", baglanti);
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void satisbilgi_Load(object sender, EventArgs e)
        {
            bilgigetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
