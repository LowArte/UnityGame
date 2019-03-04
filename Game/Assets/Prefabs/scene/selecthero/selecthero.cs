using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selecthero : MonoBehaviour
{
    public CamerScript maincam;
    public GameObject heroprefab;
    public GameObject current;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("asd");
        if (other.tag == "Player")
        {

            maincam.target = heroprefab.transform;
            Destroy(current);
        }
    }

}
