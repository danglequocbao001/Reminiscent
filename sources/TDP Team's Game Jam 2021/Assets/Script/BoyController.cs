﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyController : MonoBehaviour
{
    public FixedJoystick joystick;
    public float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        Transform transform = gameObject.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(joystick.Horizontal * speed * Time.deltaTime, joystick.Vertical * speed * Time.deltaTime, 0));
        if(joystick.Horizontal > 0) gameObject.GetComponent<SpriteRenderer>().flipX = true;
        if(joystick.Horizontal < 0) gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }
}
