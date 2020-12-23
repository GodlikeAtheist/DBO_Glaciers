using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public string[,] matrix;
        public Form1()
        {
            InitializeComponent();
            H.conStr = "server = 193.93.216.145; CharacterSet = cp1251; user = sqlkns20_3_uja; database = sqlkns20_3_uja; password = kns20_uja;";

            DataTable dt = H.myDT("SELECT * FROM myUsers");
            int count = dt.Rows.Count;
            matrix = new string [count, 4];
            for(int i = 0; i < count; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("User_ID").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("User_name").ToString();
                matrix[i, 2] = dt.Rows[i].Field<int>("User_type").ToString();
                matrix[i, 3] = dt.Rows[i].Field<string>("User_password").ToString();
                comboBox1.Items.Add(matrix[i, 1]);
            }
            //comboBox1.Text = matrix[0, 1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = H.EncryptedPassword(textBox1.Text);
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                if(String.Equals(comboBox1.Text, matrix[i,1]))
                    if(String.Equals(textBox1.Text, matrix[i,3]))
                    {
                        H.typeUser = matrix[i, 2];
                        this.Hide();
                        DataBase f0 = new DataBase();
                        f0.ShowDialog();
                    }
                else
                    {
                        MessageBox.Show("Invalid password!");
                    }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    static class H
    {
        public static string conStr { get; set; }
        public static string typeUser { get; set; }
        public static BindingSource bs1 { get; set; }
        public static DataTable myDT(string sqlStr)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(H.conStr))
            {
                MySqlCommand com = new MySqlCommand(sqlStr, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }

        public static string EncryptedPassword(string s)
        {
            if (string.Compare(s, "null", true) == 0)
            {
                return "NULL";
            }
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider cSP = new MD5CryptoServiceProvider();
            byte[] byteHash = cSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }
    }
}
