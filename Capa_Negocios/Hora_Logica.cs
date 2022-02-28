using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capa_Negocios
{
    public class Hora_Logica
    {
        private static BD_CineDataContext dc = new BD_CineDataContext();

        public static List<tbl_Hora> getallHoraXSucursalXEternals(int Codigo_Hora)
        {
            try
            {
                var lista = dc.tbl_Hora.Where(data => data.hor_estado == 'A' && data.suc_id.Equals(Codigo_Hora) && data.pel_id == 1).OrderBy(ord => ord.hor_descripcion);
                return lista.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
