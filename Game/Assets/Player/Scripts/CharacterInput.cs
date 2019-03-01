﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    PlayerProperty PlayerProperty;
    public SpawnEnemies Spawn;
    // Update is called once per frame
    void Start()
    {
        PlayerProperty = GetComponent<CharacterController>().player;
    }

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

        if (Input.GetKeyDown(KeyCode.V))
        {
            Spawn.StartWawe();
        }
    }
}
