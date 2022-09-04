using System;
using System.Text;

namespace Library {

    public class DatosDoctor
    {
    /* Tarjeta CRC
    Nombre: DatosDoctor                  Colaboraciones:  no tiene
    Resp: 
    - Conocer Nombre Doctor
    - Opcion de agregar edad; por letra entiendo que es opcional. Agrego variable especialidad dada por metodo
    - En que policlínica trabaja
    -Validar estos datos
    - E
    */
     public string Name { get;}
     public string Location { get;}

     // Cosntructor de identidad paciente
     public DatosDoctor(string name, string location){
        this.Name= name;
        this.Location=location;
     }
     public string AgregarEspecialidad(string especialidad){
        return especialidad;
     }
    }
}