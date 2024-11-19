using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public float Fuerza = 100f;
    private float moveSpeed = 5f;
    public float speed;

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        Vector3 movement = new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }


    /*
    - La variable "rb_2d" nunca se usa, por lo tanto es posible borrarla.
    - Los comentarios no son necesarios porque el código desarrollado es simple y corto.
    - Las líneas de código que estaban dentro de Update se pueden mover a un método nuevo. Ahora si solo queremos cambiar algo relacionado con 
      el movimiento simplemente debemos de modificar el método "Movement".
    */
}

