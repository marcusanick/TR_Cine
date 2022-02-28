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
                var lista = dc.tbl_Sucursal.Where(data => data.suc_estado == 'A').OrderBy(ord => ord.suc_descripcion);
                return lista.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
