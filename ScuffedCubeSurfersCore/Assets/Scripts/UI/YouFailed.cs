using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouFailed : MonoBehaviour
{
    public void TryAgain()
    {
        PlayerPrefs.SetInt("FinalScore",0);
        PlayerPrefs.SetInt("FinalMultiplier",1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void ReturnToMainMenu()
    {
        PlayerPrefs.SetInt("FinalScore",0);
        PlayerPrefs.SetInt("FinalMultiplier",1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

     public void Quit()
    {
        PlayerPrefs.SetInt("FinalScore",0);
        PlayerPrefs.SetInt("FinalMultiplier",1);
        Application.Quit();
    }
}
