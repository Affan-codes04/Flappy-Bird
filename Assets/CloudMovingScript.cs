using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovingScript : MonoBehaviour
{
    public float speed = 7;
    public float end = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed);
        if (transform.position.x < end){
            Destroy(gameObject);
        }
    }
}
