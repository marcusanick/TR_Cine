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

        

        protected void lnk_home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }

        

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
        private void limpiar()
        {
            txt_user.Text = txt_pass.Text = txt_nombre.Text = txt_cel.Text = txtdireccion.Text = txt_mail.Text
                = txt_apellido.Text = txt_user.Text = "";
            
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
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

                usuario.usu_nombre = txt_nombre.Text;
                usuario.usu_pass = txt_pass.Text;
                usuario.usu_email = txt_mail.Text;
                usuario.usu_usuario = txt_user.Text;
                usuario.usu_apellido = txt_apellido.Text;
                usuario.usu_cedula = txt_cedula.Text;
                usuario.usu_direccion = txtdireccion.Text;
                usuario.usu_cel = txt_cel.Text;

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
    }
}