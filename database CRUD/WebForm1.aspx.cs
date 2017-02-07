using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ViewData
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEmployee();
            }
        }
        protected void LoadEmployee()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))//make the connetion object using connection string
            {
                string sqlQuery = "select id,name,gender,depname from tblemployee where id=205";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txtName.Text = rdr["Name"].ToString();
                        txtGender.Text = rdr["Gender"].ToString();
                        txtDepartment.Text = rdr["DepName"].ToString();
                        HiddenField1.Value = rdr["Id"].ToString();
                    }
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {//query ya liwwa
                String sqlQuery = "update tblemployee set name=@name,gender=@gender,depname=@depname where id=@id";
                // dan eka sqlcommand ekata pass karanna ona
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@depname", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@id", HiddenField1.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtName.Text = "";
                txtGender.Text = "";
                txtDepartment.Text = "";


            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {//query ya liwwa
                String sqlQuery = "delete name,gender,depname from tblemployee where id=@id";
                // dan eka sqlcommand ekata pass karanna ona
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtName.Text = "";
                txtGender.Text = "";
                txtDepartment.Text = "";


            }
        }
    }
}