using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public SFX1 sfx;
    // Start is called before the first frame update
    void Start()
    {
        sfx = GameObject.FindGameObjectWithTag("SFX").GetComponent<SFX1>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3){
            sfx.coin();
            logic.addScore(1);
        }
    }
}
