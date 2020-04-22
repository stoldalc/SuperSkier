using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkierPhysics : MonoBehaviour
{
    public SkierEntity entity;



    // Start is called before the first frame update
    void Start()
    {
        entity = GetComponentInParent<SkierEntity>();
        entity.position = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Utils.ApproximatelyEqual(entity.speed, entity.desiredSpeed))
        {

        }
        else if (entity.speed < entity.desiredSpeed)
        {
            entity.speed = entity.speed + entity.acceleration * Time.deltaTime;
        }
        else if (entity.speed > entity.desiredSpeed)
        {
            entity.speed = entity.speed - entity.acceleration * Time.deltaTime;
        }
        entity.speed = Utils.Clamp(entity.speed, entity.minSpeed, entity.maxSpeed);

        entity.position = entity.position + entity.velocity * Time.deltaTime;
        transform.localPosition = entity.position;

        //Debug.Log("Before logic statments: Entitys current x pos is " + entity.position.x + " and desired x pos is " + entity.desiredPosition.x);
        if(Utils.ApproximatelyEqual(entity.position.x, entity.desiredPosition.x))
        {
            //Debug.Log("Approx equal returned true");
        }
        else if(entity.position.x > entity.desiredPosition.x)
        {
            entity.position.x -= entity.left2RightSpeed;
        }
        else if(entity.position.x < entity.desiredPosition.x)
        {
            entity.position.x += entity.left2RightSpeed;
        }
        //Debug.Log("After logic statments: Entitys current x pos is " + entity.position.x + " and desired x pos is " + entity.desiredPosition.x);
        transform.localPosition = entity.position;
    }


    public AudioSource coinPickUpSound;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("In on trigger enter");
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            coinPickUpSound.Play();
            entity.score += 1;
        }
    }

   
}
