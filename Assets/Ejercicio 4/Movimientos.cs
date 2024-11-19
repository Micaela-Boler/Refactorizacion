using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IMovimiento
{
    void Ejecutar();
}


public class Caminar : RealizarMovimiento, IMovimiento
{
    public void Ejecutar()
    {
        float movimiento_x = Input.GetAxis("Horizontal");
        fisicas.velocity = new Vector2(movimiento_x, 0);
    }
}


public class Salto : RealizarMovimiento, IMovimiento
{
    private float jumpForce;

    public void Ejecutar()
    {
        fisicas.AddForce(Vector2.up * jumpForce);
        Debug.Log("Estoy saltando Wiiii");
        estaSaltando = true;
    }
}


public class Rotación : MonoBehaviour, IMovimiento
{
    private float Z;

    public void Ejecutar()
    {
        Z += Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(0, 0, Z);
    }
}
