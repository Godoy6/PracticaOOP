using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con UI (Dropdown, InputField, Button)

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Instancia est�tica para implementar el patr�n Singleton

    void Awake()
    {
        /*SINGLETON*/
        if (!instance) // Si la instancia a�n no existe
        {
            instance = this; // Asigna esta instancia a la variable est�tica
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