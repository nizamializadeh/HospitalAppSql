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
    public partial class qeydiyat : Form
    {
        public qeydiyat()
        {
            InitializeComponent();
        }

        private void qeydiyat_Load(object sender, EventArgs e)
        {
            comboBox1.Hide();
            comboBox2.Hide();
            comboBox3.Hide();
            comboBox4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
            button1.Hide();
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
            SqlCommand commandq = new SqlCommand();
            commandq.CommandText = "Select * from dbo.Sobe ";
            commandq.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader rdra = commandq.ExecuteReader();
            while (rdra.Read())
            {

                string adia = rdra["Name"].ToString();
                comboBox1.Items.Add(string.Format("{0}", adia));
            }
            Baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("stamatologiya"))
            {
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
                SqlCommand commandq = new SqlCommand();
                commandq.CommandText = "Select * from dbo.doctor2 ";
                commandq.Connection = Baglanti;
                Baglanti.Open();
                SqlDataReader rdra = commandq.ExecuteReader();
                while (rdra.Read())
                {

                    string adia = rdra["Name"].ToString();
                    comboBox2.Items.Add(string.Format("{0}", adia));
                }
                Baglanti.Close();
                comboBox2.Show();
            }
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == comboBox2.Items.IndexOf("Dr.Oktay Samilov"))
            {
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
                SqlCommand commandq = new SqlCommand();
                commandq.CommandText = "Select * from dbo.day ";
                commandq.Connection = Baglanti;
                Baglanti.Open();
                SqlDataReader rdra = commandq.ExecuteReader();
                while (rdra.Read())
                {

                    string adia = rdra["Name"].ToString();
                    comboBox3.Items.Add(string.Format("{0}", adia));
                }
                Baglanti.Close();
                comboBox3.Show();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == comboBox3.Items.IndexOf("1-ci gun"))
            {
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
                SqlCommand commandq = new SqlCommand();
                commandq.CommandText = "Select * from dbo.novbe ";
                commandq.Connection = Baglanti;
                Baglanti.Open();
                SqlDataReader rdra = commandq.ExecuteReader();
                while (rdra.Read())
                {

                    string adia = rdra["Name"].ToString();
                    comboBox4.Items.Add(string.Format("{0}", adia));
                }
                Baglanti.Close();
                comboBox4.Show();
                //label1.Show();
                //label2.Show();
                //label3.Show();

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into dbo.Finsh (Name) values (  '" + comboBox4.SelectedItem + " secildi  " + "')";
            command.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader rdr = command.ExecuteReader();
            Baglanti.Close();

            Form1.ActiveForm.Hide();
            Finsh fr2 = new Finsh();
            fr2.Show();
        }
    }
}
