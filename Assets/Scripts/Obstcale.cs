using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstcaleAttack : MonoBehaviour
{

    public Transform skier;

    public float inRange;

    public float attackSpeed;

    public float stopSpeed;

    public bool hasAttacked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(skier);
        if (Vector3.Distance(transform.position, skier.position) < inRange)
        {
            transform.position += transform.forward * attackSpeed * Time.deltaTime;
            hasAttacked = true;
        }
        else if(hasAttacked && (Vector3.Distance(transform.position, skier.position) > inRange))
        {
            

        }
        

    }
}
