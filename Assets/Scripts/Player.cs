using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float movement = 3.0f;
    private float rotateSpeed = 3.0f;
    public static Vector3 Position;

    // Start is called before the first frame update
    void Update()
    {
       if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
       {
           transform.Translate(Vector2.up * movement * Time.deltaTime);
       }
       else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector2.down * movement * Time.deltaTime);

       }
       else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector2.left * movement * Time.deltaTime);

       }
       else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector2.right * movement * Time.deltaTime);

       }

       if(Input.GetKey(KeyCode.LeftArrow))
       {
           transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
       }
       else if(Input.GetKey(KeyCode.RightArrow))
       {
           transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
       }

    

    }

    // Update is called once per frame
  /*  void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movement;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * movement;

        var newXpos = transform.position.x + deltaX;
        var newYpos = transform.position.y + deltaY;

        transform.position = new Vector2(newXpos, newYpos);


    }*/
}
