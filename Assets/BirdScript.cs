using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D body;
    public float flapStrength;
    public LogicScript logic;
    public SFX1 sfx;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        sfx = GameObject.FindGameObjectWithTag("SFX").GetComponent<SFX1>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive == true){
            sfx.jump();
            body.velocity = Vector2.up * flapStrength;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision){
        sfx.over();
        logic.gameOver();
        isAlive = false;
    }
}
