using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientedPhysicsSkier : MonoBehaviour
{
    public SkierPhysics entity;

    // Start is called before the first frame update
    void Start()
    {
        entity = GetComponentInParent<SkierPhysics>();
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

    }
}
