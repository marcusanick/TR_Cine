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
                Btn_prueba.BackColor = Color.Red;                
                Btn_prueba.Enabled = false;                
            }
            if (dt.Rows[1]["but_estado"].ToString() == "I")
            {
                Btn_A2.BackColor = Color.Red;
                Btn_A2.Enabled = false;
            }
            if (dt.Rows[2]["but_estado"].ToString() == "I")
            {
                Btn_A3.BackColor = Color.Red;
                Btn_A3.Enabled = false;
            }
        }

    }
}