using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterInformation : MonoBehaviour
{
    public void Informacion(Ejercicio2 player)
    {
        Debug.Log(player.Name);
        Debug.Log(player.Hp);
        Debug.Log(player.Attack);
        Debug.Log(player.Defense);
    }
}


public class Ejercicio2 : MonoBehaviour
{
    private string name;
    private int hp;
    private int attack;
    private int defense;

    public string Name => name;
    public int Hp => hp;
    public int Attack => attack;
    public int Defense => defense;

    public bool isDead;



    public void TakingDamage(int attack, int damageDealt)
    {
        if (!isDead)
        {
            damageDealt = attack - defense;

            if (damageDealt > 0)
            {
                hp -= damageDealt;

                if (hp <= 0)
                {
                    isDead = true;
                }
            }
        }
    }


    public void Heal()
    {
        if (!isDead)
        {
            hp += 15;
        }
    }
}


/*
 * - Los m�todos "Attack" y "CastSpell" tienen una l�gica muy similiar, por eso es necesario crear un m�todo que contenga par�metros. De esta forma
 *   se evita la duplicaci�n de c�digo. 
 * - El m�todo "Informaci�n" contiene demasiados par�metros. Para evitarlo, podemos hacer que el m�todo use un par�metro del tipo "Ejercicio2" y que desde ah� 
 *   extraiga la informaci�n. 
 */
