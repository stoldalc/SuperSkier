using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMgr : MonoBehaviour
{
    public static ControlMgr inst;

    public SkierEntity skier;


    private void Awake()
    {
        inst = this;
    }


    public float left2RightDELTA = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            skier.desiredPosition.x -= left2RightDELTA;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            skier.desiredPosition.x += left2RightDELTA;
        }
    }
}
