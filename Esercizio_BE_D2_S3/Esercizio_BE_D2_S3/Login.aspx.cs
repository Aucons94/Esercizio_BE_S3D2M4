using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio_BE_D2_S3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = true;
            if (IsPostBack)
            {
                Label1.Visible = true;
                Label2.Visible = false;
            }
        }
        protected void Login_page(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Login_cookie");
            cookie.Values["Username"] = Username.Text;
            cookie.Values["Password"] = Password.Text;
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);
            Response.Redirect("ReadCookie");
        }

    }
}