using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RistoranteInClasse
{
    public partial class ElencoPizze : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach(Menu m in Menu.GetMenu())
            {
                ElencoPizzeQueryString.Text += $"<a href='Pizza.aspx?idpizza={m.Id}'>{m.NomePiatto}</br>";
            }
        }
    }
}