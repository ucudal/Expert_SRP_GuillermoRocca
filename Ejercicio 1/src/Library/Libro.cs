using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

/*  El principio de responsabilidad única establece que cada clase debe tener responsabilidad
 sobre una parte  de la funcionalidad proporcionada por el software, y que la responsabilidad 
 debe estar completamente encapsulada por la clase. 

 En esta clase se ejerce la responsabilidad de identificar un libro por su título, autor y código lo cual conforma
 una especie de identificación del libro en el sistema. A mi entender e interpretar pese a que la letra no aclara
 debe tener varios estados, no únicamente la ubicación. Por ejemplo un libro ingresado en el sistema puede estar alquilado,
 extraviado, fuera de circulación u  otras razones. Por otro lado también puede pasar que los libros vayan rotando
 de ubicación y esta no sea fija.

 Por lo tanto de esta forma existirían mas de una razón para que la clase cambie, y la única razón por que la
 clase debería cambiar refiere a la identidad del libro en cuestión. Otorgada por el constructor. Esta clase 
 colaboraría con otra clase que si debería asginar la ubicación del libro en la biblioteca. 
*/
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
/*Debería existir otra clase ShelveBook que sea la indicada de otorgarle a cada libro un estado de ubicación con
la referencia del sector y estantería. Esa sería su responsabilidad.
*/
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        
    }
}