using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class Sucursal_Logica
    {
        private static BD_CineDataContext dc = new BD_CineDataContext();

        public static List<tbl_Sucursal> getallSucursalXCiudad(int Codigo_Ciudad)
        {
            try
            {
                var lista = dc.tbl_Sucursal.Where(data => data.suc_estado == 'A' && data.ciu_id.Equals(Codigo_Ciudad)).OrderBy(ord => ord.suc_descripcion);
                return lista.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tbl_Sucursal Obtner_sucXId(int codigo_sucursal)
        {
            try
            {
                var sucursal = dc.tbl_Sucursal.FirstOrDefault(data => data.suc_estado == 'A'
                                        && data.suc_id.Equals(codigo_sucursal));
                return sucursal;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }

    }
}
