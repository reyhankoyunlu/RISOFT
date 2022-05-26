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
    public partial class musteribilgisi : Form
    {

        SqlConnection musteri;
        SqlDataAdapter musteridata;

        public musteribilgisi()
        {
            InitializeComponent();
        }

        void musterigetir()
        {
            musteri = new SqlConnection("server=.;Initial Catalog=RISOFT;Integrated Security=SSPI");
            musteri.Open();
            musteridata = new SqlDataAdapter("select * from Musteriler", musteri);
            DataTable tablo = new DataTable();
            musteridata.Fill(tablo);
            dataGridView1.DataSource = tablo;
            musteri.Close();
        }

        private void musteribilgisi_Load(object sender, EventArgs e)
        {
            musterigetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
