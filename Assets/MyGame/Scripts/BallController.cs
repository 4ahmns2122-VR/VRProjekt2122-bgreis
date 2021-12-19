using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    public GameObject emmitter;
    public float Force = 100; 
    private Rigidbody rb;



    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject BallInstance = Instantiate(ball, emmitter.transform.position, Quaternion.identity);
            rb = BallInstance.GetComponent<Rigidbody>();
            //rb.AddForce(Vector3.forward * Force);
        }
    }
}
