using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TR_Cine
{

    public partial class Eternals : System.Web.UI.Page
    {

        public void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargar_Ciudad();
            }
        }

        public void Cargar_Ciudad()
        {
            List<tbl_Ciudad> listaCiudad = new List<tbl_Ciudad>();
            listaCiudad = Capa_Negocios.Ciudad_Logica.getallCiudad();
            if (listaCiudad != null && listaCiudad.Count > 0)
            {
                listaCiudad.Insert(0, new tbl_Ciudad { ciu_id = 0, ciu_descripcion = "Ciudad:" });
                ddl_Ciudad.DataSource = listaCiudad;
                ddl_Ciudad.DataTextField = "ciu_descripcion";
                ddl_Ciudad.DataValueField = "ciu_id";
                ddl_Ciudad.DataBind();
            }
        }
                
        public void Cargar_Sucursal(int Codigo_Ciudad)
        {
            try
            {
                if (Codigo_Ciudad > 0)
                {
                    List<tbl_Sucursal> listaSucursal = new List<tbl_Sucursal>();
                    listaSucursal = Capa_Negocios.Sucursal_Logica.getallSucursalXCiudad(Codigo_Ciudad);
                    if (listaSucursal != null && listaSucursal.Count > 0)
                    {
                        listaSucursal.Insert(0, new tbl_Sucursal { ciu_id = 0, suc_descripcion = "Sucursal:" });
                        ddl_sucursal.DataSource = listaSucursal;
                        ddl_sucursal.DataTextField = "suc_descripcion";
                        ddl_sucursal.DataValueField = "suc_id";
                        ddl_sucursal.DataBind();
                    }
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
            if (ddl_Ciudad.SelectedIndex > 0)
            {
                Cargar_Sucursal(int.Parse(ddl_Ciudad.SelectedValue.ToString()));
            }
        }
    }
}