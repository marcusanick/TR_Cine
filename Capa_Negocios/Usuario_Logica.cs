using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data.Linq;

namespace Capa_Negocios
{
    public class Usuario_Logica
    {

        //instanciamos el dbml
        private static BD_CineDataContext dc = new BD_CineDataContext();

        //metodo para traer una lista de usuarios
        public static List<tbl_Usuario> obtener_Usuarios()
        {
            var lista = dc.tbl_Usuario.Where(usu => usu.usu_estado == 'A');
            return lista.ToList();
        }
        //metodo para verificar las credenciales 
        public static bool Autentificar(string nombre, string pass)
        {
            var auto = dc.tbl_Usuario.Any(usu => usu.usu_estado == 'A' & usu.usu_usuario.Equals(nombre) &&

                                            usu.usu_pass.Equals(pass));
            return auto;
        }
        
        //metodo para verificar si existe o no  
        public static bool AutentificarxNombre(string nombre)
        {
            var auto = dc.tbl_Usuario.Any(usu => usu.usu_usuario.Equals(nombre));
            return auto;
        }
        //metodo para verificar si existe o no  
        public static bool AutentificarNombre(string nombre)
        {
            var auto = dc.tbl_Usuario.Any(usu => usu.usu_estado == 'A' && usu.usu_email.Equals(nombre));
            return auto;
        }
        //metodo para verificar si existe o no  
        public static bool AutentificarxCorreo(string nombre)
        {
            var auto = dc.tbl_Usuario.Any(usu => usu.usu_email.Equals(nombre));
            return auto;
        }
        //metodo para traer la informacion del objecto
        public static tbl_Usuario autentificarXnLogin(string nombre, string pass)
        {
            var nlogin = dc.tbl_Usuario.Single(usu => usu.usu_estado == 'A' & usu.usu_email.Equals(nombre) &
                                            usu.usu_pass.Equals(pass));
            return nlogin;
        }
        //metodo para traer la informacion del objecto
        public static tbl_Usuario autentificarXcorreo(string nombre)
        {
            var ced = dc.tbl_Usuario.Single(usu => usu.usu_estado == 'A' & usu.usu_email.Equals(nombre));
            return ced;
        }
        //metodo para guardar  los datos
        public static void Guardar(tbl_Usuario usuario)
        {
            try
            {
                usuario.usu_estado = 'A';
                //usuario.usu_add = DateTime.Now;
                usuario.rol_id = '2';
                
                dc.tbl_Usuario.InsertOnSubmit(usuario);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Los datos no han sido guardados <br/> " + ex.Message);
            }
        }
    }
}
