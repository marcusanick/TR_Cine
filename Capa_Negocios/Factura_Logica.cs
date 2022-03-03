using Capa_Datos;
using System;
using System.Linq;

namespace Capa_Negocios
{
    public class Factura_Logica
    {
        private static BD_CineDataContext dc = new BD_CineDataContext();

        //metodo para Guardar
        public static void Guardar(tbl_Factura fac)
        {
            try
            {
                fac.fac_fecha = DateTime.Now;

                dc.tbl_Factura.InsertOnSubmit(fac);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados</br>" + ex.Message);

            }
        }

        public static tbl_Factura ultimaFactura()
        {
            var last = dc.tbl_Factura.OrderByDescending(x=> x.fac_fecha).FirstOrDefault();
            return last;
        }
    }
}
