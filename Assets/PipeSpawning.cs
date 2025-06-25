using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawning : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float time = 0;
    public float height = 12;
    // Start is called before the first frame update
    void Start()
    {
       spawnPipe(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnRate){
            time = time + Time.deltaTime;
        }
        else{
            spawnPipe();
            time = 0;
        }
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - height;
        float highestPoint = transform.position.y + height;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
