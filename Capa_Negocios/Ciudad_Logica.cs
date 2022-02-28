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
    }
}
