using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string nameScene;
    public void ChangeS() {
        SceneManager.LoadScene(nameScene);
    }

    public void QuitScene()
    {
        Application.Quit();
    }

   
}
