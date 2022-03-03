using Capa_Datos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace TR_Cine.Opcion2
{
    public partial class PagosC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ddl_c = Convert.ToInt32((string)(Session["ddl_c"]));
            int ddl_s = Convert.ToInt32((string)(Session["ddl_s"]));
            int ddl_h = Convert.ToInt32((string)(Session["ddl_h"]));
            int totalboletos = (int)Session["totalboletos"];
            int Preciototal = (int)Session["preciototal"];
            //DatosPersonales
            string nombre = (string)Session["Nombre"];
            string correo = (string)Session["Correo"];
            string cedula = (string)Session["Cedula"];
            string telefono = (string)Session["Telefono"];

            if (ddl_c != 0 && ddl_s != 0 && ddl_h != 0 && totalboletos!= 0 && Preciototal != 0)
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
                lbl_contadorbut.Text = Convert.ToString(totalboletos);
                lbl_precio.Text = Convert.ToString(Preciototal) + "$";
                lbl_cedula.Text = cedula;
                lbl_nombre.Text = nombre;
                lbl_correo.Text = correo;
                lbl_telefono.Text = telefono;
            }
            else
            {
                Response.Redirect("~/Eternals.aspx");
            }

            int eternos = (int)(Session["id_eternos"]);
            tbl_Pelicula pelicula = new tbl_Pelicula();
            pelicula = Capa_Negocios.Pelicula_Logica.Obtner_perXId(eternos);
            if (pelicula != null)
            {
                lbl_pelicula.Text = pelicula.pel_titulo;
            }
        }

        protected void Btn_Anterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("ButacaC.aspx");
        }

        protected void Btn_Siguiente_Click(object sender, EventArgs e)
        {                                   
                Response.Write("<script>alert('Compra exitosa, revisar su correo para encontrar su QR');</script>");
                Response.Redirect("~/Index.aspx");            
        }
    }
}