using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Fireport;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(Bullet, Fireport.position, Fireport.rotation);
        }
    }

}
