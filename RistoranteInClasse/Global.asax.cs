using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace RistoranteInClasse
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //Ambito di visibilità a livello di applicazione e quindi visibile ad ogni utente
            Application["UtentiOnLine"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["UtentiOnLine"] = Convert.ToInt32(Application["UtentiOnLine"]) + 1;
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["UtentiOnLine"] = Convert.ToInt32(Application["UtentiOnLine"]) - 1;
        }
    }
}