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

namespace HospitalApp
{
    public partial class Finsh : Form
    {
        public Finsh()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Finsh_Load(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
            SqlCommand commanda = new SqlCommand();
            commanda.CommandText = "Select * from dbo.Finsh ";
            commanda.Connection = Baglanti;
            Baglanti.Open();


            SqlDataReader rdra = commanda.ExecuteReader();
            textBox1.Clear();
            while (rdra.Read())
            {

                string adia = rdra["Name"].ToString();
                textBox1.Text = (string.Format("{0}", adia));
            }
            Baglanti.Close();
        }
    }
}
