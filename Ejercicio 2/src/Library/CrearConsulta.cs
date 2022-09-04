using System;
using System.Text;

namespace Library 
{ 

    public class Consulta{
        /* Tarjeta CRC
    Nombre: Consulta                 Colaboraciones:  DatosDoctor, DatosPersonales
    Resp: 
    - Crear consulta
    - Agregar identificación a la consulta
    - Validar estos datos
    */

// Definiendo una variable static de identidad logramos que para cada Consulta diferente que sea agregada
// se adjudica un número de id. Adjudicado por el sistema e irrepetible para conocer la orden de consulta
        public static int IdConsulta =  0;
        public static string CrearConsulta(DatosPersonales datosP, DatosDoctor datosD, DateTime date)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(datosP.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(datosP.Phone))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(datosD.Location))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(datosD.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled\n");
                IdConsulta++;

                stringBuilder.Append("id Consult:" + IdConsulta);
            }

            return stringBuilder.ToString();

        }
    }

}