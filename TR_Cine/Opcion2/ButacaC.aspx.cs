using Capa_Datos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace TR_Cine.Opcion2
{
    public partial class ButacaC : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=BoleteriaPm.mssql.somee.com;Initial Catalog=BoleteriaPm;Persist Security Info=True;User ID=marcusanick_SQLLogin_1;Password=7x5orgwf9j");
        int contador = 0;
        int contadorbut = 1;                
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

            int totalboletos = (int)Session["totalboletos"];
            int Preciototal = (int)Session["preciototal"];            

            lbl_precio.Text = Convert.ToString(Preciototal);
            lbl_butco.Text = Convert.ToString(totalboletos);            


            Verificar_ButacasS1();
            lbl_contador.Text = Convert.ToString(contador);
            if (totalboletos > contador)
            {
                Response.Write("<script>alert('Numero de boletos excede el numero de asientos disponibles');</script>");
                Response.Redirect("BoletosC.aspx");                
            }

            Session["Ini"] = Session["Inic"];            
        }
        
        
        private void Verificar_ButacasS1()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select but_estado from tbl_butaca", con);            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            if (dt.Rows[0]["but_estado"].ToString() == "I")
            {
                Btn_A1.BackColor = Color.Red;
                lbl_A1.Visible = false;
                Btn_A1.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[1]["but_estado"].ToString() == "I")
            {
                Btn_A2.BackColor = Color.Red;
                lbl_A2.Visible = false;
                Btn_A2.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[2]["but_estado"].ToString() == "I")
            {
                Btn_A3.BackColor = Color.Red;
                lbl_A3.Visible = false;
                Btn_A3.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[3]["but_estado"].ToString() == "I")
            {
                Btn_A4.BackColor = Color.Red;
                lbl_A4.Visible = false;
                Btn_A4.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[4]["but_estado"].ToString() == "I")
            {
                Btn_A5.BackColor = Color.Red;
                lbl_A5.Visible = false;
                Btn_A5.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[5]["but_estado"].ToString() == "I")
            {
                Btn_A6.BackColor = Color.Red;
                lbl_A6.Visible = false;
                Btn_A6.Enabled = false;
            }
            else
            {
                contador++;
            }
            //
            if (dt.Rows[6]["but_estado"].ToString() == "I")
            {
                Btn_A7.BackColor = Color.Red;
                lbl_A7.Visible = false;
                Btn_A7.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[7]["but_estado"].ToString() == "I")
            {
                Btn_A8.BackColor = Color.Red;
                lbl_A8.Visible = false;
                Btn_A8.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[8]["but_estado"].ToString() == "I")
            {
                Btn_A9.BackColor = Color.Red;
                lbl_A9.Visible = false;
                Btn_A9.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[9]["but_estado"].ToString() == "I")
            {
                Btn_A10.BackColor = Color.Red;
                lbl_A10.Visible = false;
                Btn_A10.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[10]["but_estado"].ToString() == "I")
            {
                Btn_A11.BackColor = Color.Red;
                lbl_A11.Visible = false;
                Btn_A11.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[11]["but_estado"].ToString() == "I")
            {
                Btn_A12.BackColor = Color.Red;
                lbl_A12.Visible = false;
                Btn_A12.Enabled = false;
            }
            else
            {
                contador++;
            }
        }
        
        private void validarCantidadComprada()
        {
            int nbutco = Convert.ToInt32(lbl_butco.Text);
            int nbutes = Convert.ToInt32(lbl_contadorbut.Text);
            if (nbutes > nbutco)
            {
                Response.Write("<script>alert('La cantidad de butacas escogidas no corresponden al numero de butacas compradas');</script>");
            }
            else if (nbutes < nbutco)
            {
                Response.Write("<script>alert('Butacas restantes por escoger');</script>");
            }
            else
            {
                Response.Write("<script>alert('Compra Completada');</script>");
            }
        }

        protected void Btn_A2_Click(object sender, EventArgs e)
        {
            if (Btn_A2.Text.Equals(""))
            {
                Btn_A2.BackColor = Color.Blue;
                Btn_A2.Text = "2";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A2.Text.Equals("2"))
            {
                Btn_A2.BackColor = Color.LimeGreen;
                Btn_A2.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }

            //Intento no funcionando
            //Btn_A2.BackColor = Color.LimeGreen;
            //if (Btn_A2.BackColor.Equals(Color.LimeGreen))
            //{
            //    Btn_A2.BackColor = Color.Blue;
            //    lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
            //    Session["Inic"] = lbl_contadorbut.Text.ToString();
            //}
            //else if (Btn_A2.BackColor.Equals(Color.Blue))           
            //{
            //    Btn_A2.BackColor = Color.LimeGreen;
            //    lbl_contadorbut.Text = (contadorbut - (Convert.ToInt32(Session["Ini"]))).ToString();
            //    Session["Inic"] = lbl_contadorbut.Text.ToString();
            //}
        }

        protected void Btn_A4_Click(object sender, EventArgs e)
        {

            if (Btn_A4.Text.Equals(""))
            {
                Btn_A4.BackColor = Color.Blue;
                Btn_A4.Text = "4";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A4.Text.Equals("4"))
            {
                Btn_A4.BackColor = Color.LimeGreen;
                Btn_A4.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"]))-contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_A1_Click(object sender, EventArgs e)
        {
            if (Btn_A1.Text.Equals(""))
            {
                Btn_A1.BackColor = Color.Blue;
                Btn_A1.Text = "1";                
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A1.Text.Equals("1"))
            {
                Btn_A1.BackColor = Color.LimeGreen;
                Btn_A1.Text = "";
                lbl_contadorbut.Text = (contadorbut - (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_A3_Click(object sender, EventArgs e)
        {
            if (Btn_A3.Text.Equals(""))
            {
                Btn_A3.BackColor = Color.Blue;
                Btn_A3.Text = "3";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A3.Text.Equals("3"))
            {
                Btn_A3.BackColor = Color.LimeGreen;
                Btn_A3.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_A5_Click(object sender, EventArgs e)
        {
            if (Btn_A5.Text.Equals(""))
            {
                Btn_A5.BackColor = Color.Blue;
                Btn_A5.Text = "5";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A5.Text.Equals("5"))
            {
                Btn_A5.BackColor = Color.LimeGreen;
                Btn_A5.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_A6_Click(object sender, EventArgs e)
        {
            if (Btn_A6.Text.Equals(""))
            {
                Btn_A6.BackColor = Color.Blue;
                Btn_A6.Text = "6";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A6.Text.Equals("6"))
            {
                Btn_A6.BackColor = Color.LimeGreen;
                Btn_A6.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_siguiente_Click(object sender, EventArgs e)
        {
            validarCantidadComprada();
        }
    }
}