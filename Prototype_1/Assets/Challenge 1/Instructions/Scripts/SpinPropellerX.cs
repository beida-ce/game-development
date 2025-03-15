using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 1000.0f; // Propeller's rotation speed

    void Update()
    {
        // Rotate the propeller around the Z axis every frame
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
