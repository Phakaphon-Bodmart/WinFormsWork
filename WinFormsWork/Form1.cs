using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnects.connectNorthwind();

            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("ติอต่อฐานข้อมูลสำเร็จ");
            }
            conn.Close();
        }
    }
}
