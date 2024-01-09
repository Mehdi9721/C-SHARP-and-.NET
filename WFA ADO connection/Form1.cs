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
using System.Configuration;
using MySql.Data.MySqlClient;
namespace learningExceptionsInWFA
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection CN = new MySqlConnection("Server=localhost;Database=test;User Id=root;Password=8052608851;"))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {

                    try
                    {
                        CN.Open();
                        CMD.Connection = CN;
                       // CMD.CommandType = CommandType.StoredProcedure;
                         CMD.CommandText = "select * from t1 where name=\"ali\" ";
                      MySqlDataReader DR = CMD.ExecuteReader();
                        DR.Read();
                        string name = Convert.ToString(DR["sal"]);
                        MessageBox.Show("connection "+ name);
                        Console.WriteLine("ok");
                        CN.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                       
                    }
                    {

                    }
                }
            }


                }

        private void label1_Click(object sender, EventArgs e)
        {
            string h = Convert.ToString(e);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
