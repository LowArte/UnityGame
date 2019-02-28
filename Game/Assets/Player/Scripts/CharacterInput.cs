using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    public PlayerProperty PlayerProperty;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && PlayerProperty.isRunning)
        {
            PlayerProperty.isSprinting = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            PlayerProperty.isSprinting = false;
        }

    }
}
