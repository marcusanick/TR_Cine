using Capa_Datos;
using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;

namespace TR_Cine.Mantenimientos
{
    public partial class Listar_Pel : System.Web.UI.Page
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
                cargar_peliculas();
            }

        }

        private void cargar_peliculas()
        {
            List<tbl_Pelicula> listapro = new List<tbl_Pelicula>();
            listapro = Pelicula_Logica.Obtner_peliculas();
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
            Response.Redirect("~/Mantenimientos/Nuevo_Pel.aspx");
        }

        protected void img_lupa_Click(object sender, ImageClickEventArgs e)
        {
            List<tbl_Pelicula> listd = new List<tbl_Pelicula>();
            tbl_Pelicula pro = new tbl_Pelicula();
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
                        pro = Pelicula_Logica.Obtener_perXnombre(txt_buscar.Text);
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
                            cargar_peliculas();
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
                Response.Redirect("~/Mantenimientos/Nuevo_Pel.aspx?cod=" + codigo, true);
            }
            else if (e.CommandName == "Eliminar")
            {
                tbl_Pelicula proe = new tbl_Pelicula();
                proe = Pelicula_Logica.Obtner_perXId(codigo);
                if (proe != null)
                {
                    Pelicula_Logica.Eliminar(proe);
                    cargar_peliculas();
                }
            }
        }
    }
}