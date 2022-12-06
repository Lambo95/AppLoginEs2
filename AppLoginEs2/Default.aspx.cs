using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppLoginEs2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Utente");
            cookie.Values["UserName"] =txtUsername.Text;
            cookie.Values["Password"] = txtPassword.Text;
            Response.Cookies.Add(cookie);
        }
    }
}