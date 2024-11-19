using UnityEngine;

public class UsarHabilidad : MonoBehaviour
{
    public void UseSkill(Attack type)
    {
        type.Ejecutar();
    }
}

/*
 * - Con el nombre que tienen los métodos ya se entiende bien lo que hace cada uno, por eso se pueden borrar los comentarios.
 * - Si los métodos Start y Update no contienen una lógica dentro de ellos, es posible borrarlos.
 * - Si el proyecto se vuelve más grande, el switch utilizado puede ocupar demasiadas líneas de código y llegar a ser difícil de leer. 
 *   Esto se puede evitar a través del polimorfismo.
*/

