using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour {

	public float hitTimeMod;
	private float scaleMod = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (scaleMod >= .1) {
			scaleMod = Mathf.Lerp (scaleMod, 0, hitTimeMod);
			transform.localScale *= scaleMod;
		} else {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D _col){
		if (_col.tag == "Enemy") {
			_col.gameObject.transform.GetComponent<Dummy> ().Hit ();
		}
	}
}
