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

        public static tbl_Hora Obtner_horXId(int codigo_hora)
        {
            try
            {
                var hora = dc.tbl_Hora.FirstOrDefault(data => data.hor_estado == 'A'
                                        && data.hor_id.Equals(codigo_hora));
                return hora;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
    }
}
