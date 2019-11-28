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
    public partial class ViewCandidate : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=FingerVote;Integrated Security=True");
        
        public ViewCandidate()
        {
            InitializeComponent();
        }

        string cname = "";
        public ViewCandidate(string cname1)
        {
            InitializeComponent();
            cname = cname1;
        }

        private void ViewCandidate_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Candidate where Name ='"+cname+"'",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            textBox1.Text = cname;
            pictureBox2.ImageLocation = dr[2].ToString();
            textBox2.Text = dr[3].ToString();
            con.Close();
        }
    }
}
