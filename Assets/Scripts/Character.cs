using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float health = 100f; // Atributo público

    private Sprite _sprite; // Atributo privado
    private string _name; // Atributo privado

    protected float _damage; // Atributo protegido

    public void SetUpCharacterDefault() // Constructor por defecto
    {
        _name = "Default";
        _sprite = null;
        _damage = 10f;
        health = 100f;
    }

    public void SetUpCharacterParameters(string name, Sprite spr, float damage) // Constructor con parámetros
    {
        _name = name;
        _sprite = spr;
        _damage = damage;
        health = 100f;
    }

    public abstract float Attack(); // Método abstracto

    public virtual float Heal()
    {
        health += 10f; // Aumentamos la salud en 10 puntos

        if (health > 100f) // Nos aseguramos de que la salud no supere el máximo (100)
        {
            health = 100f; // Si la salud pasa de 100, la ajustamos a 100
        }
        return health;
    }

    public string GetName() 
    {
        return _name;
    }

    public Sprite GetSprite()
    {
        return _sprite;
    }

    public float GetDamage()
    {
        return _damage;
    }

    void Start()
    {

    }

    void Update()
    {

    }
}