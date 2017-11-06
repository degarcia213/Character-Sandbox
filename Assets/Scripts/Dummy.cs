using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour {

	private int maxHP = 5;
	private int HP;
	private Animator animator;
	private bool dead;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponent<Animator> ();
		HP = maxHP;
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetBool ("dummyDead", dead);
	}

	public void Hit(){
		animator.Play ("DummyHit");
		HP -= 1;
		if (HP <= 0) {
			dead = true;
			HP = 0;
		}
	}

	void Die(){

	}
}
