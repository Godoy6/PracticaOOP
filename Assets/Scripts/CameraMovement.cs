using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player; // Referencia al "transform" del jugador

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z); // Actualiza la posici�n de la c�mara para seguir al jugador
    }
}