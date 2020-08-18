using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Asset_Management
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


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void prompt1(object sender, EventArgs e)
        {

        }

        private void DepEN(object sender, EventArgs e)
        {

        }

        private void UserNEN(object sender, EventArgs e)
        {
            String UIserN;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Jaynets;Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Login WHERE username='" + Nameef.Text + "' AND password='" + Passf.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                

                PNmae.Show();
                PNmaef.Show();
                PBrand.Show();
                PBrandf.Show();
                PType.Show();
                PTypef.Show();
                PManufacture.Show();
                PManufacturef.Show();
                PWarrant.Show();
                PWarrantf.Show();
                PCondition.Show();
                PConditionF.Show();
                Back.Show();

                SqlCommand cmd = new SqlCommand("sp_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", PNmaef.Text);
                cmd.Parameters.AddWithValue("@eBrand", PBrandf.Text);
                cmd.Parameters.AddWithValue("@Type", PTypef.Text);
                cmd.Parameters.AddWithValue("@Manufacture", PManufacturef.Text);
                con.Open();
               

                con.Close();




                greeting.Hide();
                    prompt.Hide();
                    dpt.Hide();
                    Deptf.Hide();
                    Passf.Hide();
                    Nameef.Hide();
                    Uname.Hide();
                    pwd.Hide();
                    Login.Hide();
                    linkLabel1.Hide();

                
            }


            else
            {
                Nameef.Clear();
                Passf.Clear();
                Deptf.Clear();
                err.Show();

            }
        }





            private void pictureBox2_Click_1(object sender, EventArgs e)
            {

            }

            private void Con(object sender, LinkLabelLinkClickedEventArgs e)
            {



            }

            private void com1(object sender, EventArgs e)
            {

            }

            private void Dep(object sender, EventArgs e)
            {

            }

            private void UserN(object sender, EventArgs e)
            {

            }

            private void Pass(object sender, EventArgs e)
            {

            }

            private void PassEn(object sender, EventArgs e)
            {

            }



            private void PName(object sender, EventArgs e)
            {

            }

            private void label11_Click(object sender, EventArgs e)
            {

            }

            private void label10_Click(object sender, EventArgs e)
            {

            }

            private void PNmae_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click_1(object sender, EventArgs e)
            {

            }

            private void PManufacture_Click(object sender, EventArgs e)
            {

            }

        private void err_Click(object sender, EventArgs e)
        {

        }
    }
    }



