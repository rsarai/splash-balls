using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {
	private GameController gc;


	public void AddPointsCont(int point){
		gc.pointCont += point;
	}

	// Use this for initialization
	void Start () {
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}

	// Update is called once per frame
	void Update () {

	}
}
