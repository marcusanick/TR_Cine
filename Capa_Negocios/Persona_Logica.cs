using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data.Linq;

namespace Capa_Negocios
{
    public class Persona_Logica
    {
        //INSTANCIAR EL DBML
        private static BD_CineDataContext dc = new BD_CineDataContext();

        //crear metodo para traer una lista de personas
        public static List<tbl_Persona> Obtner_personas()
        {
            try
            {
                var personas = dc.tbl_Persona.Where(per => per.per_estado == 'A');
                return personas.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
        //crear metodo para traer una persona escpecifico
        public static tbl_Persona Obtner_perXId(int codigoPers)
        {
            try
            {
                var personas = dc.tbl_Persona.FirstOrDefault(per => per.per_estado == 'A'
                                        && per.per_id.Equals(codigoPers));
                return personas;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
        //crear metodo para guardar personas 
        public static bool Guardar_Persona(tbl_Persona _infoPers)
        {
            try
            {
                bool resultado = false;
                dc.tbl_Persona.InsertOnSubmit(_infoPers);
                dc.SubmitChanges();
                resultado = true;
                return resultado;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
    }
}
