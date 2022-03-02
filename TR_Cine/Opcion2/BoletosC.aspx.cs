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

            int eternos = (int)(Session["id_eternos"]);
            tbl_Pelicula pelicula = new tbl_Pelicula();
            pelicula = Capa_Negocios.Pelicula_Logica.Obtner_perXId(eternos);
            if (pelicula != null)
            {
                lbl_pelicula.Text = pelicula.pel_titulo;
                lbl_idioma.Text = pelicula.pel_idioma;
                lbl_genero.Text = pelicula.tbl_Genero.gen_descripcion;
                lbl_estado.Text = Convert.ToString(pelicula.pel_estado);                
            }
        }       

        protected void Btn_Anterior_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Eternals.aspx");
        }

        protected void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            int sumad = Convert.ToInt32(txt_adult.Text) * 5;
            int sumam = Convert.ToInt32(txt_menores.Text) * 4;
            int sumamy = Convert.ToInt32(txt_mayedad.Text) * 2;

            int sumaboletos = Convert.ToInt32(txt_adult.Text) + Convert.ToInt32(txt_menores.Text) + Convert.ToInt32(txt_mayedad.Text);
            int sumatotal = sumad + sumam + sumamy;

            if (sumatotal != 0)
            {
                string ddl_c = (string)Session["ddl_c"];
                string ddl_s = (string)Session["ddl_s"];
                string ddl_h = (string)Session["ddl_h"];
                int eternos = (int)(Session["id_eternos"]);
                Session["ddl_c"] = ddl_c;
                Session["ddl_s"] = ddl_s;
                Session["ddl_h"] = ddl_h;
                Session["id_eternos"] = eternos;
                Session["totalboletos"] = sumaboletos;
                Session["preciototal"] = sumatotal;
                Response.Redirect("ButacaC.aspx");
            }
            else
            {
                Response.Write("<script>alert('No hay cantidad de boleto escogida');</script>");
            }
        }
    }
}