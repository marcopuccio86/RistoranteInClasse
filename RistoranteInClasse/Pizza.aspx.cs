using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RistoranteInClasse
{
    public partial class Pizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["idPizza"];

            foreach (Menu m in Menu.GetMenu())
            {
                if (m.Id.ToString() == id)
                {
                    lblNomePizza.Text = m.NomePiatto;
                    lblPrezzoPizza.Text = m.CostoPiatto.ToString("c2");
                }
            }
        }
    }
}