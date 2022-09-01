using System;

namespace SRP
{
   public class ShelveCorrection{
    
/* El principio de responsabilidad única establece que cada clase debe tener responsabilidad
 sobre una parte  de la funcionalidad proporcionada por el software, y que la responsabilidad 
 debe estar completamente encapsulada por la clase. 

 En esta clase se ejerce la responsabilidad de determinar la ubicación para un libro dentro de la Bibloteca.
 Colabora con la clase BookCorrection ya que se utiliza la identidad del libro para determinar su ubicación.

 Agregamos un override string para que el usuario pueda crear una instancia en libro en el sistema y devuelva
 la identidad del libro.
*/
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public void ShelveBook(string sector, string shelve){
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
   } 
}