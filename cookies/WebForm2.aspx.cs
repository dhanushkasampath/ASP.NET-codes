using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendData
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["UserInfo"];
            if (c != null)
            {
                lblName.Text = c["name"];
                lblEmail.Text = c["email"];
            }
        }
    }
}