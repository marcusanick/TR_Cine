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
        protected void Page_Load(object sender, EventArgs e)
        {
            Cargar_Ciudad();
        }

        private void Cargar_Ciudad()
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

        private void Cargar_Sucursal(int CodigoCiudad)
        {
            try
            {
                if (CodigoCiudad > 0)
                {
                    List<tbl_Sucursal> listaSucursal = new List<tbl_Sucursal>();
                    listaSucursal = Capa_Negocios.Sucursal_Logica.getallSucursalXCiudad(CodigoCiudad);
                    if (listaSucursal != null && listaSucursal.Count > 0)
                    {
                        listaSucursal.Insert(0, new tbl_Sucursal { suc_id = 0, suc_descripcion = "Ciudad:" });
                        ddl_sucursal.DataSource = listaSucursal;
                        ddl_sucursal.DataTextField = "ciu_descripcion";
                        ddl_sucursal.DataValueField = "ciu_id";
                        ddl_sucursal.DataBind();
                    }
                }
            }catch (Exception)
            {
                throw;
            }
        }

        protected void ddl_Ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_Ciudad.SelectedIndex > 0)
            {
                Cargar_Sucursal(int.Parse(ddl_Ciudad.SelectedValue.ToString()));
            }
        }
    }
}