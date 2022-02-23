using Capa_Datos;
using Capa_Negocios;
using System;

namespace TR_Cine.Mantenimientos
{

    public partial class Nuevo_Promo : System.Web.UI.Page
    {
        private tbl_promocion usuarioin = new tbl_promocion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {

                    lnk_modificar.Visible = true;
                    int codigo = Convert.ToInt32(Request["cod"]);
                    usuarioin = Promocion_Logica.Obtner_proXId(codigo);
                    if (usuarioin != null)
                    {
                        txt_descripcion.Text = usuarioin.pro_descripcion.ToString();

                        lnk_guardar.Visible = false;
                        lnk_nuevo.Visible = false;
                    }
                }


            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_promo.aspx");
        }

        protected void lnk_nuevo_Click(object sender, EventArgs e)
        {
            Nuev_Promo();
        }
        private void Nuev_Promo()
        {
            txt_descripcion.Text = "";


        }

        protected void lnk_guardar_Click(object sender, EventArgs e)
        {
            //verificar si existe datos
            bool existe = Promocion_Logica.autentificar_pro(txt_descripcion.Text);
            {
                if (existe)
                {
                    tbl_promocion dep = new tbl_promocion();
                    dep = Promocion_Logica.Obtener_perXnombre(txt_descripcion.Text);
                    if (dep != null)
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "Producto Ya existente";
                    }
                }
                else
                {
                    lbl_mensaje.Visible = false;
                    Guardar_Modificar(Convert.ToInt32(Request["cod"]));
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
                usuarioin = Promocion_Logica.Obtner_proXId(id);
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
                usuarioin = new tbl_promocion();
                usuarioin.pro_descripcion = txt_descripcion.Text;
                //usuarioin.pel_Idioma = txt_idioma.Text;
                //    usuarioin.pel_img = img_s.ImageAlig;


                Promocion_Logica.Guardar(usuarioin);
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


        protected void lnk_modificar_Click(object sender, EventArgs e)
        {
            Guardar_Modificar(Convert.ToInt32(Request["cod"]));
        }

        private void Modificar(tbl_promocion usuarioin)
        {
            try
            {
                usuarioin.pro_descripcion = txt_descripcion.Text;



                Promocion_Logica.Editar(usuarioin);
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
            Response.Redirect("~/Mantenimientos/Listar_promo.aspx");
        }
    }
}