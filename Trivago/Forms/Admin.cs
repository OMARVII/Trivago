﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Runtime.InteropServices;


namespace Trivago.Forms
{
    public partial class Admin : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           );
        OracleConnection conn;
        string connST = "Data Source=orcl;User Id=HR;Password=ALAAalaa21;";
        string deletedID="";
        public Admin()
        {

            InitializeComponent();
            conn = new OracleConnection(connST);
            conn.Open();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            view();

           

        }
        void view()
        {
            id.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from Users where is_admin!='t' order by id ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id.Items.Add(dr[0]);
            }
            dr.Close();
        }
        Boolean multiple()
        {
            if (deletedID == "") deletedID = id.SelectedItem.ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Users where is_admin='t' and id=:userid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("userid", deletedID);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("User is already an admin!");
                return true;
            }
            return false;
        }
        Boolean validate()
        {
            if (id.SelectedIndex == -1)
            {
                MessageBox.Show("Choose an id");
                return true;
            }
            return false;
        }
            private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
          
            
        }

        private void id_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select email, gender, date_of_birth, first_name, last_name, mobile from Users where id=:userid ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("userid", id.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                email.Text = dr["email"].ToString();
                gender.Text = dr["gender"].ToString();
                DateTime dt = DateTime.Parse(dr["date_of_birth"].ToString());
                dateofbirth.Text = dt.ToString("dd/MM/yyyy");
                first.Text = dr["first_name"].ToString();
                second.Text = dr["last_name"].ToString();
                mobile.Text = dr["mobile"].ToString();
            }
           









        }

        private void second_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (validate()) return;
            if (multiple()) return;
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update users set is_admin = 't' where id=:userid";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("userid", id.SelectedItem.ToString());
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("This user is an admin now !");
                    deletedID = id.SelectedItem.ToString();
                    view();
                }
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void websiteoffer_Click(object sender, EventArgs e)
        {
            makewebsiteForm a = new makewebsiteForm();
            conn.Close();
            a.Show();
            this.Hide();
            
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            viewForm a = new viewForm();
            conn.Close();
            a.Show();
            this.Hide();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addForm a = new addForm();
            conn.Close();
            a.Show();
            this.Hide();

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            editForm a = new editForm();
            conn.Close();
            a.Show();
            this.Hide();

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            delForm a = new delForm();
            conn.Close();
            a.Show();
            this.Hide();

        }

    }
}
