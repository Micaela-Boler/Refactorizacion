using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealizarMovimiento : MonoBehaviour
{
    protected bool estaSaltando;
    protected Rigidbody2D fisicas;

    private Rotaci�n rotar;
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



    /* Las teclas D y A est�n realizando las mismas acciones y no necesitan estar dentro de un if para funcionar.
     * El m�todo "Movimiento" es demasiado largo y est� realizando muchas tareas a la vez. Es mejor dividirlo en distintas clases o m�todos.
     * Los comentarios hacen que el c�digo sea m�s dif�cil de leer y en algunos casos est�n explicando lo obvio. 
     * Algunas variables que fueron declaradas no se usan en el c�digo (por ejemplo, _Speed). Tambi�n el nombre de _Speed2 puede ser confuso, es mejor cambiarlo por otro que d� a entender que es la fuerza de salto.
     */

}
