using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horrizontal");
        float inputY = Input.GetAxis("Vertical");
        move = new Vector2 (speed.x * inputX , speed.y*inputY);
    }
}
