﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class PointSpawners : MonoBehaviour
{
    [SerializeField]
    private Enemy enemyPrefab;

    [SerializeField]
    private float delayTime = 0.5f;

    [SerializeField]
    private float intRate = 0.3f;

    private GameObject enemyParent;

    private IList<SpawnPoint> spawnPoints;
    private Stack<SpawnPoint> spawnStack;

    void Start()
    {
        enemyParent = GameObject.Find("EnemyParent");
        if (!enemyParent)
        {
            enemyParent = new GameObject("EnemyParent");
        }

        spawnPoints = GetComponentsInChildren<SpawnPoint>();
        
        SpawnEnemiesRepeating();
    }

    private void SpawnEnemiesRepeating()
    {
        spawnStack = ListUtils.CreateShuffledStack(spawnPoints);
        InvokeRepeating("Spawn", delayTime, intRate);
    }

    private void Spawn()
    {
        if(spawnStack.Count == 0){
            spawnStack = ListUtils.CreateShuffledStack(spawnPoints);
        }

        var currentPoint = spawnStack.Pop();
        var enemy = Instantiate(enemyPrefab, enemyParent.transform);
        enemy.transform.position = currentPoint.transform.position;
    }

}
