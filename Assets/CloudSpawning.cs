using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawning : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 5;
    private float time = 0;
    public float height = 12;
    public float length = 6;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnRate){
            time = time + Time.deltaTime;
        }
        else{
            spawnCloud();
            time = 0;
        }
    }
    void spawnCloud()
    {
        float lowestPoint = transform.position.y - height;
        float highestPoint = transform.position.y + height;
        float startPoint = transform.position.x - length;
        float endPoint = transform.position.x + length;
        Instantiate(cloud, new Vector3(Random.Range(startPoint,endPoint),Random.Range(lowestPoint,highestPoint),0),transform.rotation);
    }
}
