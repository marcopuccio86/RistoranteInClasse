using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RistoranteInClasse
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("DatiUtente");
            cookie.Values["nominativo"] = "marcopuccio";
            cookie.Values["Indirizzo"] = "Via Diomede 4";
            //cookie.Expires = DateTime.Now.AddDays(60);
            Response.Cookies.Add(cookie);
        }
    }
}