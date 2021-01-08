using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropScript : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Falling");
        ball.GetComponent<Rigidbody>().useGravity = true;
    }
}
