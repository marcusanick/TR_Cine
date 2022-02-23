using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capa_Negocios
{
    public class Pelicula_Logica
    {

        //INSTANCIAR EL DBML
        private static BD_CineDataContext dc = new BD_CineDataContext();

        //crear metodo para traer una lista de personas
        public static List<tbl_Pelicula> Obtner_peliculas()
        {
            try
            {
                var personas = dc.tbl_Pelicula.Where(per => per.pel_estado == 'A');
                return personas.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }

        //crear metodo para traer una pelicula  escpecifica
        public static tbl_Pelicula Obtner_perXId(int codigoPer)
        {
            try
            {
                var personas = dc.tbl_Pelicula.FirstOrDefault(rol => rol.pel_estado == 'A'
                                        && rol.pel_id.Equals(codigoPer));
                return personas;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
        //metodo para traer persona x nombre
        public static tbl_Pelicula Obtener_perXnombre(string nombre)
        {
            var proid = dc.tbl_Pelicula.FirstOrDefault(pro => pro.pel_titulo.Equals(nombre) && pro.pel_estado == 'A');
            return proid;
        }
        //METODOS CRUD

        //metodo para autenticar que no sean duplicados
        public static bool autentificar_per(string nombre)
        {
            var auto = dc.tbl_Pelicula.Any(pro => pro.pel_titulo.Equals(nombre));
            return auto;
        }
        //metodo para Guardar
        public static void Guardar(tbl_Pelicula pro)
        {
            try
            {
                pro.pel_estado = 'A';

                dc.tbl_Pelicula.InsertOnSubmit(pro);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados</br>" + ex.Message);

            }
        }
        //metodo para Editar
        public static void Editar(tbl_Pelicula pro)
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
        public static void Eliminar(tbl_Pelicula pro)
        {
            try
            {
                pro.pel_estado = 'I';
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
