using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Finger_ATM
{
    public partial class ViewResult : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=FingerVote;Integrated Security=True"); 
        
        public ViewResult()
        {
            InitializeComponent();
        }

        private void ViewResult_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from election where Result <> 'N/A' ",con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;

            DataGridViewColumn c1 = dataGridView1.Columns[0];
            c1.HeaderText = "Election ID";
            c1.Width = 110;
            DataGridViewColumn c2 = dataGridView1.Columns[1];
            c2.Width = 325;
            c2.HeaderText = "Election Topic";
            DataGridViewColumn c3 = dataGridView1.Columns[2];
            c3.HeaderText = "No Of Candidate";
            c3.Width = 100;
            c3.Visible = false;
            DataGridViewColumn c4 = dataGridView1.Columns[3];
            c4.HeaderText = "Candidate 1";
            c4.Width = 130;
            DataGridViewColumn c5 = dataGridView1.Columns[4];
            c5.HeaderText = "Candidate 2";
            c5.Width = 130;
            DataGridViewColumn c6 = dataGridView1.Columns[5];
            c6.Width = 130;
            c6.HeaderText = "Candidate 3";
            DataGridViewColumn c7 = dataGridView1.Columns[6];
            c7.Width = 130;
            c7.HeaderText = "Candidate 4";
            DataGridViewColumn c8 = dataGridView1.Columns[7];
            c8.Width = 120;
            c8.HeaderText = "End Date";
            DataGridViewColumn c9 = dataGridView1.Columns[8];
            c9.Width = 130;
            c9.HeaderText = "Winner";
        }
    }
}
