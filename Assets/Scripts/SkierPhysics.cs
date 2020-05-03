using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkierPhysics : MonoBehaviour
{
    public SkierEntity entity;

    public BoatEntity boat;


    // Start is called before the first frame update
    void Start()
    {
        entity = GetComponentInParent<SkierEntity>();
        entity.position = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public AudioSource coinPickUpSound;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("In on trigger enter");
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            coinPickUpSound.Play();
            SkierEntity.score += 1;
        }
        if (other.gameObject.CompareTag("Ramp"))
        {
            boat.speed = boat.maxSpeed;
            boat.desiredSpeed = boat.cruisingSpeed;
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            boat.speed = 0;
            boat.desiredSpeed = boat.cruisingSpeed;
        }
    }

   
}
