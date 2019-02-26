using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody>().AddForce(-1*speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Rigidbody>().AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Rigidbody>().AddForce(0, 0, -1*speed);
        }
    }
}
