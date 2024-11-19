using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealizarMovimiento : MonoBehaviour
{
    protected bool estaSaltando;
    protected Rigidbody2D fisicas;

    private Rotación rotar;
    private Caminar caminar;
    private Salto saltar;


    private void Start()
    {
        fisicas = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movimiento();
    }


    public void Movimiento()
    {
        EjecutarMovimiento(caminar);

        if (puedeSaltar())
            EjecutarMovimiento(saltar); ;

        if (Input.GetKeyDown(KeyCode.R))
            EjecutarMovimiento(rotar);
    }


    private void EjecutarMovimiento(IMovimiento movimiento)
    {
        movimiento.Ejecutar();
    }

    private bool puedeSaltar()
    {
        return !estaSaltando && Input.GetButton("Jump");
    }



    /* Las teclas D y A están realizando las mismas acciones y no necesitan estar dentro de un if para funcionar.
     * El método "Movimiento" es demasiado largo y está realizando muchas tareas a la vez. Es mejor dividirlo en distintas clases o métodos.
     * Los comentarios hacen que el código sea más difícil de leer y en algunos casos están explicando lo obvio. 
     * Algunas variables que fueron declaradas no se usan en el código (por ejemplo, _Speed). También el nombre de _Speed2 puede ser confuso, es mejor cambiarlo por otro que dé a entender que es la fuerza de salto.
     */

}
