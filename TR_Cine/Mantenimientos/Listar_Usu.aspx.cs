using Capa_Datos;
using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TR_Cine.Mantenimientos
{
    public partial class Listar_Usu : System.Web.UI.Page
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
                cargar_usuarios();
            }
        }

        protected void lnk_nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Nuevo_Usu.aspx");
        }

        private void cargar_usuarios()
        {
            List<tbl_Usuario> listapro = new List<tbl_Usuario>();
            listapro = Usuario_Logica.obtener_Usuarios();
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
            List<tbl_Usuario> listd = new List<tbl_Usuario>();
            tbl_Usuario pro = new tbl_Usuario();
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
                        pro = Capa_Negocios.Usuario_Logica.Obtener_DepaXnombre(txt_buscar.Text);
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
                            cargar_usuarios();
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
                Response.Redirect("~/Mantenimientos/Nuevo_Usu.aspx?cod=" + codigo, true);
            }
            else if (e.CommandName == "Eliminar")
            {
                tbl_Usuario proe = new tbl_Usuario();
                proe = Usuario_Logica.Obtener_UsuXid(codigo);
                if (proe != null)
                {
                    Usuario_Logica.Eliminar(proe);
                    cargar_usuarios();
                }
            }
        }
    }
}