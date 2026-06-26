using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class Buttons : MonoBehaviour
{
   
    public UIDocument UIDocument;
    private Button startButton;
    private Button exitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       startButton = UIDocument.rootVisualElement.Q<Button>("StartButton");
       exitButton = UIDocument.rootVisualElement.Q<Button>("ExitButton");

       exitButton.clicked += ExitGame;
       startButton.clicked += EnterGame;

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void EnterGame()
    {
        
        SceneManager.LoadSceneAsync("Game");



    }

    void ExitGame()
    {

        Application.Quit();

    }
}
