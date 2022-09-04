using System;

namespace SRP
{
    public class BookCorrection
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

/*  El principio de responsabilidad única establece que cada clase debe tener responsabilidad
 sobre una parte  de la funcionalidad proporcionada por el software, y que la responsabilidad 
 debe estar completamente encapsulada por la clase. 

 En esta clase se ejerce la responsabilidad de identificar un libro por su título, autor y código lo cual conforma
 una especie de identificación del libro en el sistema.

 Agregamos un return para que el usuario pueda crear una instancia en libro en el sistema y devuelva
 la identidad del libro si este lo desea.
*/
        public BookCorrection(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
/* Dentro de esta clase agregamos un método setShelve el cual recibe la colaboración de la clase ShelveCorrection. 
Su responsabilidad es que para un libro dado por esta clase, se asigne una ubucación del libro.
*/
        public ShelveCorrection setShelve(ShelveCorrection shelve){
            return shelve;
        }

        public override string ToString() 
        {
        return  $"Nombre {this.Title}\nAutor {this.Author}, \nCódigo: \n{this.Code} ";       
        }   
        }
}
