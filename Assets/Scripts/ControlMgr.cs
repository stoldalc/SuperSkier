using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMgr : MonoBehaviour
{
    public static ControlMgr inst;

    public SkierEntity skier;

    public BoatEntity boat;


    private void Awake()
    {
        inst = this;
    }


    public float left2RightDELTA = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float speed;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Debug.Log("Move vertical val: " + moveVertical);



        //Vector3 movment = new Vector3(moveHorizontal, 0, boat.speed/10);
        Vector3 movment = new Vector3(moveHorizontal, 0, 0);

        Debug.Log("Movment vec vals: " + movment);

        skier.rb.AddForce(movment*speed);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            //skier.desiredPosition.x -= left2RightDELTA;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //skier.desiredPosition.x += left2RightDELTA;
        }
    }
}
