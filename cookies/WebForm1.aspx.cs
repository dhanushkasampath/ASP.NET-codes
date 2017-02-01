using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendData
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoTo_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("UserInfo");//make a cookie object
            c["name"] = txtName.Text;//add values to it
            c["email"] = txtEmail.Text;

            c.Expires = DateTime.Now.AddDays(5);

            Response.Cookies.Add(c);//cookie object eka client computer eke save kara gannawa
            Response.Redirect("~/WebForm2.aspx");
        }
    }
}