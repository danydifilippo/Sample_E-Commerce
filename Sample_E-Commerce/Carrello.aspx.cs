using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample_E_Commerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridCarrello.DataSource = Prodotto.listaCarrello;
            GridCarrello.DataBind();
            lblTotCarrello.Text = $"{Prodotto.TotCarrello.ToString("c2")}";
            
        }
    }
}