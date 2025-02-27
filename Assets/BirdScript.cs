using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public LogicScript logic;
    public float flapStrength;
    public bool birdAlive=true;
    // Start is called before the first frame update
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdAlive){
            myRigidBody.velocity=Vector2.up*flapStrength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        logic.gameOver();
        birdAlive=false;
    }
}
