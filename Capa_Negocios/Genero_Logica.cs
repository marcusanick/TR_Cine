using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Negocios;
namespace Capa_Negocios
{
    public class Genero_Logica
    {

        //INSTANCIAR EL DBML
        private static BD_CineDataContext dc = new BD_CineDataContext();

        //crear metodo para traer una lista de roles
        public static List<tbl_Genero> Obtner_generos()
        {
            try
            {
                var roles = dc.tbl_Genero.Where(rol => rol.gen_estado == 'A');
                return roles.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
        //crear metodo para traer un rol escpecifico
        public static tbl_Genero Obtner_genXId(int codigoRol)
        {
            try
            {
                var roles = dc.tbl_Genero.FirstOrDefault(rol => rol.gen_estado == 'A'
                                        && rol.gen_id.Equals(codigoRol));
                return roles;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
        //metodo para traer gen x nombre
        public static tbl_Genero Obtener_GenXnombre(string nombre)
        {
            var proid = dc.tbl_Genero.FirstOrDefault(pro => pro.gen_descripcion.Equals(nombre) && pro.gen_estado == 'A');
            return proid;
        }
        //METODOS CRUD

        //metodo para autenticar que no sean duplicados
        public static bool autentificar_gen(string nombre)
        {
            var auto = dc.tbl_Genero.Any(pro => pro.gen_descripcion.Equals(nombre));
            return auto;
        }
        //metodo para Guardar
        public static void Guardar(tbl_Genero pro)
        {
            try
            {
                pro.gen_estado = 'A';
                
                dc.tbl_Genero.InsertOnSubmit(pro);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados</br>" + ex.Message);

            }
        }
        //metodo para Editar
        public static void Editar(tbl_Genero pro)
        {
            try
            {
                
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Los datos no han sido modificados</br>" + ex.Message);
            }
        }
        public static void Eliminar(tbl_Genero pro)
        {
            try
            {
                pro.gen_estado = 'I';
                // dc.Tbl_Producto.DeleteOnSubmit(pro);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Los datos no han sido borrados</br>" + ex.Message);
            }
        }
        //crear metodo para guardar los roles 
        public static bool Guardar_Gen(tbl_Genero _infoRol)
        {
            try
            {
                bool resultado = false;
                dc.tbl_Genero.InsertOnSubmit(_infoRol);
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
