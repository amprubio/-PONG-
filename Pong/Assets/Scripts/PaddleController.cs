﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

    [Header("BOTONES PARA EL CONTROL DE CADA UNA DE LAS PALAS")]
    public KeyCode up, down; 
    private float speed = 3.33f;

    private Vector3 size;
    //Vector que coge la escala del objeto
    void Start()
    {
        size = transform.localScale;
    }

    //El movimiento está limitado de ALTOMUNDO/2 a -ALTOMUNDO/2 (3 A -3)
    void Update()
    {
        
        if ((transform.position.y + (size.y / 2) < GameManager.ALTOMUNDO / 2))
        {
            if (Input.GetKey(up))
            {
                transform.Translate(0, speed* Time.deltaTime, 0);

            }
        }

        if (transform.position.y - (size.y / 2) > -GameManager.ALTOMUNDO / 2)
        {
            if (Input.GetKey(down))
            {

                transform.Translate(0, -speed*Time.deltaTime, 0);

            }

        }
    }
}

