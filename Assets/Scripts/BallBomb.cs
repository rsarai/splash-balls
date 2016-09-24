using UnityEngine;
using System.Collections;

public class BallBomb : BallBehaviour {
	public GameObject skull;

	private Animator anim;
	private GameController gc;
	// Use this for initialization
	void Start () {
		base.Start ();
		skull.SetActive (false);
		anim = GetComponentInChildren<Animator> ();
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
	}

	void OnMouseOver(){
		skull.SetActive (true);
	}

	void OnMouseDown(){
			anim.SetBool ("Shoot", true);
			Debug.Log ("Game over");
			Destroy (gameObject, 0.5f);
			gc.setStateMachine (StateMachine.GAMEOVER);
	}
}
