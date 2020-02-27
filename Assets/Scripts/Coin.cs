using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    public float rotatSpeed;
    
// this checks if the player hits
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            GameManager.instance.ChangeScore(coinValue);
            Destroy(this.gameObject);
        }
    }
// this rotates the coin
    private void Update()
    {
        transform.Rotate(rotatSpeed*Time.deltaTime, 0, 0);
    }
}
 
