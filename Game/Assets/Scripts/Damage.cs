using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public SphereCollider collider;
    public PlayerProperty property;

    public float atcDistance;
    public float fov;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log(other.gameObject.name);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        collider.radius = atcDistance;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
