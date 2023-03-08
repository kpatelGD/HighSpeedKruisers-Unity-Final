using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform carTransform;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - carTransform.position;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(carTransform.position.x + offset.x, carTransform.position.y + offset.y, transform.position.z);
    }
}

