using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class BounceScript : MonoBehaviour 
{
    public float BouncePower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Rigidbody rb = other.rigidbody;

        float paddleX = transform.position.x;
        float ballX = other.transform.position.x;

        Vector3 forceVector = new Vector3(ballX - paddleX, 1, 0).normalized;
        rb.AddForce(forceVector * BouncePower, ForceMode.VelocityChange);
        rb.useGravity = false;
    }
}
