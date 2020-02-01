using UnityEngine;

public class CameraScript : MonoBehaviour {

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float smoothSpeed = 0.125f;

    [SerializeField]
    private Vector3 offset;
    
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smootherPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); //smoothSpeed*Time.deltaTime
        transform.position = smootherPosition;
    }
}