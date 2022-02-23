using System;

namespace TR_Cine.Opcion2
{
    public partial class paginaPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnk_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");

        }
    }
}