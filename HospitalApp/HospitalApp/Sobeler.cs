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
    public partial class Sobeler : Form
    {
        public Sobeler()
        {
            InitializeComponent();
        }

        private void Sobeler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var box2 = textBox2.Text;
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into dbo.sobe (Name) values ('" + box2 + "')";
            command.Connection = Baglanti;

            Baglanti.Open();
            SqlDataReader rdr = command.ExecuteReader();
            Baglanti.Close();

            SqlCommand commanda = new SqlCommand();
            commanda.CommandText = "Select * from dbo.sobe ";
            commanda.Connection = Baglanti;
            Baglanti.Open();


            SqlDataReader rdra = commanda.ExecuteReader();
            listBox1.Items.Clear();
            while (rdra.Read())
            {
          
                string adia = rdra["Name"].ToString();
                listBox1.Items.Add(string.Format("{0}", adia));
            }
            Baglanti.Close();
           
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
            SqlCommand commands = new SqlCommand();
            commands.CommandText = "delete from dbo.Sobe where (  name = '" + listBox1.Text + "')";
            commands.Connection = Baglanti;

            Baglanti.Open();
            SqlDataReader rdr = commands.ExecuteReader();
            Baglanti.Close();

            SqlCommand commandq = new SqlCommand();
            commandq.CommandText = "Select * from dbo.Sobe ";
            commandq.Connection = Baglanti;
            Baglanti.Open();


            SqlDataReader rdra = commandq.ExecuteReader();
            listBox1.Items.Clear();
            while (rdra.Read())
            {

                string adia = rdra["Name"].ToString();
                listBox1.Items.Add(string.Format("{0}", adia));
            }
            Baglanti.Close();


            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sobeler.ActiveForm.Hide();
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Baglanti1 = new SqlConnection();
            Baglanti1.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
            SqlCommand commandw = new SqlCommand();

            commandw.CommandText = "insert into dbo.doctor2 (Name) values (  '" + textBox1.Text + "')";
            commandw.Connection = Baglanti1;

            Baglanti1.Open();
            SqlDataReader rdrs = commandw.ExecuteReader();
            Baglanti1.Close();


            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
            SqlCommand command = new SqlCommand();

            command.CommandText = "insert into dbo.Doctor (Name) values (  '" + listBox1.SelectedItem + " " + "\t" + textBox1.Text + "')";
            command.Connection = Baglanti;

            Baglanti.Open();
            SqlDataReader rdr = command.ExecuteReader();
            Baglanti.Close();

            SqlCommand commanda = new SqlCommand();
            commanda.CommandText = "Select * from dbo.Doctor ";
            commanda.Connection = Baglanti;
            Baglanti.Open();


            SqlDataReader rdra = commanda.ExecuteReader();
            listBox2.Items.Clear();
            while (rdra.Read())
            {

                string adia = rdra["Name"].ToString();
                listBox2.Items.Add(string.Format("{0}", adia));
            }
            Baglanti.Close();

            //listBox2.Items.Add(listBox1.SelectedItem + "\t" +textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = "Server = NIZAMI;Database=Hospital;User=sa;PWd=123456789;";
            SqlCommand commands = new SqlCommand();
            commands.CommandText = "delete from dbo.Doctor where (  name = '" + listBox2.Text + "')";
            commands.Connection = Baglanti;

            Baglanti.Open();
            SqlDataReader rdr = commands.ExecuteReader();
            Baglanti.Close();

            SqlCommand commandq = new SqlCommand();
            commandq.CommandText = "Select * from dbo.Doctor ";
            commandq.Connection = Baglanti;
            Baglanti.Open();


            SqlDataReader rdra = commandq.ExecuteReader();
            listBox2.Items.Clear();
            while (rdra.Read())
            {

                string adia = rdra["Name"].ToString();
                listBox2.Items.Add(string.Format("{0}", adia));
            }
            Baglanti.Close();

            //listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
