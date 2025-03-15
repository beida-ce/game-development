using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public Transform Player; // Uçağı temsil eden Transform
    private Vector3 offset; // Kamera ile uçak arasındaki mesafe

    void Start()
    {
        // Offset değerini başlangıçta ayarla
        offset = new Vector3(30, 0, 0);
    }

    void LateUpdate()
    {
        if (Player != null)
        {
            // Kameranın pozisyonunu uçağın pozisyonuna göre ayarla
            transform.position = Player.position + offset;

            // Kameranın uçağa bakmasını sağla
            transform.LookAt(Player);
        }
    }
}


