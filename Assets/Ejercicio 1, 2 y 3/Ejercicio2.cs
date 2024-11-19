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
 * - Los métodos "Attack" y "CastSpell" tienen una lógica muy similiar, por eso es necesario crear un método que contenga parámetros. De esta forma
 *   se evita la duplicación de código. 
 * - El método "Información" contiene demasiados parámetros. Para evitarlo, podemos hacer que el método use un parámetro del tipo "Ejercicio2" y que desde ahí 
 *   extraiga la información. 
 */
