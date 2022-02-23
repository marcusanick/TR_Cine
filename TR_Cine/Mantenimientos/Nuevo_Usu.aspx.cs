using Capa_Datos;
using Capa_Negocios;
using System;
using System.Collections.Generic;

namespace TR_Cine.Mantenimientos
{
    public partial class Nuevo_Usu : System.Web.UI.Page
    {
        private tbl_Usuario usuarioin = new tbl_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {

                    lnk_modificar.Visible = true;
                    int codigo = Convert.ToInt32(Request["cod"]);
                    usuarioin = Usuario_Logica.Obtener_UsuXid(codigo);
                    if (usuarioin != null)
                    {
                        txt_usu.Text = usuarioin.usu_usuario.ToString();
                        txt_pass.Text = usuarioin.usu_pass.ToString();
                        txt_correo.Text = usuarioin.usu_email.ToString();
                        txt_ced.Text = usuarioin.usu_cedula.ToString();
                        ddl_rol.SelectedValue = usuarioin.rol_id.ToString();
                        txt_nombre.Text = usuarioin.usu_nombre.ToString();
                        txt_apellido.Text = usuarioin.usu_apellido.ToString();
                        txt_direccion.Text = usuarioin.usu_direccion.ToString();
                        txt_cel.Text = usuarioin.usu_cel.ToString();

                        lnk_guardar.Visible = false;
                        lnk_nuevo.Visible = false;
                    }
                }
                cargarRol();

            }
        }

        private void cargarRol()
        {
            List<tbl_Rol> listarol = new List<tbl_Rol>();
            listarol = Capa_Negocios.Rol_Logica.Obtner_roles();
            listarol.Insert(0, new tbl_Rol() { rol_descripcion = "Seleccione" });
            ddl_rol.DataSource = listarol;
            ddl_rol.DataTextField = "rol_descripcion";
            ddl_rol.DataValueField = "rol_id";
            ddl_rol.DataBind();
        }

        protected void lnk_nuevo_Click(object sender, EventArgs e)
        {
            txt_usu.Text = txt_pass.Text = txt_correo.Text = txt_ced.Text =
            ddl_rol.SelectedValue = txt_nombre.Text = txt_apellido.Text =
            txt_direccion.Text = txt_cel.Text = "";
            ddl_rol.ClearSelection();
        }

        protected void lnk_guardar_Click(object sender, EventArgs e)
        {
            if (txt_usu.Text == String.Empty || txt_pass.Text == String.Empty || txt_correo.Text == String.Empty
                    || txt_ced.Text == String.Empty || ddl_rol.SelectedValue == "0" || txt_nombre.Text == String.Empty
                    || txt_apellido.Text == String.Empty || txt_direccion.Text == String.Empty || txt_cel.Text == String.Empty)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Hay campos vacios, por favor llenarlos todos";
            }
            else
            {
                //verificar si existe datos
                bool existe = Usuario_Logica.AutentificarNombre(txt_usu.Text);
                {
                    if (existe)
                    {
                        tbl_Usuario dep = new tbl_Usuario();
                        dep = Usuario_Logica.Obtener_DepaXnombre(txt_usu.Text);
                        if (dep != null)
                        {
                            lbl_mensaje.Visible = true;
                            lbl_mensaje.Text = "Usuario Ya existente";
                        }
                    }
                    else
                    {
                        lbl_mensaje.Visible = false;
                        Guardar_Modificar(Convert.ToInt32(Request["cod"]));
                    }
                }
            }
        }

        private void Guardar_Modificar(int id)
        {
            if (id == 0)
            {
                Guardar();
            }
            else
            {
                usuarioin = Usuario_Logica.Obtener_UsuXid(id);
                if (usuarioin != null)
                {
                    Modificar(usuarioin);
                }
            }
        }

        private void Guardar()
        {
            try
            {
                if (txt_usu.Text==String.Empty || txt_pass.Text==String.Empty || txt_correo.Text==String.Empty
                    || txt_ced.Text==String.Empty || ddl_rol.SelectedValue=="0" || txt_nombre.Text==String.Empty
                    || txt_apellido.Text==String.Empty || txt_direccion.Text==String.Empty || txt_cel.Text==String.Empty)
                {
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = "Hay campos vacios, por favor llenarlos todos";
                }
                else
                {
                    usuarioin = new tbl_Usuario();
                    usuarioin.usu_usuario = txt_usu.Text;
                    usuarioin.usu_pass = txt_pass.Text;
                    usuarioin.usu_email = txt_correo.Text;
                    usuarioin.usu_cedula = txt_ced.Text;
                    usuarioin.rol_id = Convert.ToInt32(ddl_rol.SelectedValue);
                    usuarioin.usu_nombre = txt_nombre.Text;
                    usuarioin.usu_apellido = txt_apellido.Text;
                    usuarioin.usu_direccion = txt_direccion.Text;
                    usuarioin.usu_cel = txt_cel.Text;


                    Usuario_Logica.Guardar(usuarioin);
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = "Los datos han sido guardados";
                    if (lbl_mensaje.Text == "Los datos han sido guardados")
                    {
                        Timer1.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los datos NO han sido guardados" + ex.Message;
                throw;
            }
        }

        protected void lnk_modificar_Click(object sender, EventArgs e)
        {
            Guardar_Modificar(Convert.ToInt32(Request["cod"]));
        }

        private void Modificar(tbl_Usuario usuarioin)
        {
            try
            {
                usuarioin.usu_usuario = txt_usu.Text;

                usuarioin.usu_email = txt_correo.Text;
                usuarioin.usu_cedula = txt_ced.Text;
                usuarioin.rol_id = Convert.ToInt32(ddl_rol.SelectedValue);
                usuarioin.usu_nombre = txt_nombre.Text;
                usuarioin.usu_apellido = txt_apellido.Text;
                usuarioin.usu_direccion = txt_direccion.Text;
                usuarioin.usu_cel = txt_cel.Text;



                Usuario_Logica.Editar(usuarioin);
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los datos han sido modificados";
                if (lbl_mensaje.Text == "Los datos han sido modificados")
                {
                    Timer1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los datos NO han sido modificados" + ex.Message;
                throw;
            }
        }
        protected void lnk_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_Usu.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_Usu.aspx");
        }
    }
}