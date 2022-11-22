using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text CubeText;
    public Text GemText;

    [SerializeField] int cubes = 0;
    [SerializeField] int gems = 0;


    

    private void Awake()
    {
            instance = this;      
    }

    // Start is called before the first frame update
    void Start()
    {
        CubeText.text = cubes.ToString() + " CUBES";
        GemText.text = gems.ToString() + " GEMS";
    }

    public void AddCube()
    {
        cubes += 1;
        CubeText.text = cubes.ToString() + " CUBES";
        PlayerPrefs.SetInt("FinalScore", gems + cubes);
    }

    public void DecreaseCube()
    {
        cubes -= 1;
        CubeText.text = cubes.ToString() + " CUBES";
        PlayerPrefs.SetInt("FinalScore", gems + cubes);
    }

    public void AddGem()
    {
        gems += 1;
        GemText.text = gems.ToString() + " GEMS";
        PlayerPrefs.SetInt("FinalScore", gems + cubes);

    }

    public void DecreaseGem()
    {
        gems -= 1;
        GemText.text = gems.ToString() + " GEMS";
        PlayerPrefs.SetInt("FinalScore", gems + cubes);
        
    }
    
}
