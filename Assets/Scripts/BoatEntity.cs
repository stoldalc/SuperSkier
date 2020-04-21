using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatEntity : MonoBehaviour
{
    //----------------------------------
    //Boat stats
    //----------------------------------
    public float acceleration;
    public float turnRate;
    public float maxSpeed;
    public float minSpeed;



    //----------------------------------
    //Boat Current heading and speed values
    //----------------------------------
    public bool isSelected = false;
    public Vector3 velocity = Vector3.zero;
    public Vector3 position;

    public float speed;
    public float desiredSpeed;
    public float desiredHeading;
    public float heading;

    public GameObject CameraRig;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
