using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample_E_Commerce
{
    public partial class home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Carrello_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrello.aspx?listaCarrello");
        }
    }
}