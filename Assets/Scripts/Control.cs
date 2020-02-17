using UnityEngine;

public class Control : MonoBehaviour
{
    public Rigidbody gravity;
    public float sped = 1000;
    bool jump = false;
    Vector3 spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "grund")
        {
            jump = false;
        }
    }
    private void Update()
    {
        if (transform.position.y < 0)
        {
            transform.SetPositionAndRotation(spawn,transform.rotation);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (jump)
        {
            if (transform.position.y == 1)
            {
                jump = false;
            }
        }
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
        if (Input.GetKeyDown(KeyCode.Space) && jump == false)
        {
            gravity.AddForce(0, 20000 * Time.deltaTime, 0);
            jump = true;
        }
    }
    
}
