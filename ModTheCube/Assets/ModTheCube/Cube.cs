using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    // Rastgele rotasyon hızları
    private float rotationSpeedX;
    private float rotationSpeedY;
    private float rotationSpeedZ;

    void Start()
    {
        // Küpün konumunu ayarlama
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        // Rastgele rotasyon hızlarını ayarlama
        rotationSpeedX = Random.Range(5.0f, 20.0f);
        rotationSpeedY = Random.Range(5.0f, 20.0f);
        rotationSpeedZ = Random.Range(5.0f, 20.0f);

        Material material = Renderer.material;

        // Başlangıç rengi
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }

    void Update()
    {
        // Rastgele belirlenen hızlarda rotasyon
        transform.Rotate(rotationSpeedX * Time.deltaTime, rotationSpeedY * Time.deltaTime, rotationSpeedZ * Time.deltaTime);

        // Renk değiştirme (zamanla sürekli değişen renk)
        float r = Mathf.PingPong(Time.time * 0.5f, 1.0f);
        float g = Mathf.PingPong(Time.time * 0.7f, 1.0f);
        float b = Mathf.PingPong(Time.time * 0.9f, 1.0f);

        Renderer.material.color = new Color(r, g, b, 0.8f); // Opaklık biraz artırıldı
    }
}
