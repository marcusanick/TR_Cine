﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocios;

namespace TR_Cine.Mantenimientos
{
    public partial class Nuevo_Pel : System.Web.UI.Page
    {
        private tbl_Pelicula usuarioin = new tbl_Pelicula();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {

                    lnk_modificar.Visible = true;
                    int codigo = Convert.ToInt32(Request["cod"]);
                    usuarioin = Pelicula_Logica.Obtner_perXId(codigo);
                    if (usuarioin != null)
                    {
                        txt_titulo.Text = usuarioin.pel_Titulo.ToString();
                        txt_idioma.Text = usuarioin.pel_Idioma.ToString();
                        ddl_gen.SelectedValue = usuarioin.gen_id.ToString();
                       // img_s.ImageUrl= usuarioin.gen_id.ToString();
                        txt_sinop.Text = usuarioin.pel_sinopsis.ToString();
                        txt_url.Text = usuarioin.pel_url.ToString();
                        lnk_guardar.Visible = false;
                        lnk_nuevo.Visible = false;
                    }
                }
                cargarGenero();
               
            }
        }

        private void cargarGenero()
        {
            List<tbl_Genero> listarper = new List<tbl_Genero>();
            listarper = Capa_Negocios.Genero_Logica.Obtner_generos();
            listarper.Insert(0, new tbl_Genero() { gen_descripcion = "Seleccione" });
            ddl_gen.DataSource = listarper;
            ddl_gen.DataTextField = "gen_descripcion";
            ddl_gen.DataValueField = "gen_id";
            ddl_gen.DataBind();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("~/Mantenimientos/Listar_Pel.aspx");
        }

        protected void lnk_nuevo_Click(object sender, EventArgs e)
        {
            Nuev_Pelicula();
        }

        private void Nuev_Pelicula()
        {
            txt_idioma.Text = txt_sinop.Text = txt_titulo.Text = txt_url.Text = "";
           
            ddl_gen.ClearSelection();
        }

        protected void lnk_guardar_Click(object sender, EventArgs e)
        {
            //verificar si existe datos
            bool existe = Usuario_Logica.AutentificarNombre(txt_titulo.Text);
            {
                if (existe)
                {
                    tbl_Pelicula dep = new tbl_Pelicula();
                    dep = Pelicula_Logica.Obtener_perXnombre(txt_titulo.Text);
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
                usuarioin = Pelicula_Logica.Obtner_perXId(id);
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
                usuarioin = new tbl_Pelicula();
                usuarioin.pel_Titulo = txt_titulo.Text;
                usuarioin.pel_Idioma = txt_idioma.Text;
            //    usuarioin.pel_img = img_s.ImageAlig;
                usuarioin.pel_sinopsis = txt_sinop.Text;
                usuarioin.pel_url = txt_url.Text;

                usuarioin.gen_id = Convert.ToInt32(ddl_gen.SelectedValue);

                Pelicula_Logica.Guardar(usuarioin);
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
        private void Modificar(tbl_Pelicula usuarioin)
        {
            try
            {
                usuarioin.pel_Titulo = txt_titulo.Text;
                usuarioin.pel_Idioma = txt_idioma.Text;
                usuarioin.pel_sinopsis = txt_sinop.Text;
                usuarioin.pel_url = txt_url.Text;
                
                usuarioin.gen_id = Convert.ToInt32(ddl_gen.SelectedValue);

                Pelicula_Logica.Editar(usuarioin);
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
            Response.Redirect("~/Mantenimientos/Listar_Pel.aspx");
        }
    }
}