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
            SqlCommand cmd = new SqlCommand("select but_estado from tbl_butaca ORDER BY but_id ASC ", con);            
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

            //Fila B

            if (dt.Rows[12]["but_estado"].ToString() == "I")
            {
                Btn_B1.BackColor = Color.Red;
                lbl_B1.Visible = false;
                Btn_B1.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[13]["but_estado"].ToString() == "I")
            {
                Btn_B2.BackColor = Color.Red;
                lbl_B2.Visible = false;
                Btn_B2.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[14]["but_estado"].ToString() == "I")
            {
                Btn_B3.BackColor = Color.Red;
                lbl_B3.Visible = false;
                Btn_B3.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[15]["but_estado"].ToString() == "I")
            {
                Btn_B4.BackColor = Color.Red;
                lbl_B4.Visible = false;
                Btn_B4.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[16]["but_estado"].ToString() == "I")
            {
                Btn_B5.BackColor = Color.Red;
                lbl_B5.Visible = false;
                Btn_B5.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[17]["but_estado"].ToString() == "I")
            {
                Btn_B6.BackColor = Color.Red;
                lbl_B6.Visible = false;
                Btn_B6.Enabled = false;
            }
            else
            {
                contador++;
            }
            //
            if (dt.Rows[18]["but_estado"].ToString() == "I")
            {
                Btn_B7.BackColor = Color.Red;
                lbl_B7.Visible = false;
                Btn_B7.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[19]["but_estado"].ToString() == "I")
            {
                Btn_B8.BackColor = Color.Red;
                lbl_B8.Visible = false;
                Btn_B8.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[20]["but_estado"].ToString() == "I")
            {
                Btn_B9.BackColor = Color.Red;
                lbl_B9.Visible = false;
                Btn_B9.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[21]["but_estado"].ToString() == "I")
            {
                Btn_B10.BackColor = Color.Red;
                lbl_B10.Visible = false;
                Btn_B10.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[22]["but_estado"].ToString() == "I")
            {
                Btn_B11.BackColor = Color.Red;
                lbl_B11.Visible = false;
                Btn_B11.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[23]["but_estado"].ToString() == "I")
            {
                Btn_B12.BackColor = Color.Red;
                lbl_B12.Visible = false;
                Btn_B12.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[24]["but_estado"].ToString() == "I")
            {
                Btn_B13.BackColor = Color.Red;
                lbl_B13.Visible = false;
                Btn_B13.Enabled = false;
            }
            else
            {
                contador++;
            }
            if (dt.Rows[25]["but_estado"].ToString() == "I")
            {
                Btn_B14.BackColor = Color.Red;
                lbl_B14.Visible = false;
                Btn_B14.Enabled = false;
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
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
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
            Response.Redirect("PagosC.aspx");
        }

        protected void Btn_A7_Click(object sender, EventArgs e)
        {
            if (Btn_A7.Text.Equals(""))
            {
                Btn_A7.BackColor = Color.Blue;
                Btn_A7.Text = "7";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A7.Text.Equals("7"))
            {
                Btn_A7.BackColor = Color.LimeGreen;
                Btn_A7.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_A8_Click(object sender, EventArgs e)
        {
            if (Btn_A8.Text.Equals(""))
            {
                Btn_A8.BackColor = Color.Blue;
                Btn_A8.Text = "8";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A8.Text.Equals("8"))
            {
                Btn_A8.BackColor = Color.LimeGreen;
                Btn_A8.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_A9_Click(object sender, EventArgs e)
        {
            if (Btn_A9.Text.Equals(""))
            {
                Btn_A9.BackColor = Color.Blue;
                Btn_A9.Text = "9";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A9.Text.Equals("9"))
            {
                Btn_A9.BackColor = Color.LimeGreen;
                Btn_A9.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_A10_Click(object sender, EventArgs e)
        {
            if (Btn_A10.Text.Equals(""))
            {
                Btn_A10.BackColor = Color.Blue;
                Btn_A10.Text = "10";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A10.Text.Equals("10"))
            {
                Btn_A10.BackColor = Color.LimeGreen;
                Btn_A10.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_A11_Click(object sender, EventArgs e)
        {
            if (Btn_A11.Text.Equals(""))
            {
                Btn_A11.BackColor = Color.Blue;
                Btn_A11.Text = "11";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A11.Text.Equals("11"))
            {
                Btn_A11.BackColor = Color.LimeGreen;
                Btn_A11.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_A12_Click(object sender, EventArgs e)
        {
            if (Btn_A12.Text.Equals(""))
            {
                Btn_A12.BackColor = Color.Blue;
                Btn_A12.Text = "12";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_A12.Text.Equals("12"))
            {
                Btn_A12.BackColor = Color.LimeGreen;
                Btn_A12.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        //Fila B

        protected void Btn_B1_Click(object sender, EventArgs e)
        {
            if (Btn_B1.Text.Equals(""))
            {
                Btn_B1.BackColor = Color.Blue;
                Btn_B1.Text = "1";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B1.Text.Equals("1"))
            {
                Btn_B1.BackColor = Color.LimeGreen;
                Btn_B1.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B2_Click(object sender, EventArgs e)
        {
            if (Btn_B2.Text.Equals(""))
            {
                Btn_B2.BackColor = Color.Blue;
                Btn_B2.Text = "2";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B2.Text.Equals("2"))
            {
                Btn_B2.BackColor = Color.LimeGreen;
                Btn_B2.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B3_Click(object sender, EventArgs e)
        {
            if (Btn_B3.Text.Equals(""))
            {
                Btn_B3.BackColor = Color.Blue;
                Btn_B3.Text = "3";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B3.Text.Equals("3"))
            {
                Btn_B3.BackColor = Color.LimeGreen;
                Btn_B3.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B4_Click(object sender, EventArgs e)
        {
            if (Btn_B4.Text.Equals(""))
            {
                Btn_B4.BackColor = Color.Blue;
                Btn_B4.Text = "4";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B4.Text.Equals("4"))
            {
                Btn_B4.BackColor = Color.LimeGreen;
                Btn_B4.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }
        protected void Btn_B5_Click(object sender, EventArgs e)
        {
            if (Btn_B5.Text.Equals(""))
            {
                Btn_B5.BackColor = Color.Blue;
                Btn_B5.Text = "5";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B5.Text.Equals("5"))
            {
                Btn_B5.BackColor = Color.LimeGreen;
                Btn_B5.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B6_Click(object sender, EventArgs e)
        {
            if (Btn_B6.Text.Equals(""))
            {
                Btn_B6.BackColor = Color.Blue;
                Btn_B6.Text = "6";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B6.Text.Equals("6"))
            {
                Btn_B6.BackColor = Color.LimeGreen;
                Btn_B6.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B7_Click(object sender, EventArgs e)
        {
            if (Btn_B7.Text.Equals(""))
            {
                Btn_B7.BackColor = Color.Blue;
                Btn_B7.Text = "7";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B7.Text.Equals("7"))
            {
                Btn_B7.BackColor = Color.LimeGreen;
                Btn_B7.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B8_Click(object sender, EventArgs e)
        {
            if (Btn_B8.Text.Equals(""))
            {
                Btn_B8.BackColor = Color.Blue;
                Btn_B8.Text = "8";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B8.Text.Equals("8"))
            {
                Btn_B8.BackColor = Color.LimeGreen;
                Btn_B8.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B9_Click(object sender, EventArgs e)
        {
            if (Btn_B9.Text.Equals(""))
            {
                Btn_B9.BackColor = Color.Blue;
                Btn_B9.Text = "9";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B9.Text.Equals("9"))
            {
                Btn_B9.BackColor = Color.LimeGreen;
                Btn_B9.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B10_Click(object sender, EventArgs e)
        {
            if (Btn_B10.Text.Equals(""))
            {
                Btn_B10.BackColor = Color.Blue;
                Btn_B10.Text = "10";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B10.Text.Equals("10"))
            {
                Btn_B10.BackColor = Color.LimeGreen;
                Btn_B10.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B11_Click(object sender, EventArgs e)
        {
            if (Btn_B11.Text.Equals(""))
            {
                Btn_B11.BackColor = Color.Blue;
                Btn_B11.Text = "11";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B11.Text.Equals("11"))
            {
                Btn_B11.BackColor = Color.LimeGreen;
                Btn_B11.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B12_Click(object sender, EventArgs e)
        {
            if (Btn_B12.Text.Equals(""))
            {
                Btn_B12.BackColor = Color.Blue;
                Btn_B12.Text = "12";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B12.Text.Equals("12"))
            {
                Btn_B12.BackColor = Color.LimeGreen;
                Btn_B12.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B13_Click(object sender, EventArgs e)
        {
            if (Btn_B13.Text.Equals(""))
            {
                Btn_B13.BackColor = Color.Blue;
                Btn_B13.Text = "13";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B13.Text.Equals("13"))
            {
                Btn_B13.BackColor = Color.LimeGreen;
                Btn_B13.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }

        protected void Btn_B14_Click(object sender, EventArgs e)
        {
            if (Btn_B14.Text.Equals(""))
            {
                Btn_B14.BackColor = Color.Blue;
                Btn_B14.Text = "14";
                lbl_contadorbut.Text = (contadorbut + (Convert.ToInt32(Session["Ini"]))).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
            else if (Btn_B14.Text.Equals("14"))
            {
                Btn_B14.BackColor = Color.LimeGreen;
                Btn_B14.Text = "";
                lbl_contadorbut.Text = ((Convert.ToInt32(Session["Ini"])) - contadorbut).ToString();
                Session["Inic"] = lbl_contadorbut.Text.ToString();
            }
        }
    }
}