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
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {

            if (Request.Cookies != null)
            {
                Request.Cookies["Utente"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(Request.Cookies["Utente"]);
                Response.Redirect("Default.aspx");

            }
            

        }
    }
}