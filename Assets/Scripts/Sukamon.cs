using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukamon : Character
{
    public Sukamon() // Constructor de "Sukamon" (con 1 de da�o por defecto)
    {
        _damage = 1f; // El da�o por defecto para "Sukamon" es 1
    }

    public override float Attack() // M�todo "Attack()" para Sukamon
    {
        if (health < 5f) // Si la salud de "Sukamon" es menor a 5, hace 100 de da�o
        {
            return 100f; // Hace 100 de da�o cuando la salud es cr�tica
        }
        else
        {
            return _damage; // Si no, hace el da�o normal (1)
        }
    }

    public override float Heal() // M�todo "Heal()" para "Sukamon"
    {
        float healAmount = Attack() / 3f; // La curaci�n es un tercio del da�o hecho

        health += healAmount; // Aumentamos la salud con la cantidad calculada

        if (health > 100f) // Nos aseguramos de que la salud no supere el m�ximo de 100
        {
            health = 100f; // Ajustamos la salud a 100 si excede el m�ximo
        }
        return health; // Devolvemos la salud actual
    }
}