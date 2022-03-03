using Capa_Datos;
using QRCoder;
using System;
using System.Data;
using System.Data.SqlClient;
using Capa_Negocios;
using System.Drawing;
using static QRCoder.PayloadGenerator;
using System.Net.Mail;
using System.Net.Mime;

namespace TR_Cine.Opcion2
{
    public partial class PagosC : System.Web.UI.Page
    {
        private tbl_Factura facturas = new tbl_Factura();
        public string imagen;
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

            if (ddl_c != 0 && ddl_s != 0 && ddl_h != 0 && totalboletos != 0 && Preciototal != 0)
            {
                tbl_Ciudad ciudad = new tbl_Ciudad();
                ciudad = Ciudad_Logica.Obtner_ciuXId(ddl_c);

                tbl_Sucursal sucursal = new tbl_Sucursal();
                sucursal = Sucursal_Logica.Obtner_sucXId(ddl_s);

                tbl_Hora hora = new tbl_Hora();
                hora = Hora_Logica.Obtner_horXId(ddl_h);
            }
            else
            {
                Response.Redirect("~/Eternals.aspx");
            }
            var factura = Factura_Logica.ultimaFactura();
            byte[] facturaThumb = factura.fac_qr.ToArray();

            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(facturaThumb);
            ImagePreview.ImageUrl = ImagenDataURL64;
        }

        protected void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Index.aspx");
        }
    }
}