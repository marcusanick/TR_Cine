using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace TR_Cine.Opcion2
{
    public partial class ButacaC : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection("Data Source=BoleteriaPm.mssql.somee.com;Initial Catalog=BoleteriaPm;Persist Security Info=True;User ID=marcusanick_SQLLogin_1;Password=7x5orgwf9j");

        protected void Page_Load(object sender, EventArgs e)
        {
            Verificar_ButacasS1();
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
            if (dt.Rows[1]["but_estado"].ToString() == "I")
            {
                Btn_A2.BackColor = Color.Red;
                lbl_A2.Visible = false;
                Btn_A2.Enabled = false;
            }
            if (dt.Rows[2]["but_estado"].ToString() == "I")
            {
                Btn_A3.BackColor = Color.Red;
                lbl_A3.Visible = false;
                Btn_A3.Enabled = false;
            }
            if (dt.Rows[3]["but_estado"].ToString() == "I")
            {
                Btn_A4.BackColor = Color.Red;
                lbl_A4.Visible = false;
                Btn_A4.Enabled = false;
            }
            if (dt.Rows[4]["but_estado"].ToString() == "I")
            {
                Btn_A5.BackColor = Color.Red;
                lbl_A5.Visible = false;
                Btn_A5.Enabled = false;
            }
            if (dt.Rows[5]["but_estado"].ToString() == "I")
            {
                Btn_A6.BackColor = Color.Red;
                lbl_A6.Visible = false;
                Btn_A6.Enabled = false;
            }
            //
            if (dt.Rows[6]["but_estado"].ToString() == "I")
            {
                Btn_A7.BackColor = Color.Red;
                lbl_A7.Visible = false;
                Btn_A7.Enabled = false;
            }
            if (dt.Rows[7]["but_estado"].ToString() == "I")
            {
                Btn_A8.BackColor = Color.Red;
                lbl_A8.Visible = false;
                Btn_A8.Enabled = false;
            }
            if (dt.Rows[8]["but_estado"].ToString() == "I")
            {
                Btn_A9.BackColor = Color.Red;
                lbl_A9.Visible = false;
                Btn_A9.Enabled = false;
            }
            if (dt.Rows[9]["but_estado"].ToString() == "I")
            {
                Btn_A10.BackColor = Color.Red;
                lbl_A10.Visible = false;
                Btn_A10.Enabled = false;
            }
            if (dt.Rows[10]["but_estado"].ToString() == "I")
            {
                Btn_A11.BackColor = Color.Red;
                lbl_A11.Visible = false;
                Btn_A11.Enabled = false;
            }
            if (dt.Rows[11]["but_estado"].ToString() == "I")
            {
                Btn_A12.BackColor = Color.Red;
                lbl_A12.Visible = false;
                Btn_A12.Enabled = false;
            }            
        }

    }
}