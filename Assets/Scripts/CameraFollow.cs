using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPos;
    public Vector3 offset;
    
    void FixedUpdate()
    {
    //places the camera above the player with an offset
        transform.position = playerPos.position + offset;
    //increases the height or lowers it when the user wants
        if (Input.GetKey("q"))
        {
            offset.y += 2;
        }
        if (Input.GetKey("e"))
        {
            if (offset.y > playerPos.position.y)
            {
                offset.y -= 2;
            }
        }
    }
}
