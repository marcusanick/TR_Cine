using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capa_Negocios
{
    public class Rol_Logica
    {
        //INSTANCIAR EL DBML
        private static BD_CineDataContext dc = new BD_CineDataContext();

        //crear metodo para traer una lista de roles
        public static List<tbl_Rol> Obtner_roles()
        {
            try
            {
                var roles = dc.tbl_Rol.Where(rol => rol.rol_estado == 'A');
                return roles.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
        //crear metodo para traer un rol escpecifico
        public static tbl_Rol Obtner_rolXId(int codigoRol)
        {
            try
            {
                var roles = dc.tbl_Rol.FirstOrDefault(rol => rol.rol_estado == 'A'
                                        && rol.rol_id.Equals(codigoRol));
                return roles;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
        //crear metodo para guardar los roles 
        public static bool Guardar_Rol(tbl_Rol _infoRol)
        {
            try
            {
                bool resultado = false;
                dc.tbl_Rol.InsertOnSubmit(_infoRol);
                dc.SubmitChanges();
                resultado = true;
                return resultado;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
    }
}
