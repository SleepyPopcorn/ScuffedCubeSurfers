using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenuGetScore : MonoBehaviour
{
    public Text EndScore;

    int score = 0;
    int multiplier = 1;
    int finalscore = 0;

   
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("FinalScore",0);
        multiplier = PlayerPrefs.GetInt("FinalMultiplier",1);
        finalscore = score * multiplier;

        EndScore.text = "FINAL SCORE: " + finalscore.ToString();
    }

}
