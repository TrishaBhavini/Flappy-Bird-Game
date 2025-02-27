using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRte=2;
    private float timer=0;
    public float hgtOffset=9;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRte){
            timer+=Time.deltaTime;
        }
        else{
            spawnPipe();
            timer=0;
        }
    }
    void spawnPipe(){
        float low=transform.position.y-hgtOffset;
        float high=transform.position.y+hgtOffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(low,high),0),transform.rotation);
    }
}
