using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWork
{
    public partial class FormProductByPrice : Form
    {
        public FormProductByPrice()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnects.connectNorthwind();

            string startPrice = txtStart.Text;
            string endPrice = txtEnd.Text;

            string query = string.Format("select * from Products where UnitPrice between {0} and {1}", startPrice, endPrice);

            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;

            conn.Close();
        }
    }
}
