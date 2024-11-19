using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Attack : MonoBehaviour
{
    public abstract void Ejecutar();
}


public class AtaqueFisico : Attack
{
    public override void Ejecutar()
    {
        Debug.Log("Logica de Ataque fisico");
    }
}
public class AtaqueMagico : Attack
{
    public override void Ejecutar()
    {
        Debug.Log("Logica de Ataque magico");
    }
}
public class Defensa : Attack
{
    public override void Ejecutar()
    {
        Debug.Log("Logica de defensa");
    }
}
