using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float forwardSpeed = 10.0f; // Uçağın ileri hareket hızı
    public float verticalSpeed = 5.0f; // Uçağın yukarı/aşağı hareket hızı
    public float rotationSpeed = 50.0f; // Uçağın dönüş hızı (yukarı/aşağı)

    private float verticalInput; // Yukarı/aşağı hareket girdisi

    void Update()
    {
        // 1. Yukarı ve aşağı yön için giriş al (W/S veya yukarı/aşağı ok)
        verticalInput = Input.GetAxis("Vertical");

        // 2. Uçağı sabit bir hızla ileri hareket ettir (X ekseninde ilerleme)
        MoveForward();

        // 3. Yukarı ve aşağı hareket için uçağı döndür (Z ekseninde dönüş)
        RotatePlane();

        // 4. Uçağın yukarı/aşağı hareketini kontrol et
        MoveUpDown();
    }

    void MoveForward()
    {
        // Uçak sürekli X ekseninde ileri hareket eder
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
    }

    void RotatePlane()
    {
        // Yukarı/aşağı hareket girdisi ile Z ekseninde dönüş sağla
        transform.Rotate(Vector3.left * rotationSpeed * verticalInput * Time.deltaTime);
    }

    void MoveUpDown()
    {
        // Uçak yukarı/aşağı hareket eder (Y ekseninde)
        transform.Translate(Vector3.up * verticalSpeed * verticalInput * Time.deltaTime);
    }
}

