﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    [SerializeField]
    private Bullet bulletPrefab;

    [SerializeField]
    private float bulletSpeed = 5f;

    [SerializeField]
    private float firingRate = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if( Input.GetKeyDown(KeyCode.Space))
        {
            // start firing
            InvokeRepeating("Shoot", 0f, firingRate);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            // stop firing
            CancelInvoke("Shoot");
        }
    }

    private void Shoot() 
    {
        Bullet bullet = Instantiate(bulletPrefab);
        bullet.transform.position = transform.position;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * bulletSpeed;
    }
}
