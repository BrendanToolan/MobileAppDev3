﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // == fields ==
    // use this later for scores and collisions
    [SerializeField]
    private int scoreValue = 10;

    public int ScoreValue { get { return scoreValue; } }

   
    public delegate void EnemyKilled(Enemy enemy);

    // game controller subscribes to this
    public static EnemyKilled EnemyKilledEvent;

    private void Start()
    {

    }

    // handle the collisions
    private void OnTriggerEnter2D(Collider2D WhatHitMe)
    {
       
        var bullet = WhatHitMe.GetComponent<Bullet>();
        var player = WhatHitMe.GetComponent<Player>();

        string tagType = gameObject.tag;

        if(bullet && tagType == "EnemyCircle")
        {
                    
            Destroy(bullet.gameObject);
            PublishEnemyKilledEvent();
            Destroy(gameObject);
        }
   

    }

    private void PublishEnemyKilledEvent()
    {
        if (EnemyKilledEvent != null)
        {
            // there is a listener, so publish
            EnemyKilledEvent(this);
        }
    }

    
}