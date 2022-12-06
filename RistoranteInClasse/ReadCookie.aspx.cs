using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RistoranteInClasse
{
    public partial class ReadCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["DatiUtente"]!=null)
            {
                Label1.Text = Request.Cookies["DatiUtente"]["nominativo"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("DatiUtente");
            c.Expires= DateTime.Now.AddDays(-1);
            Response.Cookies.Add(c);
        }
    }
}