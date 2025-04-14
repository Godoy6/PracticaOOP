using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy : Character
{
    public Cowboy(string name) // Constructor de Cowboy (con 15 de daño por defecto)
    {
        SetName(name); // Usamos el setter para establecer el nombre
        _damage = 15f; // Accedemos directamente a _damage porque es protegido
    }

    public override float Attack() // Método Attack() sobrescrito para Cowboy
    {
        float randomMultiplier = Random.Range(1f, 1.5f);
        return _damage * randomMultiplier; // Accedemos directamente a _damage porque es protegido
    }

    public override float Heal() // Método Heal() sobrescrito para Cowboy
    {
        health += 10f;
        if (health > 100f)
        {
            health = 100f;
        }
        return health;
    }
}