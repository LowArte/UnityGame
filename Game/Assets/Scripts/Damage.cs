using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public SphereCollider collider;
    public PlayerProperty property;

    public List<GameObject> Enemys;
    public float atcDistance;
    public float fov;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
            Enemys.Add(other.gameObject);
    }

    private void Update()
    {
        int sdvig = 0;
        for (int i = 0; i < Enemys.Count; i++)
        {
            if (Enemys[i - sdvig] == null)
            {
                Enemys.Remove(Enemys[i - sdvig]);
                sdvig++;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Enemys.Remove(other.gameObject);
    }
    public void FindAngleAndSetAttack()
    {
        foreach (var other in Enemys)
        {
            if(other == null)
            {
                Enemys.Remove(other);
                continue;
            }
            Vector3 targetPos = other.transform.position;
            targetPos.y = transform.position.y;

            Vector3 targetDir = targetPos - transform.position;
            Vector3 forward = transform.forward;

            float angleBetween = Vector3.SignedAngle(targetDir, forward, Vector3.up);
            Debug.Log(angleBetween);

            if (other.gameObject.tag == "Enemy" && Mathf.Abs(angleBetween) <= fov / 2)
            {
                Debug.Log("SetDamage");
                other.GetComponent<PropertyAi>().hp -= property.damage;
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        collider.radius = atcDistance;   
    }

}
