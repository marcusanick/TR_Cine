using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TR_Cine
{
    public partial class Eternals : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                Cargar_Ciudad();
                cargar_eternos();
            }
        }
        
        private void Cargar_Ciudad()
        {
            List<tbl_Ciudad> ListaCiudad = new List<tbl_Ciudad>();
            ListaCiudad = Capa_Negocios.Ciudad_Logica.getallCiudad();
            if (ListaCiudad != null && ListaCiudad.Count > 0)
            {
                ListaCiudad.Insert(0, new tbl_Ciudad { ciu_id = 0, ciu_descripcion = "Ciudad:" });
                ddl_Ciudad.DataSource = ListaCiudad;
                ddl_Ciudad.DataTextField = "ciu_descripcion";
                ddl_Ciudad.DataValueField = "ciu_id";
                ddl_Ciudad.DataBind();
            }
        }

        private void cargar_eternos()
        {
            int eternos = 1;
            tbl_Pelicula pelicula = new tbl_Pelicula();
            pelicula = Capa_Negocios.Pelicula_Logica.Obtner_perXId(eternos);
            if (pelicula != null)
            {
                lbl_pelicula.Text = pelicula.pel_titulo;
                lbl_idioma.Text = pelicula.pel_idioma;
                lbl_genero.Text = pelicula.tbl_Genero.gen_descripcion;
                lbl_estado.Text = Convert.ToString(pelicula.pel_estado);
                lbl_sinopsis.Text = pelicula.pel_sinopsis;
            }
        }

        private void Cargar_Sucursal(int Codigo_Ciudad)
        {
            try
            {                
                    List<tbl_Sucursal> listaSucursal = new List<tbl_Sucursal>();
                    listaSucursal = Capa_Negocios.Sucursal_Logica.getallSucursalXCiudad(Codigo_Ciudad);
                    if (listaSucursal != null && listaSucursal.Count > 0)
                    {
                        listaSucursal.Insert(0, new tbl_Sucursal { suc_id = 0, suc_descripcion = "Sucursal:" });
                        ddl_sucursal.DataSource = listaSucursal;
                        ddl_sucursal.DataTextField = "suc_descripcion";
                        ddl_sucursal.DataValueField = "suc_id";
                        ddl_sucursal.DataBind();
                    }
                
            }catch (Exception)
            {
                throw;
            }
        }

        private void Cargar_Hora(int Codigo_Sucursal)
        {
            try
            {
                List<tbl_Hora> listahora = new List<tbl_Hora>();
                listahora = Capa_Negocios.Hora_Logica.getallHoraXSucursalXEternals(Codigo_Sucursal);
                if (listahora != null && listahora.Count > 0)
                {
                    listahora.Insert(0, new tbl_Hora { hor_id = 0, hor_descripcion = "Fecha | Sala | Hora:" });
                    ddl_hora.DataSource = listahora;
                    ddl_hora.DataTextField = "hor_descripcion";
                    ddl_hora.DataValueField = "hor_id";
                    ddl_hora.DataBind();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddl_Ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_sucursal.Items.Clear();
            ddl_hora.Items.Clear();
            if (ddl_Ciudad.SelectedIndex > 0)
            {
                Cargar_Sucursal(int.Parse(ddl_Ciudad.SelectedValue.ToString()));
            }
        }

        protected void ddl_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_hora.Items.Clear();
            if (ddl_sucursal.SelectedIndex > 0)
            {
                Cargar_Hora(int.Parse(ddl_Ciudad.SelectedValue.ToString()));
            }
        }

        protected void Btn_siguiente_Click(object sender, EventArgs e)
        {
            string ddl_c = ddl_Ciudad.SelectedValue.ToString();
            string ddl_s = ddl_sucursal.SelectedValue.ToString();
            string ddl_h = ddl_hora.SelectedValue.ToString();

            if (ddl_c != "0" && ddl_s != "0" && ddl_h != "0")
            {
                Session["ddl_c"] = ddl_c;
                Session["ddl_s"] = ddl_s;
                Session["ddl_h"] = ddl_h;
                Response.Redirect("~/Opcion2/BoletosC.aspx");
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}