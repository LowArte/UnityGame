﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInput : MonoBehaviour
{
    public PlayerProperty PlayerProperty;
    public Damage damage;
    public SpawnEnemies Spawn;
    public Canvas ShopUI;
    public Image helmet;
    public Image gloves;
    public Image sword;
    // Update is called once per frame
    void Start()
    {
        //ShopUI.enabled = false;
        PlayerProperty = GetComponent<CharacterController>().player;
        ShopUI.enabled = false;
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

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Attack");
            damage.FindAngleAndSetAttack();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (Input.GetKeyDown(KeyCode.H))
            {

            }
            if (Input.GetKeyDown(KeyCode.G))
            {

            }
            if (Input.GetKeyDown(KeyCode.S))
            {

            }
            ShopUI.enabled = true;

        }
    }
}
