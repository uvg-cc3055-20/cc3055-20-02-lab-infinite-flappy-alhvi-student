﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {

    private float scrollingSpeed = 2f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!GameController.instance.gameOver)
        {
            transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);
            if (transform.position.x < -10)
            {
                Destroy(gameObject);
            }
        }
    }
}
