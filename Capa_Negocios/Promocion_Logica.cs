using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capa_Negocios
{
    public class Promocion_Logica
    {
        //INSTANCIAR EL DBML
        private static BD_CineDataContext dc = new BD_CineDataContext();

        //crear metodo para traer una lista de personas
        public static List<tbl_promocion> Obtner_promociones()
        {
            try
            {
                var personas = dc.tbl_promocion.Where(per => per.pro_estado == 'A');
                return personas.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }

        //crear metodo para traer una pelicula  escpecifica
        public static tbl_promocion Obtner_proXId(int codigoPer)
        {
            try
            {
                var personas = dc.tbl_promocion.FirstOrDefault(rol => rol.pro_estado == 'A'
                                        && rol.pro_id.Equals(codigoPer));
                return personas;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
        //metodo para traer persona x nombre
        public static tbl_promocion Obtener_perXnombre(string nombre)
        {
            var proid = dc.tbl_promocion.FirstOrDefault(pro => pro.pro_descripcion.Equals(nombre) && pro.pro_estado == 'A');
            return proid;
        }
        //METODOS CRUD

        //metodo para autenticar que no sean duplicados
        public static bool autentificar_pro(string nombre)
        {
            var auto = dc.tbl_promocion.Any(pro => pro.pro_descripcion.Equals(nombre));
            return auto;
        }
        //metodo para Guardar
        public static void Guardar(tbl_promocion pro)
        {
            try
            {
                pro.pro_estado = 'A';

                dc.tbl_promocion.InsertOnSubmit(pro);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados</br>" + ex.Message);

            }
        }
        //metodo para Editar
        public static void Editar(tbl_promocion pro)
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
        public static void Eliminar(tbl_promocion pro)
        {
            try
            {
                pro.pro_estado = 'I';
                // dc.Tbl_Producto.DeleteOnSubmit(pro);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Los datos no han sido borrados</br>" + ex.Message);
            }
        }


    }
}

