using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void LoadLevelOne()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void LoadLevelThree()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void LoadHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void LoadPlayerInfo()
    {
        SceneManager.LoadScene("PlayerInfo");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadWin()
    {
        SceneManager.LoadScene("Victory");
    }
}
