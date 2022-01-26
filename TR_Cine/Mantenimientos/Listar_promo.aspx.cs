using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocios;

namespace TR_Cine.Mantenimientos
{
    public partial class Listar_promo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                lbl_nombre.Text = Session["Admin"].ToString();
            }
            else if (Session["usu"] != null)
            {
                lbl_nombre.Text = Session["usu"].ToString();
            }
            else if (Session["gere"] != null)
            {
                lbl_nombre.Text = Session["gere"].ToString();
            }

            else
            {
                Response.Redirect("~/Login.aspx");
            }
            if (!IsPostBack)
            {
                cargar_promo();
            }
        }

        private void cargar_promo()
        {
            List<tbl_promocion> listapro = new List<tbl_promocion>();
            listapro = Promocion_Logica.Obtner_promociones();
            if (listapro != null)
            {
                grv_pro.DataSource = listapro;
                grv_pro.DataBind();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_mensajes.Visible = false;
            lbl_mensajes.Text = "";
            Timer1.Enabled = false;
        }

        protected void lnk_nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Nuevo_Promo.aspx");
        }

        protected void img_lupa_Click(object sender, ImageClickEventArgs e)
        {
            List<tbl_promocion> listd = new List<tbl_promocion>();
            tbl_promocion pro = new tbl_promocion();
            string op = ddl_criterio.SelectedValue;
            if (op != "0")
            {
                switch (op)
                {
                    case "S":
                        Timer1.Enabled = true;
                        lbl_mensajes.Visible = true;
                        lbl_mensajes.Text = "Elija un metodo de busqueda";
                        break;
                    case "N":
                        pro = Promocion_Logica.Obtener_perXnombre(txt_buscar.Text);
                        if (pro != null)
                        {
                            listd.Add(pro);
                            grv_pro.DataSource = listd;
                            grv_pro.DataBind();
                        }
                        else
                        {
                            Timer1.Enabled = true;
                            lbl_mensajes.Visible = true;
                            lbl_mensajes.Text = "No hay datos ";
                            cargar_promo();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        protected void grv_pro_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Mantenimientos/Nuevo_Promo.aspx?cod=" + codigo, true);
            }
            else if (e.CommandName == "Eliminar")
            {
                tbl_promocion proe = new tbl_promocion();
                proe = Promocion_Logica.Obtner_proXId(codigo);
                if (proe != null)
                {
                    Promocion_Logica.Eliminar(proe);
                    cargar_promo();
                }
            }
        }
    }
}