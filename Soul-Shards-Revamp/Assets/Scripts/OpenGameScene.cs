using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGameScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenGame()
    {
        SceneManager.LoadScene(0);
    }

}
