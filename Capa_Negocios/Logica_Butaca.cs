using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class Logica_Butaca
    {
        private static BD_CineDataContext dc = new BD_CineDataContext();
        public static bool BloqueoBut(tbl_butaca dataButaca)
        {
            try
            {
                bool result = false;
                dataButaca.but_estado = 'I';
                dc.SubmitChanges();
                result = true;
                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al Bloquear butaca" + ex.Message);
            }
        }
    }
}
