using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGenerator : MonoBehaviour
{
    public GameObject bushPrefab;          // Prefab de arbusto a instanciar
    public int rows = 5;                   // Número de filas en la cuadrícula
    public int cols = 5;                   // Número de columnas en la cuadrícula
    public float spacing = 2f;             // Espaciado entre los arbustos
    public float combatChance = 0.3f;      // Probabilidad de que el arbusto tenga un componente de combate
    public SpriteRenderer backgroundSprite;  // SpriteRenderer del fondo (asignado en el Inspector)

    void Start()
    {
        GenerateBushes();
    }

    // Método para generar los arbustos dentro del área del fondo
    void GenerateBushes()
    {
        // Obtener el tamaño del fondo desde el SpriteRenderer
        Vector2 backgroundSize = backgroundSprite.bounds.size;

        // Obtener la posición del fondo
        Vector3 backgroundWorldPos = backgroundSprite.transform.position;

        // Recorrer las filas y columnas para generar los arbustos
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Calcular la posición en la cuadrícula de arbustos
                float xOffset = (i - (rows / 2)) * spacing;
                float yOffset = (j - (cols / 2)) * spacing;

                // Asegurarse de que las posiciones estén dentro del área del fondo
                Vector3 position = backgroundWorldPos + new Vector3(xOffset, yOffset, 0);

                // Comprobar si la posición calculada está dentro del fondo
                if (Mathf.Abs(position.x - backgroundWorldPos.x) <= backgroundSize.x / 2 &&
                    Mathf.Abs(position.y - backgroundWorldPos.y) <= backgroundSize.y / 2)
                {
                    // Instanciar el arbusto en la posición calculada
                    GameObject bush = Instantiate(bushPrefab, position, Quaternion.identity);
                }
            }
        }
    }
}