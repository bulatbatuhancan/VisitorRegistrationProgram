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

namespace ZiyaretciDefteri
{
    public partial class Form2 : Form

        
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            string query = "select * from KullanıcıBilgileri where KullanıcıAdı=@KullanıcıAdı AND Sifre=@Sifre";

            string DByolu = "Server=BULAT;Database=ZiyaretciDefter;Uid=sa;Password=12;";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@KullanıcıAdı", txtKullanıcı.Text);
            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız");

                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola Hatalı");
            }
            con.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
