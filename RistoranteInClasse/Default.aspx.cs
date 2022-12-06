using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RistoranteInClasse
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RiepilogoConto.Visible= false;

            if (!IsPostBack)
            {
                foreach (Menu m in Menu.GetMenu())
                {
                    ListItem l = new ListItem(m.NomePiatto, m.Id.ToString());
                    ElencoPizze.Items.Add(l);
                }
            }
        }

        protected void AggiungiPiatto_Click(object sender, EventArgs e)
        {
            int piattoScelto = Convert.ToInt32(ElencoPizze.SelectedValue);

            foreach (Menu m in Menu.GetMenu())
            {
                if (m.Id == piattoScelto)
                {
                    string aggiunzioni = "";
                    decimal CostoAggiunzioni = 0;

                    foreach(ListItem agg in CheckBoxListAggiunzioni.Items)
                    {
                        if (agg.Selected)
                        {
                            aggiunzioni += $"+ {agg.Text} ";
                            CostoAggiunzioni += Convert.ToInt32(agg.Value);
                        }
                    }

                    Menu piatto = new Menu() { NomePiatto= $"{m.NomePiatto} {aggiunzioni}", 
                                               CostoPiatto=m.CostoPiatto+CostoAggiunzioni };
                    Menu.ListaMenuOrdinato.Add(piatto);

                    //check a false tutte le checkbox aggiunzioni
                    foreach (ListItem item in CheckBoxListAggiunzioni.Items)
                    {
                        item.Selected= false;
                    }
                }
            }
        }

        protected void CalcolaConto_Click(object sender, EventArgs e)
        {
            decimal Totale = 0;

            foreach (Menu m in Menu.ListaMenuOrdinato)
            {
                ElencoOrdinazioni.Text += $"{m.NomePiatto} : <b>{m.CostoPiatto.ToString("c2")} </b></br>";
                Totale += m.CostoPiatto;
            }
            TotaleConto.Text = $"Totale a pagare {Totale.ToString("c2")}";
            RiepilogoConto.Visible = true;
        }
    }

    public class Menu
    {
        public int Id { get; set; }
        public string NomePiatto { get; set; }
        public decimal CostoPiatto { get; set; }

        public static List<Menu> ListaMenuOrdinato = new List<Menu>();
        public static List<Menu> GetMenu()
        {
            List<Menu> list = new List<Menu>();

            Menu piatto1 = new Menu { Id = 1, NomePiatto = "Margherita", CostoPiatto = 10.00m };
            Menu piatto2 = new Menu { Id = 2, NomePiatto = "Romana", CostoPiatto = 12.00m };
            Menu piatto3 = new Menu { Id = 3, NomePiatto = "Diavola", CostoPiatto = 10.00m };
            Menu piatto4 = new Menu { Id = 4, NomePiatto = "4 Formaggi", CostoPiatto = 10.00m };
            Menu piatto5 = new Menu { Id = 5, NomePiatto = "Pizza fritta", CostoPiatto = 10.00m };
            Menu piatto6 = new Menu { Id = 6, NomePiatto = "Vegetariana", CostoPiatto = 10.00m };
            Menu piatto7 = new Menu { Id = 7, NomePiatto = "Marinara", CostoPiatto = 10.00m };
            Menu piatto8 = new Menu { Id = 8, NomePiatto = "Napoli", CostoPiatto = 10.00m };
            Menu piatto9 = new Menu { Id = 9, NomePiatto = "Capricciosa", CostoPiatto = 10.00m };
            Menu piatto10 = new Menu { Id = 10, NomePiatto = "4 Stagioni", CostoPiatto = 10.00m };

            list.Add(piatto1);
            list.Add(piatto2);
            list.Add(piatto3);
            list.Add(piatto4);
            list.Add(piatto5);
            list.Add(piatto6);
            list.Add(piatto7);
            list.Add(piatto8);
            list.Add(piatto9);
            list.Add(piatto10);
            return list;
        }
    }
}