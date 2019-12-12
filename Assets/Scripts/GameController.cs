﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
 
    private int playerScore = 0;

    private void OnEnable()
    {
        // subscribe to the enemy getting killed event
        Enemy.EnemyKilledEvent += HandleEnemyKilledEvent;
    }

    private void OnDisable()
    {
        // unsubscribe
        Enemy.EnemyKilledEvent -= HandleEnemyKilledEvent;
    }

    private void HandleEnemyKilledEvent(Enemy enemy)
    {
        playerScore += enemy.ScoreValue;
        Debug.Log("Score: " + playerScore);
    }
}