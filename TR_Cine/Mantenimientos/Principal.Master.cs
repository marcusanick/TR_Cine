using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TR_Cine.Mantenimientos
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                Panel1.Visible = true;
                lblSesion.Text = Session["Admin1"].ToString();

            }
            else if (Session["usu"] != null)
            {
                Panel2.Visible = true;
                lblSesion.Text = Session["Admin1"].ToString();
            }
            else if (Session["gere"] != null)
            {
                Panel2.Visible = true;
                lblSesion.Text = Session["Admin1"].ToString();
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void lnk_salir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/Opcion2/paginaPrincipal.aspx");
        }

        protected void lnk_admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/VistaPrincipal.aspx");
        }

        protected void lnk_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Nuevo_Pel.aspx");
        }

        protected void lnk_listape_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_Pel.aspx");
        }

        protected void lnk_nusu_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Nuevo_Usu.aspx");

        }

        protected void lnk_nlisusu_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_Usu.aspx");

        }

        protected void lnk_ngen_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Nuevo_GenPel.aspx");

        }

        protected void lnk_lisgen_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_GenPel.aspx");

        }

        protected void lnk_ncomb_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Nuevo_Comb.aspx");
        }

        protected void lnk_listcomb_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_Comb.aspx");
        }

        protected void lnk_nprom_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Nuevo_Promo.aspx");

        }

        protected void lnk_listprom_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_promo.aspx");

        }
    }
}