using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionWindow : MonoBehaviour {

	public Animator animator;
	public Button buttonInstr;

	int showed;

	// Use this for initialization
	void Start () {
		Button btn = buttonInstr.GetComponent<Button> ();
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
			animator.Play ("Instruction");
			//buttonInstr.GetComponentInChildren<Text> ().text = "Once again bitch";
			showed = 1;
		}
	}

	void QuitInstructions () {
		if (showed == 1 && Input.anyKeyDown) {
			animator.Play ("HideInstr");
			showed = 0;
		}
	}
}

