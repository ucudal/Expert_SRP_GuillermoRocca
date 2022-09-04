using System;
using System.Text;

namespace Library {

    public class DatosPersonales
    {
    /* Tarjeta CRC
    Nombre: DatosPersonales                  Colaboraciones:  no tiene
    Resp: 
    - Conocer Nombre
    - Conocer Número
    - Opcion de agregar edad; por letra entiendo que es opcional. Agrego variable dada por metodo
    -Validar estos datos
    */
     public string Name { get;}
     public string Phone { get;}

     // Cosntructor de identidad paciente
     public DatosPersonales(string name, string phone){
        this.Name= name;
        this.Phone=phone;
     }
     public int AgregarEdad(int edad){
        return edad;
     }

    }



}

