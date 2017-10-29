using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutWindow : MonoBehaviour {

	public Animator animator;
	public Button buttonAbout;

	int showed;

	// Use this for initialization
	void Start () {
		Button btn = buttonAbout.GetComponent<Button> ();
		animator.enabled = false;
		showed = 0;
		btn.onClick.AddListener(TaskOnClick);
	}

	void Update () {
		QuitInstructions ();
	}

	// Update is called once per frame
	void TaskOnClick () {
		animator.enabled = true;
		if (showed == 0) {
			animator.Play ("About");
			//buttonInstr.GetComponentInChildren<Text> ().text = "Once again bitch";
			showed = 1;
		}
	}

	void QuitInstructions () {
		if (showed == 1 && Input.anyKeyDown) {
			animator.Play ("HideAbout");
			showed = 0;
		}
	}
}

