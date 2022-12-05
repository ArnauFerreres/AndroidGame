using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
