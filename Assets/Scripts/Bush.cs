using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    public float combatChance = 0.3f; // Probabilidad de que el arbusto inicie la batalla

    // M�todo para detectar la colisi�n con el jugador
    void OnTriggerEnter2D(Collider2D other)
    {
        // Verificamos si el objeto tiene el script PlayerMovement
        if (other.GetComponent<PlayerMovement>() != null)
        {
            if (Random.value < combatChance) // Si el n�mero aleatorio es menor que la probabilidad de combate
            {
                Debug.Log("HA EMPEZADO LA BATALLA"); // Muestra el mensaje
            }
        }
    }
}