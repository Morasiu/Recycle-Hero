using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour {

	public static GameObject[] trashArray;
	int arraySize;

	// Use this for initialization
	void Start () {
		trashArray = Resources.LoadAll<GameObject> ("TrashPrefabs");
		arraySize = trashArray.Length;
		SpawnRandomTrash ();
	}
	
	// Update is called once per frame
	public void SpawnRandomTrash () {
		int trashIndex = Random.Range (0, arraySize);
		GameObject spawnedTrash = Instantiate (trashArray [trashIndex]) as GameObject;
		//GameObject spawnedTrash = Instantiate (trashArray [10]) as GameObject;
		spawnedTrash.transform.parent = transform;
	}
}
