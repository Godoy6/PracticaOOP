using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float health = 100f;
    private Sprite _sprite;
    private string _name;
    protected float _damage;

    public void SetName(string name)
    {
        _name = name; // Asigna el nombre al personaje
    }

    public string GetName()
    {
        return _name; // Devuelve el nombre del personaje
    }

    public void SetUpCharacterDefault() // Constructor por defecto
    {
        _name = "Default"; // Nombre por defecto
        _sprite = null; // Sin imagen por defecto
        _damage = 10f; // Daño por defecto
        health = 100f; // Salud por defecto
    }

    public void SetUpCharacterParameters(string name, Sprite spr, float damage) // Constructor con parámetros
    {
        _name = name; // Asigna el nombre
        _sprite = spr; // Asigna la imagen
        _damage = damage; // Asigna el daño
        health = 100f; // Salud inicial
    }

    public abstract float Attack(); // Método abstracto que debe ser implementado en las clases hijas

    public virtual float Heal()
    {
        health += 10f; // Aumentamos la salud en 10 puntos

        if (health > 100f) // Nos aseguramos de que la salud no supere el máximo (100)
        {
            health = 100f; // Si la salud pasa de 100, la ajustamos a 100
        }
        return health; // Devuelve la salud actual
    }
}