using UnityEngine;

public class UsarHabilidad : MonoBehaviour
{
    public void UseSkill(Attack type)
    {
        type.Ejecutar();
    }
}

/*
 * - Con el nombre que tienen los m�todos ya se entiende bien lo que hace cada uno, por eso se pueden borrar los comentarios.
 * - Si los m�todos Start y Update no contienen una l�gica dentro de ellos, es posible borrarlos.
 * - Si el proyecto se vuelve m�s grande, el switch utilizado puede ocupar demasiadas l�neas de c�digo y llegar a ser dif�cil de leer. 
 *   Esto se puede evitar a trav�s del polimorfismo.
*/

