using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGenerator : MonoBehaviour
{
    public GameObject bushPrefab;          // Prefab de arbusto a instanciar
    public int rows = 5;                   // N�mero de filas en la cuadr�cula
    public int cols = 5;                   // N�mero de columnas en la cuadr�cula
    public float spacing = 2f;             // Espaciado entre los arbustos
    public float combatChance = 0.3f;      // Probabilidad de que el arbusto tenga un componente de combate
    public SpriteRenderer backgroundSprite;  // SpriteRenderer del fondo (asignado en el Inspector)

    void Start()
    {
        GenerateBushes();
    }

    // M�todo para generar los arbustos dentro del �rea del fondo
    void GenerateBushes()
    {
        // Obtener el tama�o del fondo desde el SpriteRenderer
        Vector2 backgroundSize = backgroundSprite.bounds.size;

        // Obtener la posici�n del fondo
        Vector3 backgroundWorldPos = backgroundSprite.transform.position;

        // Recorrer las filas y columnas para generar los arbustos
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Calcular la posici�n en la cuadr�cula de arbustos
                float xOffset = (i - (rows / 2)) * spacing;
                float yOffset = (j - (cols / 2)) * spacing;

                // Asegurarse de que las posiciones est�n dentro del �rea del fondo
                Vector3 position = backgroundWorldPos + new Vector3(xOffset, yOffset, 0);

                // Comprobar si la posici�n calculada est� dentro del fondo
                if (Mathf.Abs(position.x - backgroundWorldPos.x) <= backgroundSize.x / 2 &&
                    Mathf.Abs(position.y - backgroundWorldPos.y) <= backgroundSize.y / 2)
                {
                    // Instanciar el arbusto en la posici�n calculada
                    GameObject bush = Instantiate(bushPrefab, position, Quaternion.identity);
                }
            }
        }
    }
}