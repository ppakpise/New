using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void switchScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
