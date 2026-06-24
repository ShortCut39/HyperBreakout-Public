using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private Button startButton;
    private Button exitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton = UIDocument.rootVisualElement.Q<Button>("StartButton");
       
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
