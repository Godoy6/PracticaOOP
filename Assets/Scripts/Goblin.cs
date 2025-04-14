using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Character
{
    public Goblin() // Constructor del Goblin (con 10 de da�o por defecto)
    {
        _damage = 10f; // El da�o por defecto para un Goblin es 10
    }

    public override float Attack() // Sobrescribir el m�todo Attack()
    {
        if (health < 20f) // Si la salud del Goblin es menor a 20, hace el triple de da�o
        {
            return _damage * 3f; // Hace el triple de da�o
        }
        else
        {
            return _damage; // Si no, hace el da�o normal
        }
    }

    public override float Heal() // Sobrescribir el m�todo Heal()
    {
        float healAmount = Attack() / 2f; // La curaci�n es la mitad del da�o
        health += healAmount;

        if (health > 100f) // Nos aseguramos de que la salud no sobrepase 100
        {
            health = 100f;
        }
        return health;
    }
}