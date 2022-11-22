using UnityEngine;

public class charInputController : MonoBehaviour
{
    private float horizontalValue;

    public float HorizontalValue
    {
        get {return horizontalValue;}
    }

    void Update()
    {
       HandleCharHorizontalInput();
    }

    private Touch touch;

    public Vector3 touchPos;

    private void HandleCharHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
           horizontalValue = 0;
        }
    }
}
