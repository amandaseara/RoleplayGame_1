using System.Collections;
namespace Roleplay
{
    // El principio utilizado para el equipamiento es SRP, ya que tienen la unica responsabilidad de crearse a sí mismos.
    public class Baculo
    {
        // el baculo es un equipamiento especial unico del mago, por lo que no tiene los mismos atributos que los otros items. El mismo tiene la funcion de amplificar los hechizos con un atributo llamado poder, el cual aumenta el daño proveniente de hechizos.
        private int poder;
        // aumenta el daño proveniente de hechizos
        public int Poder{get{return poder;}}
        // get del poder del baculo
        
        public Baculo (int poder)
        {
            this.poder = poder;
        }
    }
}        
