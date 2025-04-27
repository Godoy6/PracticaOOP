using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con UI (Dropdown, InputField, Button)

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Instancia estática del GameManager

    public string playerName; // Nombre del jugador
    public enum CharacterType { Cowboy, Wizard }
    public CharacterType selectedClass; // Clase seleccionada por el jugador

    void Awake()
    {
        // Implementar patrón Singleton
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // No destruir el GameManager al cargar nuevas escenas
        }
        else
        {
            Destroy(gameObject); // Destruir el objeto si ya existe una instancia
        }
    }

    public void SetPlayerName(string name)
    {
        playerName = name; // Guardar el nombre del jugador
    }

    public void SetPlayerClass(CharacterType characterType)
    {
        selectedClass = characterType; // Guardar la clase seleccionada
    }
}