using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample_E_Commerce
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            
            foreach (Prodotto p in Prodotto.GetProdotto())
            {
                if(id == p.Id.ToString()) {
                    Image1.ImageUrl = p.Immagine;
                    Nome.Text = p.NomeProdotto;
                    Descrizione.Text = p.Descrizione;
                }
            }

        }
    }
}