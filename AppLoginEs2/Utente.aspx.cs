using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppLoginEs2
{
    public partial class Utente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Utente"]!= null)
            {
                txtUtente.Text =$"Benvenuto {Request.Cookies["Utente"]["Username"]}!";
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("DeleteUtente")
            {
                Expires = DateTime.Now.AddDays(-1)
            };
            Response.Cookies.Add(c);

        }
    }
}