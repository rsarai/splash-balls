using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {

	private float vel;
	private GameController gc;

	// Use this for initialization
	void Start () {
		vel = Random.Range (0.8f, 5.0f);
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}

	// Update is called once per frame
	void Update () {
		if (gc.getStateMachine () == StateMachine.INGAME) {
			MoveCloud ();
		}
	}

	void MoveCloud(){
		transform.Translate (vel * Time.deltaTime, 0, 0);

		if (transform.position.x > 36) {
			Destroy (gameObject);
		}
	}
}
