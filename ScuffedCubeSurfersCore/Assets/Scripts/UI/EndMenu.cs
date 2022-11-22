using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        PlayerPrefs.SetInt("FinalScore",0);
        PlayerPrefs.SetInt("FinalMultiplier",1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ReturnToMainMenu()
    {
        PlayerPrefs.SetInt("FinalScore",0);
        PlayerPrefs.SetInt("FinalMultiplier",1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Quit()
    {
        PlayerPrefs.SetInt("FinalScore",0);
        PlayerPrefs.SetInt("FinalMultiplier",1);
        Application.Quit();
    }
}
