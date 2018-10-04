﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    float health;

    public float goldAmount;

    enum Weakness { Fire, Plant, Water };

    [SerializeField]
    private Weakness enemyWeakness;

    public void TakeDamage(float amount)
    {
        Debug.Log(health);
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}