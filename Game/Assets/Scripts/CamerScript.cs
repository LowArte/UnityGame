using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerScript : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;

    public float pitch = 2f;
    public float yawSpeed = 50f;

    public float currentZoom = 5f;
    public float currentYaw = 0f;

    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        currentYaw -= Input.GetAxis("Horizontal") * yawSpeed;
        
        if(currentYaw >= 360 || currentYaw <= -360)
        {
            currentYaw = 0;
        }

        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.forward * pitch);

        transform.RotateAround(target.position, Vector3.down, currentYaw);

    }
}
