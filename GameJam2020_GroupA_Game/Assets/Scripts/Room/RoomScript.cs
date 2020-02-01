﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    private GameManager manager;
    public float maxHealth;
    public float health;
    private bool isActive = false;
    private bool islocked = true;
    private int roomType;
    private int maxRoomUpgrades;
    private int roomUpgrade;
    public int upgradeCost;
    public bool canBeRepaired;

    //
    //defaulted to false for start
    private void Start()
    {
        manager = GameObject.Find("SpaceShip").GetComponent<GameManager>();
    }
    private void Update()
    {
        if (health <= 0 && isActive)
        {
            isActive = false;
            health = 0;

        }

        if (health > 0 && !isActive)
        {
            isActive = true;

        }
    }


    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            isActive = false;
        }
    }

    public void addHealth(float health)
    {
        if (maxHealth > this.health + health)
        {
            //repair has made this max health
            this.health += health;
            isActive = true;
        }
        else
        {
            this.health = maxHealth;
        }
    }

    public int returnRoomType()
    {
        return roomType;
    }
    public int returnRoomUpgrade()
    {
        return roomUpgrade;
    }

    private void upgradeRoom()
    {
        if (maxRoomUpgrades > roomUpgrade + 1)
        {
            //confirmed that it will not upgrade past max
            if (manager.returnScrap() > upgradeCost)
            {
                //you can pay for the upgrade
                roomUpgrade += 1;
            }
        }
    }


}
