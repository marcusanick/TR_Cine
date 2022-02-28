using System;
using System.Data;
using System.Data.SqlClient;

namespace TR_Cine
{
    public partial class Index : System.Web.UI.Page
    {

        string CadenaConexion = "Data Source=BoleteriaPm.mssql.somee.com;Initial Catalog=BoleteriaPm;Persist Security Info=True;User ID=marcusanick_SQLLogin_1;Password=7x5orgwf9j";

        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultarImagen();
        }

        protected void lnk_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void ConsultarImagen()
        {
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT pel_img,pel_titulo,pel_url FROM tbl_Pelicula WHERE pel_estado='A' ORDER BY pel_id ASC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable ImageneBD = new DataTable();
            ImageneBD.Load(cmd.ExecuteReader());

            Repeater1.DataSource = ImageneBD;
            Repeater1.DataBind();
            conexionSQL.Close();

        }
    }
}