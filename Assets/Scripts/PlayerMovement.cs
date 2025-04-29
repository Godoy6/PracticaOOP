using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador
    private Rigidbody2D rb2D; // Componente "Rigidbody2D" para mover al jugador

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); // Obtener el "Rigidbody2D" del jugador para manipularlo
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // Movimiento en el eje X (izquierda/derecha)
        float moveY = Input.GetAxisRaw("Vertical"); // Movimiento en el eje Y (arriba/abajo)

        Vector2 moveDirection = new Vector2(moveX, moveY); // Crear un vector de dirección usando las entradas de teclado

        rb2D.velocity = moveDirection * speed; // Multiplicamos la dirección por la velocidad
    }
}