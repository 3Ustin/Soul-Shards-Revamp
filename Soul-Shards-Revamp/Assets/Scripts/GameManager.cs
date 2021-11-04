using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Button;
    public GameObject GameMenu;
    public GameObject OptionsMenu;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
    }
    
    // Start is called before the first frame update
    public void OpenGame()
    {
        SceneManager.LoadScene(0,LoadSceneMode.Single);
    }
    public void OpenOptionsMenu(){
        Debug.Log("OptionsMenu Has been Opened.");
        GameMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }
    public void OpenGameMenu(){
        Debug.Log("GameMenu Has been Opened.");
        GameMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }
    public void QuitGame(){
        Debug.Log("Quitting the Game");
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }


}
