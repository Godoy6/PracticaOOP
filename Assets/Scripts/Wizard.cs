using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Character
{
    private float damageMultiplier; // Atributo privado para el multiplicador de daño

    public Wizard(float damageMultiplier, string name) // Constructor de Wizard
    {
        SetName(name); // Usamos el setter para establecer el nombre
        _damage = 20f; // El daño base de Wizard es 20
        this.damageMultiplier = damageMultiplier; // Establecemos el valor de "damageMultiplier"
    }

    public override float Attack() // Sobrescribimos el método "Attack()"
    {
        return _damage * damageMultiplier; // El daño es multiplicado por "damageMultiplier"
    }

    public override float Heal() // Sobrescribimos el método "Heal()"
    {
        float healAmount = Random.Range(_damage, _damage * damageMultiplier); // Curación aleatoria entre daño y daño * "damageMultiplier"
        health += healAmount; // Aumentamos la salud con la cantidad curada

        if (health > 100f) // Nos aseguramos de que la salud no pase de 100
        {
            health = 100f; // Ajustamos la salud a 100 si supera el máximo
        }
        return health; // Devolvemos la salud actual
    }
}