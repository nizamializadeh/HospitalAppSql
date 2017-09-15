using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.ActiveForm.Hide();
            Form1 fr3 = new Form1();
            fr3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login.ActiveForm.Hide();
            qeydiyat fr3 = new qeydiyat();
            fr3.Show();
        }
    }
}
