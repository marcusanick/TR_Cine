using Capa_Datos;
using Capa_Negocios;
using System;

namespace TR_Cine.Mantenimientos
{
    public partial class Nuevo_GenPel : System.Web.UI.Page
    {
        private tbl_Genero rolin = new tbl_Genero();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {

                    lnk_modificar.Visible = true;
                    int codigo = Convert.ToInt32(Request["cod"]);
                    rolin = Genero_Logica.Obtner_genXId(codigo);
                    if (rolin != null)
                    {
                        txt_gen.Text = rolin.gen_descripcion.ToString();
                        lnk_guardar.Visible = false;
                        lnk_nuevo.Visible = false;
                    }
                }

            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_GenPel.aspx");

        }

        protected void lnk_nuevo_Click(object sender, EventArgs e)
        {
            Nuev_Genero();
        }

        private void Nuev_Genero()
        {
            txt_gen.Text = "";
        }

        protected void lnk_modificar_Click(object sender, EventArgs e)
        {
            Guardar_Modificar(Convert.ToInt32(Request["cod"]));
        }
        private void Modificar(tbl_Genero rolin)
        {
            try
            {
                rolin.gen_descripcion = txt_gen.Text;


                Genero_Logica.Editar(rolin);
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
        protected void lnk_guardar_Click(object sender, EventArgs e)
        {
            if (txt_gen.Text==String.Empty)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Hay campos vacios";
            }
            else
            {
                //verificar si existe datos
                bool existe = Genero_Logica.autentificar_gen(txt_gen.Text);
                {
                    if (existe)
                    {
                        tbl_Genero dep = new tbl_Genero();
                        dep = Genero_Logica.Obtener_GenXnombre(txt_gen.Text);
                        if (dep != null)
                        {
                            lbl_mensaje.Visible = true;
                            lbl_mensaje.Text = "Genero Ya existente";
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

        private void Guardar()
        {
            try
            {
                rolin = new tbl_Genero();
                rolin.gen_descripcion = txt_gen.Text;


                Genero_Logica.Guardar(rolin);
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los datos han sido guardados";
                if (lbl_mensaje.Text == "Los datos han sido guardados")
                {
                    Timer1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los datos NO han sido guardados" + ex.Message;
                throw;
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
                rolin = Genero_Logica.Obtner_genXId(id);
                if (rolin != null)
                {
                    Modificar(rolin);
                }
            }
        }

        protected void lnk_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_GenPel.aspx");
        }
    }
}