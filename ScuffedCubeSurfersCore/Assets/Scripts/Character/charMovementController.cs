using UnityEngine;
using UnityEngine.SceneManagement;

public class charMovementController : MonoBehaviour
{
    [SerializeField] private charInputController charInputController;

    [SerializeField] private float forwardMoveSpeed;
    [SerializeField] private float horizontalMoveSpeed;
    [SerializeField] private float horizontalLimitValue;

    private float newPositionX;

    void Start()
    {
    }
    void FixedUpdate()
    {
        SetCharForwardMovement();
        SetCharHorizontalMovement();
    }

    private void SetCharForwardMovement()
    {
        transform.Translate(Vector3.forward * forwardMoveSpeed * Time.fixedDeltaTime);
    }

    private void SetCharHorizontalMovement()
    {
        newPositionX = transform.position.x + charInputController.HorizontalValue * horizontalMoveSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
