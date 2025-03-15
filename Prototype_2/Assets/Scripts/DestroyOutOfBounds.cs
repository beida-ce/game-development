using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35;
    private float bottomBound = -13;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        // Destroy pizzas whenever they hit the top boundary.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        // If an object goes past the players view in the game, remove that object.
        else if (transform.position.z < bottomBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
