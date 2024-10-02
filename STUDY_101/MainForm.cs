using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace STUDY_101
{
    public partial class MainForm : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public MainForm()
        {
            alamat = "server=localhost; database=database_study101; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("select * from tbl_user where user_name = '{0}'", textBoxusername.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        sandi = kolom["password_password"].ToString();
                        if (sandi == textBoxpassword.Text)
                        {
                            MainForm frmMain = new MainForm();
                            frmMain.Show();
                        }
                        else
                        {
                            MessageBox.Show("Anda salah input password");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
