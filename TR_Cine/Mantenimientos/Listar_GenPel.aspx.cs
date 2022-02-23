using Capa_Datos;
using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TR_Cine.Mantenimientos
{
    public partial class Listar_GenPel : System.Web.UI.Page
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
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            if (!IsPostBack)
            {
                cargar_generos();
            }
        }

        private void cargar_generos()
        {
            List<tbl_Genero> listapro = new List<tbl_Genero>();
            listapro = Genero_Logica.Obtner_generos();
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
            Timer1.Enabled = true;
        }

        protected void img_lupa_Click(object sender, ImageClickEventArgs e)
        {
            List<tbl_Genero> listd = new List<tbl_Genero>();
            tbl_Genero pro = new tbl_Genero();
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
                        pro = Genero_Logica.Obtener_GenXnombre(txt_buscar.Text);
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
                            cargar_generos();
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
                Response.Redirect("~/Mantenimientos/Nuevo_GenPel.aspx?cod=" + codigo, true);
            }
            else if (e.CommandName == "Eliminar")
            {
                tbl_Genero proe = new tbl_Genero();
                proe = Genero_Logica.Obtner_genXId(codigo);
                if (proe != null)
                {
                    Genero_Logica.Eliminar(proe);
                    cargar_generos();
                }
            }
        }

        protected void lnk_nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Nuevo_GenPel.aspx");
        }
    }
}