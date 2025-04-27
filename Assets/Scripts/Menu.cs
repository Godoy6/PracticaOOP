using UnityEngine;
using UnityEngine.UI;  // Necesario para trabajar con UI
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public InputField nameInputField; // Campo de texto para el nombre
    public Dropdown classDropdown;    // Dropdown para elegir la clase
    public Button startButton;        // Bot�n para iniciar el juego

    private GameManager gameManager;

    void Awake()
    {
        // Buscar los componentes en la escena de manera program�tica
        if (nameInputField == null)
            nameInputField = GameObject.Find("InputFieldName").GetComponent<InputField>();  // Reemplaza "InputFieldName" con el nombre del objeto en tu jerarqu�a

        if (classDropdown == null)
            classDropdown = GameObject.Find("ClassDropdown").GetComponent<Dropdown>();  // Reemplaza "ClassDropdown" con el nombre de tu Dropdown en la jerarqu�a

        if (startButton == null)
            startButton = GameObject.Find("StartButton").GetComponent<Button>();  // Reemplaza "StartButton" con el nombre de tu bot�n en la jerarqu�a
    }

    void Start()
    {
        gameManager = GameManager.instance;

        // Configurar las opciones del Dropdown (si no se han configurado en el Inspector)
        classDropdown.ClearOptions();
        classDropdown.AddOptions(new System.Collections.Generic.List<string> { "Cowboy", "Wizard" });

        // Agregar un listener para el bot�n "Start"
        startButton.onClick.AddListener(StartGame);
    }

    public void StartGame()
    {
        // Obtener el nombre del jugador desde el InputField
        string playerName = nameInputField.text;

        // Comprobar que el nombre no est� vac�o
        if (string.IsNullOrEmpty(playerName))
        {
            Debug.LogWarning("Por favor, ingresa tu nombre.");
            return;
        }

        // Obtener la clase seleccionada desde el Dropdown
        int selectedClassIndex = classDropdown.value;
        GameManager.CharacterType selectedClass = (selectedClassIndex == 0) ? GameManager.CharacterType.Cowboy : GameManager.CharacterType.Wizard;

        // Pasar la informaci�n al GameManager
        gameManager.SetPlayerName(playerName);
        gameManager.SetPlayerClass(selectedClass);

        // Cargar la escena del juego
        SceneManager.LoadScene("SampleScene");
    }
}