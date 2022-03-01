using Capa_Datos;
using System;
using System.Collections.Generic;

namespace TR_Cine.Opcion2
{
    public partial class BoletosC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ddl_c = Convert.ToInt32((string)(Session["ddl_c"]));
            int ddl_s = Convert.ToInt32((string)(Session["ddl_s"]));
            int ddl_h = Convert.ToInt32((string)(Session["ddl_h"]));

            if (ddl_c != 0 && ddl_s != 0 && ddl_h != 0)
            {
                tbl_Ciudad ciudad = new tbl_Ciudad();
                ciudad = Capa_Negocios.Ciudad_Logica.Obtner_ciuXId(ddl_c);

                tbl_Sucursal sucursal = new tbl_Sucursal();
                sucursal = Capa_Negocios.Sucursal_Logica.Obtner_sucXId(ddl_s);

                tbl_Hora hora = new tbl_Hora();
                hora = Capa_Negocios.Hora_Logica.Obtner_horXId(ddl_h);

                lbl_ddlc.Text = ciudad.ciu_descripcion;
                lbl_ddls.Text = sucursal.suc_descripcion;
                lbl_ddlh.Text = hora.hor_descripcion;
            }
            else
            {
                Response.Redirect("~/Eternals.aspx");
            }
        }
    }
}