using UnityEngine;

public class cameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform charTransform;

    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField] private float lerpValue;


    void Start()
    {
        offset = transform.position - charTransform.position;
    }

    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private  void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, 4.25f, charTransform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
