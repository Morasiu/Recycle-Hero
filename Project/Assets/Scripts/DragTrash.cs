using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragTrash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		bool overSprite = this.GetComponent<SpriteRenderer> ().bounds.Contains (mousePosition);

		if (overSprite) {
			if (Input.GetButton ("Fire1")) {
				this.transform.position = new Vector3 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0f);
			} else if (Input.GetButtonUp("Fire1")){
				Debug.Log ("pls");
				this.transform.position = new Vector3 (0, 0, 0);
			}
		}
	}

	void OnMouseDrag() {
		//Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0f);
		//Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		//transform.position = mousePosition;
		//Debug.Log (mousePosition.x);
		//Debug.Log (mousePosition.y);

	}

	//public void OnDrag (PointerEventData eventData) {
	//	transform.position = eventData.position;
	//	Debug.Log (eventData);
	//}
}
