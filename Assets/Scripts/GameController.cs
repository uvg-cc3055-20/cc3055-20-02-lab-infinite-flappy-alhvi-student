using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public bool gameOver = false;
    public int score = 0;
    public static GameController instance;
	
	void Start () {
        instance = this;	
	}
	
	void Update () {
		
	}
}
