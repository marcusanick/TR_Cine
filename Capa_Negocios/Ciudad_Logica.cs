using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class Ciudad_Logica
    {
        private static BD_CineDataContext dc = new BD_CineDataContext();

        public static List<tbl_Ciudad> getallCiudad()
        {
            try
            {
                var lista = dc.tbl_Ciudad.Where(data => data.ciu_estado == 'A').OrderBy(ord => ord.ciu_descripcion);
                return lista.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tbl_Ciudad Obtner_ciuXId(int codigo_ciudad)
        {
            try
            {
                var ciudad = dc.tbl_Ciudad.FirstOrDefault(data => data.ciu_estado == 'A'
                                        && data.ciu_id.Equals(codigo_ciudad));
                return ciudad;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }

    }
}
