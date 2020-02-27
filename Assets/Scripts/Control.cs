using UnityEngine;

public class Control : MonoBehaviour
{
    public Rigidbody gravity;
    public float sped = 1000;
    bool jump = false;
    Vector3 spawn;
    void Start()
    {
        spawn = transform.position; //creates the spawn point
    }
//checks if player is grounded
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "grund")
        {
            jump = false;
        }
    }
    private void Update()
    {
    //checks if player has fallen of the map and resets them
        if (transform.position.y < 0)
        {
            transform.SetPositionAndRotation(spawn,transform.rotation);
            gravity.velocity = Vector3.zero;
        }
    }
    
    void FixedUpdate()
    {
    //controls for the player to use
        if (Input.GetKey("d"))
        {
            gravity.AddForce(sped * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            gravity.AddForce(-sped * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            gravity.AddForce(0, 0, sped * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            gravity.AddForce(0, 0, -sped * Time.deltaTime);
        }
    //allow the player to jump only when they aren't jumping
        if (Input.GetKeyDown(KeyCode.Space) && jump == false)
        {
            gravity.AddForce(0, 20000 * Time.deltaTime, 0);
            jump = true;
        }
    }
    
}
