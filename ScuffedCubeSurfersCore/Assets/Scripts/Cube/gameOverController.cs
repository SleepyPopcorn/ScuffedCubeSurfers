using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverController : MonoBehaviour
{
    private RaycastHit hit;

    void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {
        if(Physics.Raycast(transform.position, Vector3.forward, out hit, 0.06f))
        {   
            Debug.DrawRay(transform.position, Vector3.down, Color.red);
             if(hit.transform.name == "WinCube")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("Game Completed"); 
            }

            if (hit.transform.name == "DangerCube")
            {   
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                Debug.Log("You Failed");
            }
        }
    }
}
