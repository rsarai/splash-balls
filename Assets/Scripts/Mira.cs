using UnityEngine;
using System.Collections;

public class Mira : MonoBehaviour {
	private GameController gc;

	// Use this for initialization
	void Start () {
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		if (gc.getStateMachine () == StateMachine.INGAME) {
			transform.position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
		}
	}
	/*
	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Ball") {
			anim.SetBool ("Shoot", true);
			Debug.Log ("GG");
			//contar pontos
		} else if (other.gameObject.tag == "Bomb") {
			Debug.Log ("Game over");
		}
	}
	*/	
}
