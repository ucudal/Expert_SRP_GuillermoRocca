using System;
using System.Text;

namespace Library
{
    /*Correción y crítica:

1) En una única clase se asignan responsabilidades de todos los atributos que se ejecutan para una instancia
de CretateAppoinment. Esto no es recomendable debido a que una vez creada la consulta no se permite 
realizar cambios. No cumpliendo con el principio SRP, ya que o de esta forma existirían mas de una razón 
para que la clase cambie, y la única razón por que la clase debería cambiar refiere a la identidad 
de la consulta. Luego simplemente recibe y válida una orden a partir de que todos sus atributos fueron dados y definidos
correctamente.
2) El sistema creado de esta manera limtia las posibilidades del software de ejecutar otras funciones como crear
un comprobante de consulta por ejemplo. Los datos personales del usuario pueden representar de un gran valor 
por lo que deberían almacenarse en una instancia de una clase y no en una variable del constructor CreateAppoinment.
3) La identidad de la consulta debe ser otorgada por el sistema, generando una identidad propia para cada consulta
creada. Que sea inmutable y que no corresponda al usuario.
5) Deberían crearse clases exclusivamente orientadas en validar y clasificar los atributos de CreateAppoinmente. 
Clases que colaboren con una clase CreateAppoinment pero que tengan la responsabilidad de crear una plantilla
para definir los Datos Personales, Datos Doctores y demás
6)Creando una base de datos de identidades de socios que piden consulta y medicos el software sería más practico
que repetir los datos cada vez que se quiera una consulta con tal doctor. */
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
