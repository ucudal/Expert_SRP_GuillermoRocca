using System;

namespace SRP
{

    class Program
    {

        //En program simplemente creamos la identidad de libros, asignándoles ubicación.
        //También ejecutamos los metodos de impresión para verificar que nos devuelve los valores asignados
        static void Main()
        {
            BookCorrection book1 = new BookCorrection("Design Patterns","Erich Gamma & Others","001-034");
            BookCorrection book2 = new BookCorrection("Pro C#","Troelsen","001-035");
            ShelveCorrection Shelve1 = new ShelveCorrection("A","7");
            book1.setShelve(Shelve1);
            Console.WriteLine(book1.setShelve(Shelve1));
        }
    }
}