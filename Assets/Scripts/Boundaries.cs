using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public Camera mainCam;
    private Vector2 screenBound;
    private float objectWidth, objectHeight;

    void Start()
    {
        screenBound = mainCam.ScreenToWorldPoint(
        new Vector3(Screen.width, Screen.height, mainCam.transform.position.z));

        objectWidth = gameObject.GetComponent<SpriteRenderer>().bounds.extents.x;
        objectHeight = gameObject.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    private void lateUpdate(){
        Vector3 viewPos = transform.position;

        viewPos.x = Mathf.Clamp(viewPos.x, screenBound.x * -1 + objectWidth, screenBound.x - objectHeight);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBound.y * -1 + objectHeight, screenBound.y - objectHeight);

        transform.position = viewPos;

    }

}
