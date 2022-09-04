using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos personales
            DatosPersonales p1 = new DatosPersonales("Steven Jhonson", "986782342" );
            DatosPersonales p2 = new DatosPersonales("", "98897364" );
            DatosPersonales p3 = new DatosPersonales("Federico Rodriguez", "986782678" );
            p3.AgregarEdad(43);
            

            //DatosDoctores
            DatosDoctor d1 = new DatosDoctor("Carlos Gonzales", "Policlínica Centro");
            DatosDoctor d2 = new DatosDoctor("Martin Costa", "Policlínica Centro");
            d2.AgregarEspecialidad("Traumatólogo");

            //Consultas
            string Consulta1 = Consulta.CrearConsulta(p1, d1, DateTime.Now);
            Console.WriteLine(Consulta1);

            string Consulta2 = Consulta.CrearConsulta(p2, d2, DateTime.Now);
            Console.WriteLine(Consulta2);

            string Consulta3 = Consulta.CrearConsulta(p3, d1, DateTime.Now);
            Console.WriteLine(Consulta3);

            // Se Computan las dos Consultas correctas y falla Consulta2 Como debe ser dado que faltan datos
            // Id consulta llega a 2 como debería ser.
        }
    }
}
