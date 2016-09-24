using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum StateMachine{
	ONHOLD,
	START,
	INGAME,
	PAUSE,
	GAMEOVER
}

public class GameController : MonoBehaviour {

	private StateMachine currentStateMachine;
	private int score;

	public Text textScore ;


	public int pointCont{
		get;
		set;
	}
		

	// Use this for initialization
	void Start () {
		currentStateMachine = StateMachine.START;
	}

	// Update is called once per frame
	void Update () {
		StateGame ();
	}

	private void StateGame(){
		switch (currentStateMachine) {
		case StateMachine.ONHOLD:
			{
				SceneManager.LoadScene ("Menu");
				break;
			}

		case StateMachine.START:
			{
				StartGame ();
				break;
			}

		case StateMachine.PAUSE:
			{
				break;
			}


		case StateMachine.GAMEOVER:
			{
				GameOver ();
				break;
			}

		case StateMachine.INGAME:
			{
				InGame ();
				textScore.text = score.ToString ();
				break;
			}

		}
	}

	public StateMachine getStateMachine(){
		return currentStateMachine;
	}

	public void setStateMachine(StateMachine other){
		currentStateMachine = other;
	}

	public int getScore(){
		return score;
	}

	public void setScore(int other){
		this.score = other;
	}

	private void InGame(){
		//textScore.text = score.ToString ();
	}

	private void StartGame(){
		score = 0;
		currentStateMachine = StateMachine.INGAME;
	}

	public void AddScore(int sim){
		this.score += sim;
	}

	private void GameOver(){
		//PlayerPrefs.SetInt ("score", score);
		//if (score > PlayerPrefs.GetInt ("bestScore")) {
		//	PlayerPrefs.SetInt("bestScore", score);
		//}

		SceneManager.LoadScene ("GameOVer");
	}



}

