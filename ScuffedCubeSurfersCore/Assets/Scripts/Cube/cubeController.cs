using UnityEngine;
using UnityEngine.SceneManagement;

public class cubeController : MonoBehaviour
{   

    [SerializeField] private charStackController charStackController;

    private Vector3 direction = Vector3.back;

    private bool isStack = false;

    private RaycastHit hit;

    // private Vector3 Boxedge1 = new Vector3(transform.x/2,transform.y,transform,z)
    
    void Start()
    {
        charStackController = GameObject.FindObjectOfType<charStackController>();
    }

    void FixedUpdate()
    {
        SetCubeRaycast();
        // SetCubeBoxcast();
    }


    private void SetCubeRaycast()
    {
        if(Physics.Raycast(transform.position, direction, out hit, 0.06f))
        {   
            Debug.DrawRay(transform.position, Vector3.back, Color.green);
            if(!isStack)
            {
                isStack = true;
                charStackController.IncreaseStack(gameObject);
                SetDirection();
                Debug.Log("Picked up: FriendCube");
            }

            switch (hit.transform.name)
            {
                case "ScoreCubeX2":
                charStackController.DecreaseStackButKeepTheLastBoxNumber(gameObject);
                PlayerPrefs.SetInt("FinalMultiplier",2);
                Destroy(gameObject);
                Debug.Log("Picked up: ScoreCubeX2");
                break;

                case "ScoreCubeX3":
                charStackController.DecreaseStackButKeepTheLastBoxNumber(gameObject);
                PlayerPrefs.SetInt("FinalMultiplier",3);
                Destroy(gameObject);
                Debug.Log("Picked up: ScoreCubeX3");
                break;

                case "ScoreCubeX4":
                charStackController.DecreaseStackButKeepTheLastBoxNumber(gameObject);
                PlayerPrefs.SetInt("FinalMultiplier",4);
                Destroy(gameObject);
                Debug.Log("Picked up: ScoreCubeX4");
                break;

                case "ScoreCubeX5":
                charStackController.DecreaseStackButKeepTheLastBoxNumber(gameObject);
                PlayerPrefs.SetInt("FinalMultiplier",5);
                Destroy(gameObject);
                Debug.Log("Picked up: ScoreCubeX5");
                break;

                case "ScoreCubeX6":
                charStackController.DecreaseStackButKeepTheLastBoxNumber(gameObject);
                PlayerPrefs.SetInt("FinalMultiplier",6);
                Destroy(gameObject);
                Debug.Log("Picked up: ScoreCubeX6");
                break;

                case "DangerCube":
                charStackController.DecreaseStack(gameObject);
                Destroy(gameObject);
                Debug.Log("Picked up: DangerCube");
                break;

                case "WinCube":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("Game Completed"); 
                break;

                default:
                break;
                
            }
        }

        if(Physics.Raycast(transform.position, Vector3.down, out hit, 0.06f))
        {
            Debug.DrawRay(transform.position, Vector3.down, Color.red);

            if(hit.transform.name == "DangerGround")
            {
                charStackController.DecreaseStack(gameObject);
                Destroy(gameObject);
                Debug.Log("Walked on: DangerGround");
            }
        }
    }

    // private void SetCubeBoxcast()
    // {
    //     if(Physics.BoxCast(transform.position,transform.lossyScale/100, direction, out hit, transform.rotation, 0.06f))
    //     {
    //         if(!isStack)
    //         {
    //             isStack = true;
    //             charStackController.IncreaseStack(gameObject);
    //             SetDirection();
    //         }

    //         if (hit.transform.name == "DangerCube")
    //         {
    //             charStackController.DecreaseStack(gameObject);
    //         }
    //     }
    // }

    // private void OnDrawGizmos()
    // {
    //     RaycastHit hit;
    //     float maxDistance = 0.003f;

    //     bool isHit = Physics.BoxCast(transform.position,transform.lossyScale/20, direction, out hit, transform.rotation, maxDistance);
    //     {
    //         if(isHit)
    //         {
    //             Gizmos.color = Color.red;
    //             Gizmos.DrawRay(transform.position, direction* hit.distance);
    //             Gizmos.DrawWireCube(transform.position + direction * hit.distance, transform.lossyScale/20);
            
    //             if(!isStack)
    //         {
    //             isStack = true;
    //             charStackController.IncreaseStack(gameObject);
    //             SetDirection();
    //         }

    //         if (hit.transform.name == "DangerCube")
    //         {
    //             charStackController.DecreaseStack(gameObject);
    //         }
    //         }
    //         else
    //         {
    //             Gizmos.color = Color.green;
    //             Gizmos.DrawRay(transform.position, direction*maxDistance);
    //         }
            
    //     }
    // }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}
