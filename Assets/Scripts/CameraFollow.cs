using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPos;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = playerPos.position + offset;
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
