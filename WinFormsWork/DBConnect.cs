using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsWork
{
    public partial class DBConnect : Form
    {
        public DBConnect()
        {
            InitializeComponent();
        }
    }
    internal class DBConnects
    {
        public static SqlConnection connectNorthwind()
        {
            string server = "LAPTOP-2K9R1N5F\\SQLEXPRESS";
            string db = "Northwind";

            string conStr = string.Format(@"Data Source={0}; Initial catalog={1}; 
                    Integrated Security=True; Encrypt=False;", server, db);

            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();

            return conn;
        }
    }
}
