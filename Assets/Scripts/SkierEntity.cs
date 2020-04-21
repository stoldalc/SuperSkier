using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkierEntity : MonoBehaviour
{
    // Start is called before the first frame update

    //-----------------------------
    //Skier stats
    //-----------------------------
    public float maxSpeed;
    public float minSpeed;
    public float left2RightSpeed;
    public float acceleration;



    //-----------------------------
    //Skier current vals
    //-----------------------------
    public Vector3 velocity;
    public Vector3 position;

    public float speed;
    public float desiredSpeed;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
