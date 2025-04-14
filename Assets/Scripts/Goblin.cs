using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Character
{
    public Goblin() // Constructor del Goblin (con 10 de daño por defecto)
    {
        _damage = 10f; // El daño por defecto para un Goblin es 10
    }

    public override float Attack() // Sobrescribir el método Attack()
    {
        if (health < 20f) // Si la salud del Goblin es menor a 20, hace el triple de daño
        {
            return _damage * 3f; // Hace el triple de daño
        }
        else
        {
            return _damage; // Si no, hace el daño normal
        }
    }

    public override float Heal() // Sobrescribir el método Heal()
    {
        float healAmount = Attack() / 2f; // La curación es la mitad del daño
        health += healAmount;

        if (health > 100f) // Nos aseguramos de que la salud no sobrepase 100
        {
            health = 100f;
        }
        return health;
    }
}