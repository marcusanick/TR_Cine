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
            Verificar_ButacasS1();
            lbl_contador.Text = Convert.ToString(contador);
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
    }
}