using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.InputSystem;

public class SceneController : MonoBehaviour
{
    public string goToScene = "HomeScene";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(goToScene);
        }
    }
}
