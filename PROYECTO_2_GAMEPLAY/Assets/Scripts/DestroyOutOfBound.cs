using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    //limite de las balas (en la escena)
    private float upperLim = 30f;
    private float lowerLim = -5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < upperLim)
        {
            Destroy(gameObject);
        }
    }
}
