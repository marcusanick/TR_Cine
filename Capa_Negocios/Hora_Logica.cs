﻿using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capa_Negocios
{
    public class Hora_Logica
    {
        private static BD_CineDataContext dc = new BD_CineDataContext();

        public static List<tbl_Hora> getallHoraXSucursalXFuncion(int CodigoSucursal, int CodigoFuncion)
        {
            try
            {
                var lista = dc.tbl_Hora.Where(data => data.hor_estado == 'A').OrderBy(ord => ord.hor_descripcion);
                return lista.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
