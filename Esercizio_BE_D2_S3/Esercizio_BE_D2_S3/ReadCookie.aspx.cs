using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio_BE_D2_S3
{
    public partial class ReadCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Login_cookie"] != null)
            {
                DatiUtente.InnerText = "Username: " + Request.Cookies["Login_cookie"]["Username"] + " Password: " + Request.Cookies["Login_cookie"]["Password"];
            }
            else
            {
                Response.Redirect("Login");
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Login_cookie");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
        }
    }
}