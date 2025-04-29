using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con UI (Dropdown, InputField, Button)

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Instancia estática para implementar el patrón Singleton

    void Awake()
    {
        /*SINGLETON*/
        if (!instance) // Si la instancia aún no existe
        {
            instance = this; // Asigna esta instancia a la variable estática
            DontDestroyOnLoad(gameObject); // Hace que el objeto no se destruya al cargar una nueva escena
        }
        else
        {
            Destroy(gameObject); // Si ya existe una instancia, destruye este objeto
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
}