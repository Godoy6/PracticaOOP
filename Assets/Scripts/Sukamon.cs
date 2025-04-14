using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukamon : Character
{
    public Sukamon() // Constructor de Sukamon (con 1 de daño por defecto)
    {
        _damage = 1f; // El daño por defecto para Sukamon es 1
    }

    public override float Attack() // Método Attack() para Sukamon
    {
        if (health < 5f) // Si la salud de Sukamon es menor a 5, hace 100 de daño
        {
            return 100f; // Hace 100 de daño
        }
        else
        {
            return _damage; // Si no, hace el daño normal (1)
        }
    }

    public override float Heal() // Método Heal() para Sukamon
    {
        // Se cura un tercio del daño que hace Sukamon
        float healAmount = Attack() / 3f; // La curación es un tercio del daño

        health += healAmount; // Se aumenta la salud

        if (health > 100f) // Nos aseguramos de que la salud no supere el máximo de 100
        {
            health = 100f;
        }
        return health;
    }
}
