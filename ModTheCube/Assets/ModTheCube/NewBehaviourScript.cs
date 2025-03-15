using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public MeshRenderer Renderer;

    void Start()
    {
        Material material = Renderer.material;

        // Baþlangýç rengi
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }

    void Update()
    {
        // Renk deðiþtirme (zamanla sürekli deðiþen renk)
        float r = Mathf.PingPong(Time.time * 0.3f, 1.0f);
        float g = Mathf.PingPong(Time.time * 0.3f, 1.0f);
        float b = Mathf.PingPong(Time.time * 0.1f, 1.0f);

        Renderer.material.color = new Color(r, g, b, 0.8f); // Opaklýk biraz artýrýldý
    }
}

