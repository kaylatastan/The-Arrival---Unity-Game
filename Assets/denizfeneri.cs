using UnityEngine;

public class LighthouseRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // derece/saniye

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
