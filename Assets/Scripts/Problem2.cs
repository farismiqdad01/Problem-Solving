﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem2 : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1, 1) * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
