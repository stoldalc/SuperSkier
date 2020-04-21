using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public BoatPhysics leader;
    public SkierPhysics follower;

    private void Awake()
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        follower.desiredSpeed = follower.maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 desiredFollowPos = leader.position;
        desiredFollowPos.x = desiredFollowPos.x + 100;
        follower.desiredHeading = Utils.AngleOfAttack(follower.position, desiredFollowPos);
        Debug.Log("Leader Position: " + leader.position + " Follower position: " + follower.position);
        */

        float followerX = follower.position.x;
        float followerY = follower.position.y;
        follower.position.z = leader.position.z-30;

    }
}
