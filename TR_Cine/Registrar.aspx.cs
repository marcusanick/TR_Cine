using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocios;
using System.Drawing;

namespace TR_Cine
{
    public partial class Registrar : System.Web.UI.Page

    {
        private tbl_Usuario usuario = new tbl_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                
                Timer1.Enabled = false;

            }
        }

        protected void lnk_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {

        }

        protected void lnk_home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }

        protected void btn_registrar_Click1(object sender, EventArgs e)
        {
            try
            {
                //if (ddl_rol.SelectedValue == "0")
                //{
                //    //mensaje de alerta para el rol 
                //    string alerta = "alert ('Seleccione un Rol')";
                //    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", alerta, true);
                //}
                lbl_mensaje.Text = "";
                usuario = new tbl_Usuario();

                usuario.usu_email = txt_correo.Text;
                usuario.usu_pass = txt_password.Text;
                usuario.usu_usuario = txt_user.Text;
                
                Usuario_Logica.Guardar(usuario);
                lbl_mensaje.ForeColor = Color.Green;
                lbl_mensaje.Text = "Los datos han sido Almacenados";
                limpiar();
                Timer1.Enabled = true;


            }
            catch (Exception ex)
            {
                lbl_mensaje.ForeColor = Color.DarkRed;
                lbl_mensaje.Text = "Los datos  NO han sido Almacenados";
                throw;
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
        private void limpiar()
        {
            txt_correo.Text = txt_password.Text = txt_user.Text = "";
            
        }
    }
}