using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Character
{
    private float damageMultiplier; // Atributo privado

    public Wizard(float damageMultiplier, string name) // Constructor de Wizard
    {
        SetName(name); // Usamos el setter para establecer el nombre
        _damage = 20f; // El da�o base de Wizard es 20
        this.damageMultiplier = damageMultiplier; // Establecemos el valor de damageMultiplier
    }

    public override float Attack() // Sobrescribimos el m�todo Attack()
    {
        return _damage * damageMultiplier; // El da�o es multiplicado por damageMultiplier
    }

    public override float Heal() // Sobrescribimos el m�todo Heal()
    {
        float healAmount = Random.Range(_damage, _damage * damageMultiplier); // Curaci�n aleatoria entre da�o y da�o * damageMultiplier
        health += healAmount;

        if (health > 100f) // Nos aseguramos de que la salud no pase de 100
        {
            health = 100f;
        }
        return health;
    }
}