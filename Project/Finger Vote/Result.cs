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
    public partial class Result : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=FingerVote;Integrated Security=True");
        
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            SqlDataAdapter da = new SqlDataAdapter("Select EId from Election where EndDate < '" + date + "' And Result ='N/A'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                comboBox5.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Election where EId = '" + comboBox5.Text + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            textBox3.Text = dr[1].ToString();
            string cou = dr[2].ToString();
            int count = Convert.ToInt32(cou);

            string[] names = new string[count];
            int[] vote = new int[count];

            if (cou == "2")
            {
                textBox1.Text = dr[3].ToString();
                textBox2.Text = dr[4].ToString();
                textBox4.Text = "N/A";
                textBox5.Text = "N/A";
                names[0] = textBox1.Text;
                names[1] = textBox2.Text;
                con.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Vote where EID = '"+comboBox5.Text+"' And EC1 ='1' ", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                vote[0] = ds.Tables[0].Rows.Count;

                da = new SqlDataAdapter("Select * from Vote where EID = '" + comboBox5.Text + "' And EC2 ='1' ", con);
                ds = new DataSet();
                da.Fill(ds);
                vote[1] = ds.Tables[0].Rows.Count;
            }
            else if (cou == "3")
            {
                textBox1.Text = dr[3].ToString();
                textBox2.Text = dr[4].ToString();
                textBox4.Text = dr[5].ToString();
                textBox5.Text = "N/A";
                names[0] = textBox1.Text;
                names[1] = textBox2.Text;
                names[2] = textBox4.Text;
                con.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Vote where EID = '" + comboBox5.Text + "' And EC1 ='1' ", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                vote[0] = ds.Tables[0].Rows.Count;

                da = new SqlDataAdapter("Select * from Vote where EID = '" + comboBox5.Text + "' And EC2 ='1' ", con);
                ds = new DataSet();
                da.Fill(ds);
                vote[1] = ds.Tables[0].Rows.Count;

                da = new SqlDataAdapter("Select * from Vote where EID = '" + comboBox5.Text + "' And EC3 ='1' ", con);
                ds = new DataSet();
                da.Fill(ds);
                vote[2] = ds.Tables[0].Rows.Count;
            }
            else if (cou == "4")
            {
                textBox1.Text = dr[3].ToString();
                textBox2.Text = dr[4].ToString();
                textBox4.Text = dr[5].ToString();
                textBox5.Text = dr[6].ToString();
                names[0] = textBox1.Text;
                names[1] = textBox2.Text;
                names[2] = textBox4.Text;
                names[3] = textBox5.Text;
                con.Close();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Vote where EID = '" + comboBox5.Text + "' And EC1 ='1' ", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                vote[0] = ds.Tables[0].Rows.Count;

                da = new SqlDataAdapter("Select * from Vote where EID = '" + comboBox5.Text + "' And EC2 ='1' ", con);
                ds = new DataSet();
                da.Fill(ds);
                vote[1] = ds.Tables[0].Rows.Count;

                da = new SqlDataAdapter("Select * from Vote where EID = '" + comboBox5.Text + "' And EC3 ='1' ", con);
                ds = new DataSet();
                da.Fill(ds);
                vote[2] = ds.Tables[0].Rows.Count;

                da = new SqlDataAdapter("Select * from Vote where EID = '" + comboBox5.Text + "' And EC4 ='1' ", con);
                ds = new DataSet();
                da.Fill(ds);
                vote[3] = ds.Tables[0].Rows.Count;
            }

            int maxValue = vote.Max();
            int maxIndex = vote.ToList().IndexOf(maxValue);

            textBox9.Text = names[maxIndex];
            textBox8.Text = ""+maxValue;

            cmd = new SqlCommand("Update Election set Result = '"+textBox9.Text+"-"+textBox8.Text+"' where EId = '"+comboBox5.Text+"'",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
