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
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z); // Actualiza la posición de la cámara para seguir al jugador
    }
}