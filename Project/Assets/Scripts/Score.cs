using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	int score = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = "" + score;
	}

	public void addScore(){
		score++;
	}
}
