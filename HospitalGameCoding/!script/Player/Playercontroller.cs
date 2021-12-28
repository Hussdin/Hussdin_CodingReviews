using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    float speed;
    float XDirection, YDirection;
    public Vector3 desirepos,desirero;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 5f;

    }
    private void Update()
    {
        XDirection = Input.GetAxis("Horizontal");
        YDirection = Input.GetAxis("Vertical");

        desirepos = new Vector3(0, 0,YDirection) * speed;
        desirepos *= Time.deltaTime;
        transform.Translate(desirepos);
        desirero = new Vector3(0, XDirection, 0);
        transform.Rotate(desirero);
    }

  
}
