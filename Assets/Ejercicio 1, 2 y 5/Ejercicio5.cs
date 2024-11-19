using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public ActivarMision miMision;

    private void Awake()
    {
        miMision = new MisionNula();
    }

    public void EmpezarMision(MisionNula mission)
    {
        mission.StartMission();
    }


    public class ActivarMision : MonoBehaviour
    {
        public virtual void StartMission()
        {
            Debug.Log("Comenzar");
        }

        public virtual void CompleteMission()
        {
            Debug.Log("Logica de la Mision");
        }
    }


    public class MisionNula : ActivarMision
    {
        public MisionNula() { }

        public override void StartMission()
        {
            Debug.Log("Mision nula");
        }
    }


    /* 
     * - Si los métodos Start y Update no contienen una lógica dentro de ellos es mejor borrarlos.
     * - Para no utilizar un if para confirmar si un objeto no es nulo se puede crear un objeto nulo que lo reemplece.
     */
}
