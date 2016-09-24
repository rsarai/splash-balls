using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	private int i;
	private Animator anim;
	public int pontos;
	private GameController gc;

	// Use this for initialization
	protected void Start () {
		i = Random.Range (-15, 15);
		anim = GetComponentInChildren<Animator> ();
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	protected void Update () {
		if (gc.getStateMachine () == StateMachine.INGAME) {
			Rotate ();
			SelfDestroy ();
		}
	}

	void Rotate(){
		
		this.gameObject.transform.eulerAngles = new Vector3 (0f, 0f, transform.eulerAngles.y -i);
		if (i > 0) {
			i+=5;
		} else {
			i-=5;
		}
	}

	void SelfDestroy(){
		if (transform.position.y < -10) {
			Debug.Log ("Tira uma vida do cara");
			Destroy (gameObject);

		}
	}

	void OnMouseDown(){
		if (transform.tag == "Ball") {
			anim.SetBool ("Shoot", true);
			Debug.Log ("GG");
			gc.AddScore (pontos);
			Destroy (gameObject, 0.5f);
			//contar pontos
		} 
	}


}
