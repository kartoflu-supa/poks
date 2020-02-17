using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public bool direction;
    public int distance;
    public bool xorz;
    public int stop;
    public int duration;
    int cooldown;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (cooldown == 0)
        {
            if (direction == true)
            {
                distance += 1;
                if (xorz == true)
                {
                    Vector3 next = transform.position;
                    next.x += 1;
                    transform.SetPositionAndRotation(next, transform.rotation);
                }
                if (xorz == false)
                {
                    Vector3 next = transform.position;
                    next.z += 1;
                    transform.SetPositionAndRotation(next, transform.rotation);
                }
            }
            else if (direction == false)
            {
                distance -= 1;
                if (xorz == true)
                {
                    Vector3 next = transform.position;
                    next.x -= 1;
                    transform.SetPositionAndRotation(next, transform.rotation);
                }
                if (xorz == false)
                {
                    Vector3 next = transform.position;
                    next.z -= 1;
                    transform.SetPositionAndRotation(next, transform.rotation);
                }
            }
            if (direction)
            {
                if (distance >= stop)
                {
                    direction = false;
                }
            }
            else
            {
                if (distance <= 0)
                {
                    direction = true;
                }
            }
            cooldown = duration;
        }
        else
        {
            cooldown -= 1;
        }
    }
}
