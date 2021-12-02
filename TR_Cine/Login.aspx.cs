using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocios;
using System.Data.Linq;
using System.Drawing;

namespace TR_Cine
{
    public partial class Login : System.Web.UI.Page
    {
        int contador = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            Session["Ini"] = Session["Inic"];
        }

        protected void lnk_olvido_Click(object sender, EventArgs e)
        {
            btn_ingresar.Visible = false;
            txt_password.Visible = false;
            //Label2.Visible = false;
            btn_desbloquear.Visible = true;
            lnk_registrar.Visible = false;
            lnk_olvido.Visible = false;
            lnk_regresar.Visible = true;
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            ingressar();
        }

        private void ingressar()
        {
            if (string.IsNullOrEmpty(txt_correo.Text))
            {
                lbl_mensaje.Text = "Ingrese su Correo";
                lbl_mensaje.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(txt_password.Text))
            {
                lbl_mensaje.Text = "Ingrese su  Contrasenia";
                lbl_mensaje.ForeColor = Color.Red;
            }
            else
            {
                //metodo para verificar el ingreso al sistema
                bool existencianom = Usuario_Logica.AutentificarxCorreo(txt_correo.Text);
                bool existenciausu = Usuario_Logica.Autentificar(txt_correo.Text, txt_password.Text);
                {
                    if (existencianom)
                    {
                        lbl_mensaje.Text = "";
                        if (existenciausu)
                        {

                            tbl_Usuario usuari = new tbl_Usuario();
                            usuari = Usuario_Logica.autentificarXnLogin(txt_correo.Text, txt_password.Text);
                            int tusu = Convert.ToInt32(usuari.rol_id);
                            if (tusu == 1)
                            {
                                Session["Admin"] = usuari.tbl_Rol.rol_descripcion.ToString();

                                Response.Redirect("/Agregarimg.aspx");
                            }
                            if (tusu == 2)
                            {
                                Session["Usuario"] = usuari;

                                //Response.Redirect("/Us.aspx");
                            }
                        }
                        else
                        {
                            lbl_mensaje.ForeColor = Color.OrangeRed;


                            lbl_mensaje.Text = "Datos Incorrectos";
                            lbl_mensaje.ForeColor = Color.OrangeRed;
                            lbl_intentos.Visible = true;
                            lbl_conteo.Visible = true;
                            lbl_conteo.Text = (contador + (Convert.ToInt32(Session["Ini"]))).ToString();
                            Session["Inic"] = lbl_conteo.Text.ToString();
                            if (Convert.ToInt32(lbl_conteo.Text) == 3)
                            {
                                btn_ingresar.Visible = false;
                                txt_password.Visible = false;
                                
                                btn_desbloquear.Visible = true;
                                lnk_registrar.Visible = false;
                                lnk_olvido.Visible = false;
                                lnk_regresar.Visible = true;
                                Session.RemoveAll();
                            }
                            return;
                        }
                    }
                    else
                    {
                        lbl_mensaje.ForeColor = Color.Red;
                        lbl_mensaje.Text = "!Usuario no Existe en la base de Datos";
                        return;
                    }

                }
            }
        }

        protected void btn_desbloquear_Click(object sender, EventArgs e)
        {
            olvido();
        }
        protected void olvido()
        {
            tbl_Usuario usu = new tbl_Usuario();
            if (string.IsNullOrEmpty(txt_correo.Text))
            {
                lbl_mensaje.ForeColor = Color.Red;
                lbl_mensaje.Text = "Ingrese su correo para recuperar su Cuenta ";
                return;
            }

            bool buscarExistencia = Capa_Negocios.Usuario_Logica.AutentificarNombre(txt_correo.Text);
            {
                if (buscarExistencia)
                {
                    usu = Capa_Negocios.Usuario_Logica.autentificarXcorreo(txt_correo.Text);

                    string from = "marck121998@yahoo.com";//correo del admin
                    string pass = "mgxshspevmzwynkh";//contrase //skaekzsxwaoddtee
                    string to = usu.usu_email;
                    string asunto = "Recuperacion de cuenta";
                    string mensaje = "Su contrase;a olvidad es :" + usu.usu_pass;

                    if (new Mail().Enviar(from, pass, asunto, to, mensaje))
                    {
                        lbl_mensaje.ForeColor = Color.PaleGreen;
                        lbl_mensaje.Text = "Correo Enviado";
                    }
                    else
                    {
                        lbl_mensaje.ForeColor = Color.PaleGreen;
                        lbl_mensaje.Text = "Correo No Enviado";
                    }
                }
                else
                {
                    lbl_mensaje.ForeColor = Color.DarkRed;
                    lbl_mensaje.Text = "el nombre de usuario  no existe  ";
                    return;
                }
            }
        }

        protected void lnk_regresar_Click(object sender, EventArgs e)
        {
            btn_ingresar.Visible = true;
            txt_password.Visible = true;
            //Label2.Visible = true;
            btn_desbloquear.Visible = false;
            lnk_registrar.Visible = true;
            lnk_olvido.Visible = true;
            lnk_regresar.Visible = false;
        }

        protected void lnk_home_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Index.aspx");
        }

        protected void lnk_registrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Registrar.aspx");
        }
    }
}