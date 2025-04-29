using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGenerator : MonoBehaviour
{
    public GameObject bushPrefab; // Prefab de arbusto a instanciar
    public int rows = 5; // N�mero de filas en la cuadr�cula
    public int cols = 5; // N�mero de columnas en la cuadr�cula
    public float spacing = 2f; // Espaciado entre los arbustos
    public SpriteRenderer backgroundSprite; // SpriteRenderer del fondo (asignado en el Inspector)

    void Start()
    {
        GenerateBushes();
    }

    void GenerateBushes() // M�todo para generar los arbustos dentro del �rea del fondo
    {
        Vector2 backgroundSize = backgroundSprite.bounds.size; // Obtener el tama�o del fondo desde el SpriteRenderer
        Vector3 backgroundWorldPos = backgroundSprite.transform.position; // Obtener la posici�n del fondo

        for (int i = 0; i < rows; i++) // Recorrer las filas y columnas para generar los arbustos
        {
            for (int j = 0; j < cols; j++)
            {
                float xOffset = (i - (rows / 2)) * spacing; // Calcular la posici�n en la cuadr�cula de arbustos
                float yOffset = (j - (cols / 2)) * spacing; // Calcular la posici�n en la cuadr�cula de arbustos

                Vector3 position = backgroundWorldPos + new Vector3(xOffset, yOffset, 0); // Asegurarse de que las posiciones est�n dentro del �rea del fondo

                // Comprobar si la posici�n calculada est� dentro del fondo
                if (Mathf.Abs(position.x - backgroundWorldPos.x) <= backgroundSize.x / 2 && Mathf.Abs(position.y - backgroundWorldPos.y) <= backgroundSize.y / 2)
                {
                    GameObject bush = Instantiate(bushPrefab, position, Quaternion.identity); // Instanciar el arbusto en la posici�n calculada
                }
            }
        }
    }
}