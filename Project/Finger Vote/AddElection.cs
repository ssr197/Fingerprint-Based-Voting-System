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
    public partial class AddElection : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=FingerVote;Integrated Security=True"); 
        
        public AddElection()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            SqlCommand cmd = new SqlCommand("Insert into Election Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox5.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','"+date+"','N/A')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Election Registred Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            id();
        }

        private void AddElection_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Name From Candidate",con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int cou = ds.Tables[0].Rows.Count;
            for (int i = 0; i < cou; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                comboBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                comboBox3.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                comboBox4.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;
                comboBox5.SelectedIndex = 0;
            }

            id();
        }

        public void id()
        {
            string com = "select top 1 EId From Election ORDER BY EId Desc;";
            con.Open();
            SqlCommand cmd = new SqlCommand(com, con);
            object count = cmd.ExecuteScalar();
            if (count != null)
            {
                int i = Convert.ToInt32(count);
                i++;
                textBox1.Text = i.ToString();
            }
            else
            {
                textBox1.Text = "1001";
            }
            con.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "2")
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox3.Text = "N/A";
                comboBox4.Text = "N/A";
            }
            else if (comboBox5.Text == "3")
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = false;
                comboBox4.Text = "N/A";
                comboBox3.Text = "--Select--";
            }
            else if (comboBox5.Text == "4")
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox3.Text = "--Select--";
                comboBox4.Text = "--Select--";
            }
        }
    }
}
