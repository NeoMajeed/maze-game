using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveScript : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            playerRigidbody.AddForce(new Vector3(0, 0, force), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigidbody.AddForce(new Vector3(0, 0, -force), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(new Vector3(-force, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(new Vector3(force, 0, 0), ForceMode.VelocityChange);
        }
    }
}