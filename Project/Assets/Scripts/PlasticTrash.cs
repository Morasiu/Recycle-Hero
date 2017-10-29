using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlasticTrash : MonoBehaviour {

	public GameObject trashSpawner;
	public GameObject score;
	public AudioClip sound;
	AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		source.playOnAwake = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Plastic") {
			score.GetComponent<Score> ().addScore ();
			Destroy (collider.gameObject);
			trashSpawner.GetComponent<TrashSpawner> ().SpawnRandomTrash();
			source.PlayOneShot(sound, 1f);
		} else  {
			SceneManager.LoadScene ("GameOver");
		}
	}
}
