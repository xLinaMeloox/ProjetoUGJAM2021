using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    void Start()
    {
        //pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);

    }

    public void Sair()
    {
        Application.Quit();

    }
}
