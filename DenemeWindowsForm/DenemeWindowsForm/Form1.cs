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


namespace DenemeWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2QRS8D0\\SQLEXPRESS;Initial Catalog=DENEME;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dENEMEDataSet.kitaplar' table. You can move, or remove it, as needed.
            //  this.kitaplarTableAdapter.Fill(this.dENEMEDataSet.kitaplar);
            kayitGoster();
        }
        private void kayitGoster()
        {
            baglanti.Open();
            string kayit = "select * from kitaplar";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            baglanti.Close();
            MessageBox.Show("Bağlantı Kapatıldı");
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into kitaplar ";
            }
            catch (Exception hata)
            {

                
            }
        }
    }
}
